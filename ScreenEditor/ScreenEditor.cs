using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Reflection;
using System.IO;
using ScreenEditor.DataBase;
using ScreenEditor.Controllers;

namespace ScreenEditor
{
    public partial class ScreenEditor : Panel
    {
        private readonly ControlManipulator controlManipulator = new ControlManipulator();
        private ScreenData screenData = new ScreenData();
        internal readonly ScreenEditorDrawing drawing;
        private ScreenEditorLayoutTool layoutTool;
        private Control selectedControl;
        private Control lastSelectedControl;

        private bool offset = true;
        int xOffset = 0;
        int yOffset = 0;

        public Control LastSelectedControl { get => lastSelectedControl ?? drawing.SelectedControls[0]; set => lastSelectedControl = value; }
        public Control SelectedControl { get => selectedControl; set => selectedControl = value; }
        public ScreenEditorLayoutTool LayoutTool { get => layoutTool; set => layoutTool = value; }
        public ScreenData ScreenData { get => screenData; }

        public ScreenEditor()
        {
            InitializeComponent();
            LayoutTool = new ScreenEditorLayoutTool(this);
            drawing = new ScreenEditorDrawing(this);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public void Save()
        {
            UpdateDataBase();
            ScreenData.Save();
        }

        public void Load(string path, ref ScreenEditor sreenEditor)
        {
            string jsonStr = File.ReadAllText(path);

            screenData = JsonConvert.DeserializeObject<ScreenData>(jsonStr);
            Controls.Clear();
            foreach (ControlData control in screenData.Controls)
            {
                string assembly = control.Properties.Type.Split('.')[0];
                _ = typeof(Control);
                Type type;
                switch (assembly)
                {
                    case "System":
                        type = typeof(Control);
                        break;
                    case "MetroFramework":
                        type = typeof(MetroFramework.Controls.MetroUserControl);
                        break;
                    default:
                        type = typeof(Control);
                        break;
                }
                Control newControl = control.CreateControl(type);
                Controls.Add(newControl);
            }

            screenData.Properties.To(ref sreenEditor);
        }

        public void UpdateDataBase()
        {
            ScreenData.Controls.Clear();
            foreach (Control control in Controls)
            {
                ScreenData.Controls.Add(new ControlData(control));
            }

            ScreenData.Properties.From(this);
        }

        public bool FileChanged()
        {
            UpdateDataBase();
            string thisJson = JsonConvert.SerializeObject(ScreenData, Formatting.Indented);
            string fileJson = File.ReadAllText(ScreenData.Path);
            return thisJson != fileJson;
        }

        public void DeleteSelectedControls()
        {
            foreach (var c in drawing.SelectedControls)
            {
                Controls.Remove(c);
                c.Dispose();
            }
            drawing.SelectedControls.Clear();
            SelectedControl = null;
        }

        private void ScreenEditor_ControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.MouseMove += new MouseEventHandler(Control_MouseMove);
            e.Control.MouseEnter += new EventHandler(Control_MouseEnter);
            e.Control.MouseLeave += new EventHandler(Control_MouseLeave);
        }

        private void ScreenEditor_MouseUp(object sender, MouseEventArgs e)
        {
            offset = true;
            selectedControl = null;
            drawing.SelectedControls.Clear();
            drawing.UpdateSelectedControlsDwg();
        }

        private void Control_MouseEnter(Object sender, EventArgs e)
        {
            selectedControl = (Control)sender;
            LastSelectedControl = selectedControl;
        }

