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

namespace ScaduinoNET.ScaduinoWindows.Editors
{
    public partial class ProjectCommunicationEditor : FileEditor
    {
        public ProjectCommunicationEditor()
        {
            InitializeComponent();
            Extensions = new string[] {"cnt"};
        }

        public override void LoadFile()
        {
            base.LoadFile();
        }

        public override void SaveFile()
        {
            base.SaveFile();
        }

        public override bool FileChanged()
        {
            return (true);
        }
    }
}
