using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScaduinoNET.ScaduinoWindows
{
    public class ScaduinoDialogs
    {
        public void NewProject()
        {
            var result = MessageBox.Show(
                "Do you want to close current project, and start a new project?",
                "New Project",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        public void OpenProject()
        {
            var openFileDialog = new OpenFileDialog()
            {
                //Filter = "Scaduino Project | .scproj",
                InitialDirectory = Program.Scaduino.Settings.History.RecentProjectsDirectory,
                CheckFileExists = true,
                CheckPathExists = true
            };
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Program.Scaduino.Project.Open(openFileDialog.FileName);
                Program.Scaduino.Forms.MainMDI.InitializeProject();
            }
        }
    }
}
