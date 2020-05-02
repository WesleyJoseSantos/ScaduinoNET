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
using ScaduinoNET.DataBase;
using System.IO;

namespace ScaduinoNET.ScaduinoWindows.Editors
{
    public partial class ProjectPropertiesEditor : FileEditor
    {
        ScaduinoProjectProperties properties = new ScaduinoProjectProperties();

        public ProjectPropertiesEditor()
        {
            InitializeComponent();
            Extension = "cfg";
        }

        override public void LoadFile()
        {
            properties.FilePath = FilePath;
            properties.LoadProperties(FilePath);
            TextBoxProjectName.Text = properties.Name;
            string resolution = string.Format("{0}x{1}", properties.ScreenSize.Width, properties.ScreenSize.Height);
            ComboBoxResolution.SelectedItem = resolution;
        }

        public override void SaveFile()
        {
            properties.SaveProperties();
            Program.Scaduino.Project.Properties.LoadProperties(FilePath);
        }

        public override bool FileChanged()
        {
            return properties.FileChanged();
        }

        private void ComboBoxResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            properties.ScreenSize = new Size(
                int.Parse(ComboBoxResolution.SelectedItem.ToString().Split('x')[0]),
                int.Parse(ComboBoxResolution.SelectedItem.ToString().Split('x')[1])
            );
        }

        private void TextBoxProjectName_TextChanged(object sender, EventArgs e)
        {
            properties.Name = TextBoxProjectName.Text;
        }
    }
}
