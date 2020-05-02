namespace ScaduinoNET
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.screenEditor1 = new ScreenEditor.ScreenEditor();
            this.button1 = new System.Windows.Forms.Button();
            this.btAddComponent = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.screenEditor1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(383, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // screenEditor1
            // 
            this.screenEditor1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.screenEditor1.Controls.Add(this.button1);
            this.screenEditor1.Location = new System.Drawing.Point(242, 41);
            this.screenEditor1.Name = "screenEditor1";
            this.screenEditor1.Size = new System.Drawing.Size(288, 397);
            this.screenEditor1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btAddComponent
            // 
            this.btAddComponent.Location = new System.Drawing.Point(38, 11);
            this.btAddComponent.Name = "btAddComponent";
            this.btAddComponent.Size = new System.Drawing.Size(75, 23);
            this.btAddComponent.TabIndex = 4;
            this.btAddComponent.Text = "Add";
            this.btAddComponent.UseVisualStyleBackColor = true;
            this.btAddComponent.Click += new System.EventHandler(this.BtAddComponent_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(119, 11);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "save";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(14, 41);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(213, 20);
            this.tbName.TabIndex = 6;
            // 
            // componentsExplorer1
            // 
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btAddComponent);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.screenEditor1);
            this.Controls.Add(this.button2);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.screenEditor1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScreenEditor.ScreenEditor screenEditor1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btAddComponent;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbName;
    }
}

