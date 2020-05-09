namespace ScaduinoNET.ScaduinoWindows.Main
{
    partial class ProjectExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectExplorer));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Explorer = new CommonControls.FilesExplorer();
            this.Icons = new System.Windows.Forms.ImageList(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ToolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.ToolSriptButtonNew = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonImport = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Explorer, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(255, 445);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButtonRefresh,
            this.ToolSriptButtonNew,
            this.ToolStripButtonImport,
            this.ToolStripButtonOpen});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(255, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(249, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Project Explorer";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // Explorer
            // 
            this.Explorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Explorer.FileEditors = new CommonControls.FileEditor[0];
            this.Explorer.HideEmptyFolders = false;
            this.Explorer.ImageIndex = 0;
            this.Explorer.ImageList = this.Icons;
            this.Explorer.Location = new System.Drawing.Point(3, 53);
            this.Explorer.Name = "Explorer";
            this.Explorer.Paths = new string[0];
            this.Explorer.PathsNames = new string[0];
            this.Explorer.SelectedImageIndex = 0;
            this.Explorer.Size = new System.Drawing.Size(249, 389);
            this.Explorer.TabIndex = 3;
            this.Explorer.WatchedPath = "";
            // 
            // Icons
            // 
            this.Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icons.ImageStream")));
            this.Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.Icons.Images.SetKeyName(0, "");
            this.Icons.Images.SetKeyName(1, "Screens");
            this.Icons.Images.SetKeyName(2, "Tags");
            this.Icons.Images.SetKeyName(3, "Communication");
            this.Icons.Images.SetKeyName(4, ".scproj");
            this.Icons.Images.SetKeyName(5, ".scr");
            this.Icons.Images.SetKeyName(6, ".script");
            this.Icons.Images.SetKeyName(7, ".xml");
            this.Icons.Images.SetKeyName(8, ".cs");
            this.Icons.Images.SetKeyName(9, ".js");
            this.Icons.Images.SetKeyName(10, ".json");
            this.Icons.Images.SetKeyName(11, ".sql");
            this.Icons.Images.SetKeyName(12, ".html");
            this.Icons.Images.SetKeyName(13, ".vb");
            this.Icons.Images.SetKeyName(14, ".tgs");
            this.Icons.Images.SetKeyName(15, ".cnt");
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // ToolStripButtonRefresh
            // 
            this.ToolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonRefresh.Image = global::ScaduinoNET.Properties.Resources.icons8_atualizações_disponíveis_50;
            this.ToolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonRefresh.Name = "ToolStripButtonRefresh";
            this.ToolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonRefresh.Text = "Refresh";
            this.ToolStripButtonRefresh.Click += new System.EventHandler(this.ToolStripButtonRefresh_Click);
            // 
            // ToolSriptButtonNew
            // 
            this.ToolSriptButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolSriptButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("ToolSriptButtonNew.Image")));
            this.ToolSriptButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolSriptButtonNew.Name = "ToolSriptButtonNew";
            this.ToolSriptButtonNew.Size = new System.Drawing.Size(23, 22);
            this.ToolSriptButtonNew.Text = "Add Item";
            // 
            // ToolStripButtonImport
            // 
            this.ToolStripButtonImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonImport.Image = global::ScaduinoNET.Properties.Resources.icons8_baixar_50;
            this.ToolStripButtonImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonImport.Name = "ToolStripButtonImport";
            this.ToolStripButtonImport.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonImport.Text = "Import Item";
            // 
            // ToolStripButtonOpen
            // 
            this.ToolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonOpen.Image")));
            this.ToolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonOpen.Name = "ToolStripButtonOpen";
            this.ToolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonOpen.Text = "Open Explorer";
            // 
            // ProjectExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProjectExplorer";
            this.Size = new System.Drawing.Size(255, 445);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.ToolStripButton ToolStripButtonRefresh;
        private System.Windows.Forms.ToolStripButton ToolSriptButtonNew;
        private System.Windows.Forms.ToolStripButton ToolStripButtonImport;
        private System.Windows.Forms.ToolStripButton ToolStripButtonOpen;
        internal CommonControls.FilesExplorer Explorer;
        private System.Windows.Forms.ImageList Icons;
    }
}
