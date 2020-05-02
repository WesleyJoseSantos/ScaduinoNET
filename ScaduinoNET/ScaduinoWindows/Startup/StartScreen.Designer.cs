namespace ScaduinoNET.ScaduinoWindows.Startup
{
    partial class StartScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TileNew = new MetroFramework.Controls.MetroTile();
            this.TileNewFromTemplate = new MetroFramework.Controls.MetroTile();
            this.TileOpen = new MetroFramework.Controls.MetroTile();
            this.TileExit = new MetroFramework.Controls.MetroTile();
            this.socialMenu1 = new ScaduinoNET.ScaduinoWindows.Startup.SocialMenu();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(54, 78);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(97, 25);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Get Started";
            // 
            // TileNew
            // 
            this.TileNew.ActiveControl = null;
            this.TileNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TileNew.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TileNew.Location = new System.Drawing.Point(52, 129);
            this.TileNew.Name = "TileNew";
            this.TileNew.Size = new System.Drawing.Size(277, 52);
            this.TileNew.TabIndex = 1;
            this.TileNew.Text = "New Empty Project";
            this.TileNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileNew.TileImage = global::ScaduinoNET.Properties.Resources.icons8_novo_arquivo_50;
            this.TileNew.UseCustomBackColor = true;
            this.TileNew.UseCustomForeColor = true;
            this.TileNew.UseSelectable = true;
            this.TileNew.UseTileImage = true;
            this.TileNew.Click += new System.EventHandler(this.TileNew_Click);
            // 
            // TileNewFromTemplate
            // 
            this.TileNewFromTemplate.ActiveControl = null;
            this.TileNewFromTemplate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TileNewFromTemplate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TileNewFromTemplate.Location = new System.Drawing.Point(52, 187);
            this.TileNewFromTemplate.Name = "TileNewFromTemplate";
            this.TileNewFromTemplate.Size = new System.Drawing.Size(277, 52);
            this.TileNewFromTemplate.TabIndex = 2;
            this.TileNewFromTemplate.Text = "New From Template";
            this.TileNewFromTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileNewFromTemplate.TileImage = global::ScaduinoNET.Properties.Resources.icons8_novo_modelo_de_currículo_50;
            this.TileNewFromTemplate.UseCustomBackColor = true;
            this.TileNewFromTemplate.UseCustomForeColor = true;
            this.TileNewFromTemplate.UseSelectable = true;
            this.TileNewFromTemplate.UseTileImage = true;
            this.TileNewFromTemplate.Click += new System.EventHandler(this.TileNewFromTemplate_Click);
            // 
            // TileOpen
            // 
            this.TileOpen.ActiveControl = null;
            this.TileOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TileOpen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TileOpen.Location = new System.Drawing.Point(52, 245);
            this.TileOpen.Name = "TileOpen";
            this.TileOpen.Size = new System.Drawing.Size(277, 52);
            this.TileOpen.TabIndex = 3;
            this.TileOpen.Text = "Open Existing Project";
            this.TileOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileOpen.TileImage = global::ScaduinoNET.Properties.Resources.icons8_abrir_pasta_50;
            this.TileOpen.UseCustomBackColor = true;
            this.TileOpen.UseCustomForeColor = true;
            this.TileOpen.UseSelectable = true;
            this.TileOpen.UseTileImage = true;
            this.TileOpen.Click += new System.EventHandler(this.TileOpen_Click);
            // 
            // TileExit
            // 
            this.TileExit.ActiveControl = null;
            this.TileExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TileExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TileExit.Location = new System.Drawing.Point(52, 303);
            this.TileExit.Name = "TileExit";
            this.TileExit.Size = new System.Drawing.Size(277, 52);
            this.TileExit.TabIndex = 4;
            this.TileExit.Text = "Exit Application";
            this.TileExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileExit.TileImage = global::ScaduinoNET.Properties.Resources.icons8_desligar_501;
            this.TileExit.UseCustomBackColor = true;
            this.TileExit.UseCustomForeColor = true;
            this.TileExit.UseSelectable = true;
            this.TileExit.UseTileImage = true;
            this.TileExit.Click += new System.EventHandler(this.TileExit_Click);
            // 
            // socialMenu1
            // 
            this.socialMenu1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.socialMenu1.Location = new System.Drawing.Point(22, 382);
            this.socialMenu1.Name = "socialMenu1";
            this.socialMenu1.Size = new System.Drawing.Size(337, 55);
            this.socialMenu1.TabIndex = 5;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 460);
            this.ControlBox = false;
            this.Controls.Add(this.socialMenu1);
            this.Controls.Add(this.TileExit);
            this.Controls.Add(this.TileOpen);
            this.Controls.Add(this.TileNewFromTemplate);
            this.Controls.Add(this.TileNew);
            this.Controls.Add(this.metroLabel2);
            this.Name = "StartScreen";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = "Welcome To Scaduino!";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile TileNew;
        private MetroFramework.Controls.MetroTile TileNewFromTemplate;
        private MetroFramework.Controls.MetroTile TileOpen;
        private MetroFramework.Controls.MetroTile TileExit;
        private SocialMenu socialMenu1;
    }
}