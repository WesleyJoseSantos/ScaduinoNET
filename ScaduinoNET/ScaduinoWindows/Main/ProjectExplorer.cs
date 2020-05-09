using System;
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
                new ProjectTagsEditor(),
                new ProjectCommunicationEditor()
            };
        }

        private void ToolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            Explorer.UpdateExplorer();
        }
    }
}
