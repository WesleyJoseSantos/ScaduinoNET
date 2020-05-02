using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ScreenEditor.Controllers
{
    class ScreenEditorDrawing
    {
        private List<Control> selectedControls = new List<Control>();
        private Point mousePosA, mousePosB;
        private ScreenEditor screen;
        private Rectangle recPoints;
        private bool startDrawing;

        public ScreenEditor Screen { get => screen; set => screen = value; }

        public List<Control> SelectedControls { get => selectedControls; set => selectedControls = value; }

        public ScreenEditorDrawing(ScreenEditor screenEditor)
        {
            this.screen = screenEditor;
            screen.MouseMove += new System.Windows.Forms.MouseEventHandler(ScreenEditor_MouseMove);
            mousePosA = new Point();
            mousePosB = new Point();
            recPoints = new Rectangle();
            startDrawing = false;
        }

        public void UpdateSelectedControlsDwg()
        {
            var dwg = screen.CreateGraphics();
            dwg.Clear(Color.White);
            foreach (Control control in selectedControls)
            { 
                var pen = new Pen(Brushes.Black);
                var rect = new Rectangle(new Point(control.Location.X - 3, control.Location.Y - 3), control.Size + new Size(3, 3));
                pen.DashStyle = DashStyle.Dot;
                dwg.DrawRectangle(pen, rect);
            }
        }

        private void ScreenEditor_MouseMove(object sender, MouseEventArgs e)
        {
            var dwg = screen.CreateGraphics();
            if(e.Button == MouseButtons.Left && !startDrawing)
            {
                SelectedControls.Clear();
                mousePosA = e.Location;
                startDrawing = true;
            }
            if(e.Button == MouseButtons.None)
            {
                if (startDrawing)
                {
                    dwg.Clear(Color.White);
                    UpdateSelectedControls();
                }
                startDrawing = false;
            }
            if (startDrawing)
            {
                mousePosB = e.Location;
                recPoints = RectangleFromPoints(mousePosA, mousePosB);
                dwg.Clear(Color.White);
                var blackPen = new Pen(Color.Black, 1)
                {
                    DashStyle = DashStyle.Dash
                };
                dwg.DrawRectangle(blackPen, recPoints);
            }
        }

        private Rectangle RectangleFromPoints(Point A, Point B)
        {
            int x1, x2, y1, y2;
            x1 = Math.Min(A.X, B.X);
            y1 = Math.Min(A.Y, B.Y);
            x2 = Math.Max(A.X, B.X);
            y2 = Math.Max(A.Y, B.Y);
            Point location;
            Size size;
            location = new Point(x1, y1);
            size = new Size(x2 - x1, y2 - y1);
            return (new Rectangle(location, size));
        }

        private void UpdateSelectedControls()
        {
            foreach (Control control in screen.Controls)
            {
                if (recPoints.Contains(control.Location))
                {
                    if (!selectedControls.Contains(control))
                    {
                        selectedControls.Add(control);
                    }
                }
            }
            UpdateSelectedControlsDwg();
        }


    }
}
