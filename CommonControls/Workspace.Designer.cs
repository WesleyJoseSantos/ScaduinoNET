namespace ScaduinoNET.ScaduinoWindows.Main
{
    partial class Workspace
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
            this.TabPage = new VisualStudioTabControl.VisualStudioTabControl();
            this.SuspendLayout();
            // 
            // TabPage
            // 
            this.TabPage.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.TabPage.AllowDrop = true;
            this.TabPage.BackTabColor = System.Drawing.Color.White;
            this.TabPage.BorderColor = System.Drawing.Color.Black;
            this.TabPage.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
            this.TabPage.ClosingMessage = null;
            this.TabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPage.HeaderColor = System.Drawing.Color.White;
            this.TabPage.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.TabPage.ItemSize = new System.Drawing.Size(240, 16);
            this.TabPage.Location = new System.Drawing.Point(0, 0);
            this.TabPage.Name = "TabPage";
            this.TabPage.SelectedIndex = 0;
            this.TabPage.SelectedTextColor = System.Drawing.Color.White;
            this.TabPage.ShowClosingButton = true;
            this.TabPage.ShowClosingMessage = false;
            this.TabPage.Size = new System.Drawing.Size(603, 468);
            this.TabPage.TabIndex = 1;
            this.TabPage.TextColor = System.Drawing.Color.Black;
            this.TabPage.CloseButtonClicked += new System.EventHandler<VisualStudioTabControl.CloseButtonClickedEventArgs>(this.TabPage_CloseButtonClicked);
            // 
            // Workspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabPage);
            this.Name = "Workspace";
            this.Size = new System.Drawing.Size(603, 468);
            this.ResumeLayout(false);

        }

        #endregion

        private VisualStudioTabControl.VisualStudioTabControl TabPage;
    }
}
