namespace ScaduinoNET.ScaduinoWindows.Main
{
    partial class MainMDI
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
            this.TableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.mainToolBar = new ScaduinoNET.ScaduinoWindows.Main.MainToolBar();
            this.ContainerMain = new System.Windows.Forms.SplitContainer();
            this.projectExplorer = new ScaduinoNET.ScaduinoWindows.Main.ProjectExplorer();
            this.ContainerWorkspace = new System.Windows.Forms.SplitContainer();
            this.mainWorkspace = new ScaduinoNET.ScaduinoWindows.Main.Workspace();
            this.console1 = new ScaduinoNET.ScaduinoWindows.Main.Console();
            this.TableLayoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerMain)).BeginInit();
            this.ContainerMain.Panel1.SuspendLayout();
            this.ContainerMain.Panel2.SuspendLayout();
            this.ContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerWorkspace)).BeginInit();
            this.ContainerWorkspace.Panel1.SuspendLayout();
            this.ContainerWorkspace.Panel2.SuspendLayout();
            this.ContainerWorkspace.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutMain
            // 
            this.TableLayoutMain.ColumnCount = 1;
            this.TableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutMain.Controls.Add(this.mainToolBar, 0, 0);
            this.TableLayoutMain.Controls.Add(this.ContainerMain, 0, 1);
            this.TableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutMain.Location = new System.Drawing.Point(20, 60);
            this.TableLayoutMain.Name = "TableLayoutMain";
            this.TableLayoutMain.RowCount = 3;
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutMain.Size = new System.Drawing.Size(1326, 688);
            this.TableLayoutMain.TabIndex = 1;
            // 
            // mainToolBar
            // 
            this.mainToolBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainToolBar.Location = new System.Drawing.Point(3, 3);
            this.mainToolBar.Name = "mainToolBar";
            this.mainToolBar.Size = new System.Drawing.Size(1320, 126);
            this.mainToolBar.TabIndex = 0;
            // 
            // ContainerMain
            // 
            this.ContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerMain.Location = new System.Drawing.Point(3, 135);
            this.ContainerMain.Name = "ContainerMain";
            // 
            // ContainerMain.Panel1
            // 
            this.ContainerMain.Panel1.Controls.Add(this.projectExplorer);
            // 
            // ContainerMain.Panel2
            // 
            this.ContainerMain.Panel2.Controls.Add(this.ContainerWorkspace);
            this.ContainerMain.Panel2MinSize = 80;
            this.ContainerMain.Size = new System.Drawing.Size(1320, 530);
            this.ContainerMain.SplitterDistance = 190;
            this.ContainerMain.TabIndex = 1;
            // 
            // projectExplorer
            // 
            this.projectExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectExplorer.Location = new System.Drawing.Point(0, 0);
            this.projectExplorer.Name = "projectExplorer";
            this.projectExplorer.Size = new System.Drawing.Size(190, 530);
            this.projectExplorer.TabIndex = 1;
            // 
            // ContainerWorkspace
            // 
            this.ContainerWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerWorkspace.Location = new System.Drawing.Point(0, 0);
            this.ContainerWorkspace.Name = "ContainerWorkspace";
            this.ContainerWorkspace.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ContainerWorkspace.Panel1
            // 
            this.ContainerWorkspace.Panel1.Controls.Add(this.mainWorkspace);
            // 
            // ContainerWorkspace.Panel2
            // 
            this.ContainerWorkspace.Panel2.Controls.Add(this.console1);
            this.ContainerWorkspace.Size = new System.Drawing.Size(1126, 530);
            this.ContainerWorkspace.SplitterDistance = 380;
            this.ContainerWorkspace.TabIndex = 0;
            // 
            // mainWorkspace
            // 
            this.mainWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainWorkspace.Location = new System.Drawing.Point(0, 0);
            this.mainWorkspace.Name = "mainWorkspace";
            this.mainWorkspace.Size = new System.Drawing.Size(1126, 380);
            this.mainWorkspace.TabIndex = 0;
            // 
            // console1
            // 
            this.console1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.console1.Location = new System.Drawing.Point(0, 0);
            this.console1.Name = "console1";
            this.console1.Size = new System.Drawing.Size(1126, 146);
            this.console1.TabIndex = 0;
            // 
            // MainMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.TableLayoutMain);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "MainMDI";
            this.Text = "Scaduino";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMDI_FormClosing);
            this.Load += new System.EventHandler(this.MainMDI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMDI_KeyDown);
            this.TableLayoutMain.ResumeLayout(false);
            this.ContainerMain.Panel1.ResumeLayout(false);
            this.ContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContainerMain)).EndInit();
            this.ContainerMain.ResumeLayout(false);
            this.ContainerWorkspace.Panel1.ResumeLayout(false);
            this.ContainerWorkspace.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContainerWorkspace)).EndInit();
            this.ContainerWorkspace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutMain;
        private System.Windows.Forms.SplitContainer ContainerMain;
        private System.Windows.Forms.SplitContainer ContainerWorkspace;
        private Console console1;
        internal MainToolBar mainToolBar;
        internal ProjectExplorer projectExplorer;
        internal Workspace mainWorkspace;
    }
}