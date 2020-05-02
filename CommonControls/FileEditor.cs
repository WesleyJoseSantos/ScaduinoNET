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
        private string extension;
        private string filePath;

        public string Extension { get => extension; set => extension = value; }
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
