namespace ScaduinoNET.ScaduinoWindows.Main
{
    partial class Console
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
            this.TabPageConsole = new VisualStudioTabControl.VisualStudioTabControl();
            this.TabPageOutput = new System.Windows.Forms.TabPage();
            this.TabPageMonitor = new System.Windows.Forms.TabPage();
            this.TabPageConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPageConsole
            // 
            this.TabPageConsole.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.TabPageConsole.AllowDrop = true;
            this.TabPageConsole.BackTabColor = System.Drawing.Color.White;
            this.TabPageConsole.BorderColor = System.Drawing.Color.Black;
            this.TabPageConsole.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
            this.TabPageConsole.ClosingMessage = null;
            this.TabPageConsole.Controls.Add(this.TabPageOutput);
            this.TabPageConsole.Controls.Add(this.TabPageMonitor);
            this.TabPageConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPageConsole.HeaderColor = System.Drawing.Color.White;
            this.TabPageConsole.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.TabPageConsole.ItemSize = new System.Drawing.Size(240, 16);
            this.TabPageConsole.Location = new System.Drawing.Point(0, 0);
            this.TabPageConsole.Name = "TabPageConsole";
            this.TabPageConsole.SelectedIndex = 0;
            this.TabPageConsole.SelectedTextColor = System.Drawing.Color.White;
            this.TabPageConsole.ShowClosingButton = false;
            this.TabPageConsole.ShowClosingMessage = false;
            this.TabPageConsole.Size = new System.Drawing.Size(820, 166);
            this.TabPageConsole.TabIndex = 0;
            this.TabPageConsole.TextColor = System.Drawing.Color.Black;
            // 
            // TabPageOutput
            // 
            this.TabPageOutput.BackColor = System.Drawing.Color.White;
            this.TabPageOutput.Location = new System.Drawing.Point(4, 20);
            this.TabPageOutput.Name = "TabPageOutput";
            this.TabPageOutput.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageOutput.Size = new System.Drawing.Size(812, 142);
            this.TabPageOutput.TabIndex = 0;
            this.TabPageOutput.Text = "Output";
            // 
            // TabPageMonitor
            // 
            this.TabPageMonitor.BackColor = System.Drawing.Color.White;
            this.TabPageMonitor.Location = new System.Drawing.Point(4, 20);
            this.TabPageMonitor.Name = "TabPageMonitor";
            this.TabPageMonitor.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageMonitor.Size = new System.Drawing.Size(812, 142);
            this.TabPageMonitor.TabIndex = 1;
            this.TabPageMonitor.Text = "Monitor";
            // 
            // Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabPageConsole);
            this.Name = "Console";
            this.Size = new System.Drawing.Size(820, 166);
            this.TabPageConsole.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private VisualStudioTabControl.VisualStudioTabControl TabPageConsole;
        private System.Windows.Forms.TabPage TabPageOutput;
        private System.Windows.Forms.TabPage TabPageMonitor;
    }
}
