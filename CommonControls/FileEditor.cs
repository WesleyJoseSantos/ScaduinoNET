using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonControls
{
    public partial class FileEditor : UserControl
    {
        private List<string> extensions = new List<string>();
        private string filePath;

        public string[] Extensions { get => extensions.ToArray(); set => extensions = value.ToList(); }
        public string FilePath { get => filePath; set => filePath = value; }

        public FileEditor()
        {
            InitializeComponent();
        }

        virtual public void LoadFile()
        {

        }

        virtual public void SaveFile()
        {

        }

        virtual public bool FileChanged()
        {
            return (false);
        }
    }
}
