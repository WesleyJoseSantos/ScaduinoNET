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
using ScreenEditor.DataBase;

namespace ScaduinoNET.ScaduinoWindows.PoupUps
{
    public partial class NewScreen : MetroForm
    {
        public NewScreen()
        {
            InitializeComponent();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void NewScreen_Load(object sender, EventArgs e)
        {
            TextBoxHeight.Text = Program.Scaduino.Project.Properties.ScreenSize.Height.ToString();
            TextBoxWidth.Text = Program.Scaduino.Project.Properties.ScreenSize.Width.ToString();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            var screenProperties = new ScreenPropreties()
            {
                Name = TextBoxName.Text,
                AccessibleDescription = TextBoxDescription.Text,
                Size = new Size(int.Parse(TextBoxWidth.Text), int.Parse(TextBoxHeight.Text))
            };

            var newScreen = new ScreenData()
            {
                Path = string.Format("{0}\\{1}.scr", Program.Scaduino.Project.Directories.Screens, TextBoxName.Text),
                Properties = screenProperties
            };

            newScreen.Save();
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
