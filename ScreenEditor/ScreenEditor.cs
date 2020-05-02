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
        internal readonly ScreenEditorDrawing drawing;
        private readonly ControlManipulator controlManipulator = new ControlManipulator();

        private ScreenEditorRealTimeParser parser;
        private ScreenEditorLayoutTool layoutTool;
        private ScreenData screenData = new ScreenData();

        private Control lastPointedControl;
        private Control pointedControl;

        private bool moving = false;
        private bool offset = true;
        int xOffset = 0;
        int yOffset = 0;

        public Control LastSelectedControl { get => lastPointedControl ?? drawing.SelectedControls[0]; set => lastPointedControl = value; }
        public Control PointedControl { get => pointedControl; set => pointedControl = value; }
        public ScreenEditorLayoutTool LayoutTool { get => layoutTool; set => layoutTool = value; }
        public ScreenData ScreenData { get => screenData; set => screenData = value; }
        public ScreenEditorRealTimeParser Parser { get => parser; set => parser = value; }

        public event EventHandler ControlHandled;

        public ScreenEditor()
        {
            InitializeComponent();
            LayoutTool = new ScreenEditorLayoutTool(this);
            Parser = new ScreenEditorRealTimeParser(this);
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

            ReloadFromDataBase();

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

        public void ReloadFromDataBase()
        {
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
            PointedControl = null;
        }

        public void CallControlHandled(Control control)
        {
            ControlHandled(this, new ControlEventArgs(control));
        }

        private void ScreenEditor_ControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.MouseMove += new MouseEventHandler(Control_MouseMove);
            e.Control.MouseEnter += new EventHandler(Control_MouseEnter);
            e.Control.MouseLeave += new EventHandler(Control_MouseLeave);
            ControlHandled(sender, e);
        }

        private void ScreenEditor_MouseUp(object sender, MouseEventArgs e)
        {
            offset = true;
            pointedControl = null;
            drawing.SelectedControls.Clear();
            drawing.UpdateSelectedControlsDwg();
            if (moving)
            {
                ControlHandled(sender, e);
            }
            moving = false;
        }

        private void Control_MouseEnter(Object sender, EventArgs e)
        {
            pointedControl = (Control)sender;
            LastSelectedControl = pointedControl;
        }

        private void Control_MouseLeave(Object sender, EventArgs e)
        {
            pointedControl = null;
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing.SelectedControls.Count == 0)
            {
                controlManipulator.ManipulateControl(ref pointedControl, e, FindForm(), 10);
                if (e.Button == MouseButtons.Left)
                {
                    moving = true;
                }
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
                        moving = true;
                        control.Location = new Point(x, y);
                    }
                }
            }
        }

    }
}
