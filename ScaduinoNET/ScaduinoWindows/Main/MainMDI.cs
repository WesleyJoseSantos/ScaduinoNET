using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ScaduinoNET.DataBase;

namespace ScaduinoNET.ScaduinoWindows.Main
{
    public partial class MainMDI : MetroForm
    {

        public MainMDI()
        {
            InitializeComponent();
        }

        private void MainMDI_Load(object sender, EventArgs e)
        {
            Program.Scaduino.LoadData();
            ContainerMain.SplitterDistance = Program.Scaduino.Settings.Interface.ContainerMainSplitterDistance;
            ContainerWorkspace.SplitterDistance = Program.Scaduino.Settings.Interface.ContainerWorkspaceSplitterDistance;

            projectExplorer.Explorer.Paths = new string[]{ Program.Scaduino.Project.Properties.Path };
            projectExplorer.Explorer.WatchedPath = Program.Scaduino.Project.Properties.Path;
            projectExplorer.Explorer.SetWorkspace(ref mainWorkspace);
            projectExplorer.Explorer.UpdateExplorer();
        }

        private void MainMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Scaduino.Settings.Interface.ContainerMainSplitterDistance = ContainerMain.SplitterDistance;
            Program.Scaduino.Settings.Interface.ContainerWorkspaceSplitterDistance = ContainerWorkspace.SplitterDistance;
            Program.Scaduino.SaveData();
            Application.Exit();
        }

        public void ChangeSelectedMainTab(int tabIdx)
        {
            mainToolBar.TabControl.SelectedIndex = tabIdx;
        }

        private void MainMDI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Program.Scaduino.Editor.CurrentScreenEditor.DeleteSelectedControls();
            }
        }
    }
}
