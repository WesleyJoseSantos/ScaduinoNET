using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ScaduinoNET.ScaduinoWindows.PoupUps;

namespace ScaduinoNET.ScaduinoWindows.Startup
{
    public partial class StartScreen : MetroForm
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void TileNew_Click(object sender, EventArgs e)
        {
            new NewProject().Show();
            Close();
        }

        private void TileNewFromTemplate_Click(object sender, EventArgs e)
        {
            new FeatureUnavailable().ShowDialog();
            this.Focus();
        }

        private void TileOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = Program.Scaduino.Dialogs.OpenProject();
            if(result == DialogResult.OK)
            {
                Program.Scaduino.Forms.MainMDI.Show();
                Close();
            }
        }

        private void TileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TileSocialFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/BinaryQ");
        }

        private void TileSocialYouTube_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCD_9Houq1JDvh39ulUtYcDg");
        }

        private void TileSocialInstagram_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/binaryquantum/");
        }

        private void TileSocialLinkedin_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/wesleyjsantos/");
        }

        private void TileSocialWhatsApp_Click(object sender, EventArgs e)
        {
            Process.Start("https://api.whatsapp.com/send?1=pt_BR&phone=553799034766");
        }

    }
}
