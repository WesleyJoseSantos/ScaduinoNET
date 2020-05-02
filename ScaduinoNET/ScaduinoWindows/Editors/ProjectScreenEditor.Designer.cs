namespace ScaduinoNET.ScaduinoWindows.Editors
{
    partial class ProjectScreenEditor
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
            this.screenEditor = new ScreenEditor.ScreenEditor();
            this.SuspendLayout();
            // 
            // screenEditor
            // 
            this.screenEditor.BackColor = System.Drawing.Color.White;
            this.screenEditor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.screenEditor.Location = new System.Drawing.Point(3, 3);
            this.screenEditor.Name = "screenEditor";
            this.screenEditor.Size = new System.Drawing.Size(398, 338);
            this.screenEditor.TabIndex = 0;
            this.screenEditor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ScreenEditor_MouseClick);
            this.screenEditor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenEditor_MouseMove);
            // 
            // ProjectScreenEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.screenEditor);
            this.Name = "ProjectScreenEditor";
            this.Size = new System.Drawing.Size(404, 344);
            this.ResumeLayout(false);

        }

        #endregion

        private ScreenEditor.ScreenEditor screenEditor;
    }
}
