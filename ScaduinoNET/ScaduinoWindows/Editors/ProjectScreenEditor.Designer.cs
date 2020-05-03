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
            this.components = new System.ComponentModel.Container();
            ScreenEditor.DataBase.ScreenData screenData1 = new ScreenEditor.DataBase.ScreenData();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectScreenEditor));
            ScreenEditor.DataBase.ScreenPropreties screenPropreties1 = new ScreenEditor.DataBase.ScreenPropreties();
            this.screenEditor = new ScreenEditor.ScreenEditor();
            this.contextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // screenEditor
            // 
            this.screenEditor.BackColor = System.Drawing.Color.White;
            this.screenEditor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.screenEditor.ContextMenuStrip = this.contextMenu;
            this.screenEditor.Location = new System.Drawing.Point(3, 3);
            this.screenEditor.Name = "screenEditor";
            this.screenEditor.PointedControl = null;
            screenData1.Path = null;
            screenPropreties1.AccessibleDescription = null;
            screenPropreties1.BackColor = System.Drawing.SystemColors.Control;
            screenPropreties1.ForeColor = System.Drawing.SystemColors.ControlText;
            screenPropreties1.Name = "";
            screenPropreties1.Size = new System.Drawing.Size(200, 100);
            screenPropreties1.Type = "ScreenEditor.ScreenEditor";
            screenData1.Properties = screenPropreties1;
            this.screenEditor.ScreenData = screenData1;
            this.screenEditor.Size = new System.Drawing.Size(398, 338);
            this.screenEditor.TabIndex = 0;
            this.screenEditor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ScreenEditor_MouseClick);
            this.screenEditor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenEditor_MouseMove);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertiesToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(128, 26);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Image = global::ScaduinoNET.Properties.Resources.icons8_adicionar_propriedade_50;
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.PropertiesToolStripMenuItem_Click);
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
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ScreenEditor.ScreenEditor screenEditor;
        private MetroFramework.Controls.MetroContextMenu contextMenu;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
    }
}
