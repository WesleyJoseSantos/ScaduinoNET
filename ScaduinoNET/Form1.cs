using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScaduinoNET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            screenEditor1.Save();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            screenEditor1.Load(Application.StartupPath + "\\screen.json", ref screenEditor1);
        }

        private void BtAddComponent_Click(object sender, EventArgs e)
        {
            
        }
    }
}