        private void Control_MouseLeave(Object sender, EventArgs e)
        {
            selectedControl = null;
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing.SelectedControls.Count == 0)
            {
                controlManipulator.ManipulateControl(ref selectedControl, e, FindForm(), 10);
            }
            else
            {
                foreach (Control control in drawing.SelectedControls)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        drawing.UpdateSelectedControlsDwg();
                        if (offset)
                        {
                            xOffset = (e.Location.X);
                            yOffset = (e.Location.Y);
                            offset = false;
                            Console.WriteLine(string.Format("{0}x{1}", xOffset, yOffset));
                        }
                        int x = control.Location.X + e.Location.X - xOffset;
                        int y = control.Location.Y + e.Location.Y - yOffset;
                        control.Location = new Point(x, y);
                    }
                }
            }
        }

    }

    public class ScreenEditorLayoutTool
    {
        ScreenEditor screen;

        public ScreenEditorLayoutTool(ScreenEditor screen)
        {
            this.screen = screen;
        }

        public void AlignLeft()
        {
            var x = screen.LastSelectedControl.Location.X;
            foreach (Control control in screen.drawing.SelectedControls)
            {
                control.Location = new Point(x, control.Location.Y);
            }
        }

        public void AlignCenterY()
        {
            var x = screen.LastSelectedControl.Width/2;
            x += screen.LastSelectedControl.Location.X;
            foreach (Control control in screen.drawing.SelectedControls)
            {
                control.Location = new Point(control.Location.X + (x - control.Location.X - control.Width/2), control.Location.Y);
            }
        }

        public void AlignRight()
        {
            var x = screen.LastSelectedControl.Width;
            x += screen.LastSelectedControl.Location.X;
            foreach (Control control in screen.drawing.SelectedControls)
            {
                control.Location = new Point(control.Location.X + (x - control.Location.X - control.Width), control.Location.Y);
            }
        }

        public void AlignTop()
        {
            var y = screen.LastSelectedControl.Location.Y;
            foreach (Control control in screen.drawing.SelectedControls)
            {
                control.Location = new Point(control.Location.X, y);
            }
        }

        public void CenterX()
        {
            var y = screen.LastSelectedControl.Width / 2;
            y += screen.LastSelectedControl.Location.Y;
            foreach (Control control in screen.drawing.SelectedControls)
            {
                control.Location = new Point(control.Location.X, control.Location.Y + (y - control.Location.Y - control.Height / 2));
            }
        }

        public void AlignBotton()
        {
            var y = screen.LastSelectedControl.Width / 2;
            y += screen.LastSelectedControl.Location.Y;
            foreach (Control control in screen.drawing.SelectedControls)
            {
                control.Location = new Point(control.Location.X, control.Location.Y + (y - control.Location.Y - control.Height));
            }
        }

        public void AdjustWidth()
        {
            var width = screen.LastSelectedControl.Width;
            foreach (Control control in screen.drawing.SelectedControls)
            {
                control.Width = width;
            }
        }

        public void AdjustHeight()
        {
            var height = screen.LastSelectedControl.Height;
            foreach (Control control in screen.drawing.SelectedControls)
            {
                control.Height = height;
            }
        }

        public void AdjustSize()
        {
            var size = screen.LastSelectedControl.Size;
            foreach (Control control in screen.drawing.SelectedControls)
            {
                control.Size = size;
            }
        }

        public void AdjustDistanceX()
        {
            if (screen.drawing.SelectedControls.Count > 2)
            {
                var x1 = screen.drawing.SelectedControls[0].Location.X;
                var x2 = screen.drawing.SelectedControls[1].Location.X;
                var dist = x2 - x1;
                var acc = 0;
                foreach (Control control in screen.drawing.SelectedControls)
                {
                    control.Location = new Point(x1 + acc, control.Location.Y);
                    acc += dist;
                }
            }
        }

        public void AdjustDistanceY()
        {
            if (screen.drawing.SelectedControls.Count > 2)
            {
                var y1 = screen.drawing.SelectedControls[0].Location.Y;
                var y2 = screen.drawing.SelectedControls[1].Location.Y;
                var dist = y2 - y1;
                var acc = 0;
                foreach (Control control in screen.drawing.SelectedControls)
                {
                    control.Location = new Point(control.Location.X, y1 + acc);
                    acc += dist;
                }
            }
        }
    }
}
