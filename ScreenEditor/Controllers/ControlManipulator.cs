using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenEditor.Controllers
{
    public class ControlManipulator
    {
        private bool AlowHS = false;
        private bool AlowVS = false;
        private bool AlowVHS = false;
        private int MXtmp = 0;
        private int MYtmp = 0;
        private int GMXtmp = 0;
        private int GMYtmp = 0;

        public void ManipulateControl(ref Control Sender, MouseEventArgs e, Form formX, int Offset = 10)
        {
            if (Sender == null) return;
            if (e.Button == MouseButtons.None)
            {
                if (e.Y > Sender.Height - Offset & e.Y < Sender.Height & e.X > Sender.Width - Offset & e.X < Sender.Width)
                {
                    Sender.Cursor = Cursors.SizeNWSE;
                    AlowHS = false;
                    AlowVS = false;
                    AlowVHS = true;
                }
                else if (e.Y > Sender.Height - Offset & e.Y < Sender.Height & e.X < Sender.Width - 1)
                {
                    Sender.Cursor = Cursors.SizeNS;
                    AlowVS = true;
                    AlowHS = false;
                    AlowVHS = false;
                }
                else if (e.X > Sender.Width - Offset & e.X < Sender.Width & e.Y < Sender.Height - 1)
                {
                    Sender.Cursor = Cursors.SizeWE;
                    AlowHS = true;
                    AlowVS = false;
                    AlowVHS = false;
                }
                else
                {
                    if (Sender.Cursor != Cursors.Hand)
                        Sender.Cursor = Cursors.Hand;
                    AlowHS = false;
                    AlowVS = false;
                    AlowVHS = false;
                }
            }

            if (e.Button == MouseButtons.Left)
            {
                if (Cursor.Position.X < formX.Left + formX.Width & Cursor.Position.Y < formX.Top + formX.Height)
                {
                    if (AlowHS == true)
                    {
                        if (Sender.Width > 1)
                            Sender.Width -= (MXtmp - e.X);
                        else
                            Sender.Width += 1;
                    }
                    else if (AlowVS == true)
                    {
                        if (Sender.Height > 1)
                            Sender.Height -= (MYtmp - e.Y);
                        else
                            Sender.Height += 1;
                    }
                    else if (AlowVHS == true)
                    {
                        if (Sender.Height > 1 & Sender.Width > 1)
                        {
                            Sender.Width -= (MXtmp - e.X);
                            Sender.Height -= (MYtmp - e.Y);
                        }
                        else
                        {
                            Sender.Height += 1;
                            Sender.Width += 1;
                        }
                    }
                    else
                    {
                        if (Sender.Top > 0 & Sender.Top < formX.Height - 50)
                            Sender.Top -= (GMYtmp - Cursor.Position.Y);
                        else if (Sender.Top <= 0)
                            Sender.Top += 1;
                        else
                            Sender.Top -= 1;

                        if (Sender.Left > 0 & Sender.Left < formX.Width - 30)
                            Sender.Left -= (GMXtmp - Cursor.Position.X);
                        else if (Sender.Left <= 0)
                            Sender.Left += 1;
                        else
                            Sender.Left -= 1;
                    }
                }
            }

            MXtmp = e.X;
            MYtmp = e.Y;
            GMXtmp = Cursor.Position.X;
            GMYtmp = Cursor.Position.Y;
        }
    }
}
