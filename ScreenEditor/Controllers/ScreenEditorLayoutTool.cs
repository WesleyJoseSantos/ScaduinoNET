using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ScreenEditor.Controllers
{
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
            screen.CallControlHandled(screen.LastSelectedControl);
        }

        public void AlignCenterY()
        {
            var x = screen.LastSelectedControl.Width / 2;
            x += screen.LastSelectedControl.Location.X;
            foreach (Control control in screen.drawing.SelectedControls)
            {
                control.Location = new Point(control.Location.X + (x - control.Location.X - control.Width / 2), control.Location.Y);
            }
            screen.CallControlHandled(screen.LastSelectedControl);
        }

        public void AlignRight()
        {
            var x = screen.LastSelectedControl.Width;
            x += screen.LastSelectedControl.Location.X;
            foreach (Control control in screen.drawing.SelectedControls)
            {
                control.Location = new Point(control.Location.X + (x - control.Location.X - control.Width), control.Location.Y);
            }
            screen.CallControlHandled(screen.LastSelectedControl);
        }

        public void AlignTop()
        {
            var y = screen.LastSelectedControl.Location.Y;
            foreach (Control control in screen.drawing.SelectedControls)
            {
                control.Location = new Point(control.Location.X, y);
            }
            screen.CallControlHandled(screen.LastSelectedControl);
        }

        public void CenterX()
        {
            var y = screen.LastSelectedControl.Width / 2;
            y += screen.LastSelectedControl.Location.Y;
            foreach (Control control in screen.drawing.SelectedControls)
            {
                control.Location = new Point(control.Location.X, control.Location.Y + (y - control.Location.Y - control.Height / 2));
            }
            screen.CallControlHandled(screen.LastSelectedControl);
        }

        public void AlignBotton()
        {
            var y = screen.LastSelectedControl.Width / 2;
            y += screen.LastSelectedControl.Location.Y;
            foreach (Control control in screen.drawing.SelectedControls)
            {
                control.Location = new Point(control.Location.X, control.Location.Y + (y - control.Location.Y - control.Height));
            }
            screen.CallControlHandled(screen.LastSelectedControl);
        }

        public void AdjustWidth()
        {
            var width = screen.LastSelectedControl.Width;
            foreach (Control control in screen.drawing.SelectedControls)
            {
                control.Width = width;
            }
            screen.CallControlHandled(screen.LastSelectedControl);
        }

        public void AdjustHeight()
        {
            var height = screen.LastSelectedControl.Height;
            foreach (Control control in screen.drawing.SelectedControls)
            {
                control.Height = height;
            }
            screen.CallControlHandled(screen.LastSelectedControl);
        }

        public void AdjustSize()
        {
            var size = screen.LastSelectedControl.Size;
            foreach (Control control in screen.drawing.SelectedControls)
            {
                control.Size = size;
            }
            screen.CallControlHandled(screen.LastSelectedControl);
        }

        public void AdjustDistanceX(int offSet = 0)
        {
            int max = 0;
            int min = screen.ScreenData.Properties.Size.Width;

            if (screen.drawing.SelectedControls.Count <= 2) return;

            foreach (Control control in screen.drawing.SelectedControls)
            {
                max = Math.Max(control.Location.X, max);
                min = Math.Min(control.Location.X, min);
            }

            int interval = (max - min) / (screen.drawing.SelectedControls.Count - 1) + offSet;
            int acc = 0;
            foreach (Control control in screen.drawing.SelectedControls)
            {
                control.Location = new Point(min + acc, control.Location.Y);
                acc += interval;
            }

            screen.CallControlHandled(screen.LastSelectedControl);
        }

        public void AdjustDistanceY(int offSet = 0)
        {
            int max = 0;
            int min = screen.ScreenData.Properties.Size.Height;

            if (screen.drawing.SelectedControls.Count <= 2) return;

            foreach (Control control in screen.drawing.SelectedControls)
            {
                max = Math.Max(control.Location.Y, max);
                min = Math.Min(control.Location.Y, min);
            }

            int interval = (max - min) / (screen.drawing.SelectedControls.Count - 1) + offSet;
            int acc = 0;
            foreach (Control control in screen.drawing.SelectedControls)
            {
                control.Location = new Point(control.Location.X, min + acc);
                acc += interval;
            }

            screen.CallControlHandled(screen.LastSelectedControl);
        }
    }
}
