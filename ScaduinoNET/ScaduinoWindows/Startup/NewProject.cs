using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ScaduinoNET.ScaduinoWindows.PoupUps;

namespace ScaduinoNET.ScaduinoWindows.Startup
{
    public partial class NewProject : MetroForm
    {
        public NewProject()
        {
            InitializeComponent();
        }

        private void TileNew_Click(object sender, EventArgs e)
        {
            new FeatureUnavailable().Show();
        }

        private void TileNewFromTemplate_Click(object sender, EventArgs e)
        {
            new FeatureUnavailable().Show();
        }

        private void TileOpen_Click(object sender, EventArgs e)
        {
            new FeatureUnavailable().Show();
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

        private void StartScreen_Load(object sender, EventArgs e)
        {
            TextBoxProjectPath.Text = Program.Scaduino.Settings.History.RecentProjectsDirectory;
            int resolutionX = Screen.PrimaryScreen.Bounds.Width;
            int resolutionY = Screen.PrimaryScreen.Bounds.Height;
            string resolution = resolutionX.ToString() + 'x' + resolutionY.ToString();
            ComboBoxResolution.SelectedItem = resolution;
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                SelectedPath = TextBoxProjectPath.Text,
                Description = "A new folder will be automatically created for you project.",
                ShowNewFolderButton = false
            };
            var result = folderBrowserDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                TextBoxProjectPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            try
            {
                Program.Scaduino.Project = new DataBase.ScaduinoProject(
                    TextBoxProjectName.Text,
                    TextBoxProjectPath.Text,
                    new Size(
                        int.Parse(ComboBoxResolution.SelectedItem.ToString().Split('x')[0]),
                        int.Parse(ComboBoxResolution.SelectedItem.ToString().Split('x')[1])));
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.InnerException.ToString(),
                    ex.Message,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                throw;
            }
            Program.Scaduino.Forms.MainMDI.Show();
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            new StartScreen().Show();
            Close();
        }
    }
}
