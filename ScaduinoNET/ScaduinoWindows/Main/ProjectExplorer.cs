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
using ScaduinoNET.ScaduinoWindows.Editors;

namespace ScaduinoNET.ScaduinoWindows.Main
{
    public partial class ProjectExplorer : UserControl
    {
        public ProjectExplorer()
        {
            InitializeComponent();

            Explorer.FileEditors = new FileEditor[] {
                new ProjectPropertiesEditor(),
                new ProjectScreenEditor(),
                new ProjectCodeEditor(),
            };
        }

        private void ToolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            Explorer.UpdateExplorer();
        }
    }
}
