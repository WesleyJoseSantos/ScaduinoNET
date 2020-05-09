using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using System.IO;
using CommonControls;

namespace ScaduinoNET.ScaduinoWindows.Editors
{
    public partial class ProjectCodeEditor : FileEditor
    {
        private readonly string[] extensions =
        {
            "cs",
            "vb",
            "html",
            "xml",
            "sql",
            "php",
            "js",
            "lua",
            "json"
        };

        public ProjectCodeEditor()
        {
            InitializeComponent();
            Extensions = extensions;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }


        override public void LoadFile()
        {
            base.LoadFile();
            fctb.OpenFile(FilePath);
            CheckCodeLanguage();
        }

        public override void SaveFile()
        {
            fctb.SaveToFile(FilePath, Encoding.UTF8);
        }

        public override bool FileChanged()
        {
            return (fctb.Text != File.ReadAllText(FilePath));
        }

        private void CheckCodeLanguage()
        {
            FileInfo fileInfo = new FileInfo(FilePath);
            string extension = fileInfo.Extension.Remove(0,1);

            fctb.Language = (Language)(extensions.ToList().IndexOf(extension)+1);

            fctb.SyntaxHighlighter.HighlightSyntax(fctb.Language, fctb.Range);
        }
    }
}
