using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Fonts;
using MetroFramework.Forms;
using ScreenEditor.DataBase;

namespace ScaduinoNET.ScaduinoWindows.PoupUps
{
    public partial class PropertiesEditor : MetroForm
    {
        private Control control;
        private ControlData controlData;
        
        public Control ControlToEdit { get => control; set => control = value; }
        
        public PropertiesEditor()
        {
            InitializeComponent();
        }

        private void PropertiesEditor_Load(object sender, EventArgs e)
        {
            controlData = new ControlData(control);

            TextBoxText.Text = controlData.Properties.Text;
            TextBoxDescription.Text = controlData.Properties.AccessibleDescription;
            TextBoxTag.Text = controlData.Properties.Tag == null ? "" : controlData.Properties.Tag.Name;

            TextBoxWidth.Text = controlData.Properties.Size.Width.ToString();
            TextBoxHeight.Text = controlData.Properties.Size.Height.ToString();

            TextBoxLocationX.Text = controlData.Properties.Location.X.ToString();
            TextBoxLocationY.Text = controlData.Properties.Location.Y.ToString();

            TileBackColor.BackColor = controlData.Properties.BackColor;
            TileBackColor.ForeColor = controlData.Properties.ForeColor;

            TileForeColor.BackColor = controlData.Properties.ForeColor;
            TileForeColor.ForeColor = controlData.Properties.BackColor;

            TileForeColor.Text = controlData.Properties.ForeColor.ToString();
            TileBackColor.Text = controlData.Properties.BackColor.ToString();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            //controlData.Properties.Tag = 

            controlData.Properties.Text = TextBoxText.Text;
            controlData.Properties.AccessibleDescription = TextBoxDescription.Text;
            TextBoxTag.Text = controlData.Properties.Tag == null ? "" : controlData.Properties.Tag.Name;

            controlData.Properties.Size = new Size(
                int.Parse(TextBoxWidth.Text),
                int.Parse(TextBoxHeight.Text)
            );

            controlData.Properties.Location = new Point(
                int.Parse(TextBoxLocationX.Text),
                int.Parse(TextBoxLocationY.Text)
            );

            controlData.Properties.BackColor = TileBackColor.BackColor;
            controlData.Properties.ForeColor = TileForeColor.BackColor;

            controlData.Properties.To(ref control);
            Close();
        }

        private void ButtonCalcel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TileBackColor_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog()
            {
                AllowFullOpen = true,
                AnyColor = true,
                FullOpen = true,
                Color = TileBackColor.BackColor
            };
            var result = colorDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                TileBackColor.BackColor = colorDialog.Color;
                TileBackColor.Text = colorDialog.Color.ToString();
                TileForeColor.ForeColor = TileBackColor.BackColor;
            }
        }

        private void TileForeColor_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog()
            {
                AllowFullOpen = true,
                AnyColor = true,
                FullOpen = true,
                Color = TileForeColor.BackColor
            };
            var result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                TileForeColor.BackColor = colorDialog.Color;
                TileForeColor.Text = colorDialog.Color.ToString();
                TileBackColor.ForeColor = TileForeColor.BackColor;
            }
        }
    }
}
