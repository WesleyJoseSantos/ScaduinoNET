using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonControls;
using MetroFramework.Controls;

namespace ScaduinoNET.ScaduinoWindows.Editors
{
    public partial class ProjectScreenEditor : FileEditor
    {
        public ProjectScreenEditor()
        {
            InitializeComponent();
            Extension = "scr";
        }

        override public void LoadFile()
        {
            screenEditor.Load(FilePath, ref screenEditor);
            screenEditor.Size = screenEditor.ScreenData.Properties.Size;
            Program.Scaduino.Forms.MainMDI.ChangeSelectedMainTab(3);
        }

        public override void SaveFile()
        {
            screenEditor.Save();
        }

        public override bool FileChanged()
        {
            return screenEditor.FileChanged();
        }

        private void ScreenEditor_MouseMove(object sender, MouseEventArgs e)
        {
            Program.Scaduino.Editor.CurrentScreenEditor = this.screenEditor;
            Cursor = Program.Scaduino.Editor.Cursor;
        }

        private void ScreenEditor_MouseClick(object sender, MouseEventArgs e)
        {
            if (Program.Scaduino.Editor.SelectedNewComponent != null && e.Button == MouseButtons.Left)
            {
                Control c = Program.Scaduino.Editor.CreateNewControl();
                c.Size = c.Size.Width == 0 || c.Size.Height == 0 ? new Size(100, 20) : c.Size;
                c.Location = e.Location;
                screenEditor.Controls.Add(c);
            }
            if(e.Button == MouseButtons.Right)
            {
                Program.Scaduino.Editor.SelectedNewComponent = null;
                Program.Scaduino.Editor.Cursor = Cursors.Default;
            }
        }
    }

}
