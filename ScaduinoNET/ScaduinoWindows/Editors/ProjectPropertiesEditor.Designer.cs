namespace ScaduinoNET.ScaduinoWindows.Editors
{
    partial class ProjectPropertiesEditor
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ComboBoxResolution = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxProjectName = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(132, 55);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(146, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Project Properties";
            // 
            // ComboBoxResolution
            // 
            this.ComboBoxResolution.FormattingEnabled = true;
            this.ComboBoxResolution.ItemHeight = 23;
            this.ComboBoxResolution.Items.AddRange(new object[] {
            "800x600",
            "1024x768",
            "1152x864",
            "1176x664",
            "1280x720",
            "1280x768",
            "1280x800",
            "1280x960",
            "1280x1024",
            "1360x768",
            "1366x768",
            "1600x900",
            "1600x1024",
            "1680x1050",
            "1768x992",
            "1920x1080",
            "2560x1080"});
            this.ComboBoxResolution.Location = new System.Drawing.Point(42, 207);
            this.ComboBoxResolution.Name = "ComboBoxResolution";
            this.ComboBoxResolution.Size = new System.Drawing.Size(331, 29);
            this.ComboBoxResolution.TabIndex = 13;
            this.ComboBoxResolution.UseSelectable = true;
            this.ComboBoxResolution.SelectedIndexChanged += new System.EventHandler(this.ComboBoxResolution_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(42, 183);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(115, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Screen Resolution:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(42, 114);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 19);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Project Name:";
            // 
            // TextBoxProjectName
            // 
            // 
            // 
            // 
            this.TextBoxProjectName.CustomButton.Image = null;
            this.TextBoxProjectName.CustomButton.Location = new System.Drawing.Point(309, 1);
            this.TextBoxProjectName.CustomButton.Name = "";
            this.TextBoxProjectName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxProjectName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxProjectName.CustomButton.TabIndex = 1;
            this.TextBoxProjectName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxProjectName.CustomButton.UseSelectable = true;
            this.TextBoxProjectName.CustomButton.Visible = false;
            this.TextBoxProjectName.Lines = new string[] {
        "NewProject"};
            this.TextBoxProjectName.Location = new System.Drawing.Point(42, 139);
            this.TextBoxProjectName.MaxLength = 32767;
            this.TextBoxProjectName.Name = "TextBoxProjectName";
            this.TextBoxProjectName.PasswordChar = '\0';
            this.TextBoxProjectName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxProjectName.SelectedText = "";
            this.TextBoxProjectName.SelectionLength = 0;
            this.TextBoxProjectName.SelectionStart = 0;
            this.TextBoxProjectName.ShortcutsEnabled = true;
            this.TextBoxProjectName.ShowClearButton = true;
            this.TextBoxProjectName.Size = new System.Drawing.Size(331, 23);
            this.TextBoxProjectName.TabIndex = 10;
            this.TextBoxProjectName.Text = "NewProject";
            this.TextBoxProjectName.UseSelectable = true;
            this.TextBoxProjectName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxProjectName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxProjectName.TextChanged += new System.EventHandler(this.TextBoxProjectName_TextChanged);
            // 
            // ProjectPropertiesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ComboBoxResolution);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.TextBoxProjectName);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ProjectPropertiesEditor";
            this.Size = new System.Drawing.Size(421, 311);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox ComboBoxResolution;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox TextBoxProjectName;
    }
}
