using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ScaduinoNET.ScaduinoWindows.Startup
{
    public partial class SocialMenu : UserControl
    {
        public SocialMenu()
        {
            InitializeComponent();
        }

        private void TileFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/BinaryQ");
        }

        private void TileYoutube_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCD_9Houq1JDvh39ulUtYcDg?view_as=subscriber");
        }

        private void TileGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/WesleyJoseSantos");
        }

        private void TileInstagram_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/binaryquantum/");
        }

        private void TileLinkedin_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/wesleyjsantos/");
        }

        private void TileWhatsapp_Click(object sender, EventArgs e)
        {
            Process.Start("https://api.whatsapp.com/send?1=pt_BR&phone=553799034766");
        }
    }
}
