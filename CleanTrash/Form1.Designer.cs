namespace CleanTrash
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
            this.btnClean = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderPath = new System.Windows.Forms.TextBox();
            this.cbBak = new System.Windows.Forms.CheckBox();
            this.cbFdb = new System.Windows.Forms.CheckBox();
            this.cbFbk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(197, 231);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 0;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(431, 48);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(47, 23);
            this.btnOpenFolder.TabIndex = 1;
            this.btnOpenFolder.Text = "...";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path:";
            // 
            // folderPath
            // 
            this.folderPath.Location = new System.Drawing.Point(12, 48);
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(413, 20);
            this.folderPath.TabIndex = 3;
            // 
            // cbBak
            // 
            this.cbBak.AutoSize = true;
            this.cbBak.Location = new System.Drawing.Point(16, 132);
            this.cbBak.Name = "cbBak";
            this.cbBak.Size = new System.Drawing.Size(47, 17);
            this.cbBak.TabIndex = 4;
            this.cbBak.Text = ".bak";
            this.cbBak.UseVisualStyleBackColor = true;
            // 
            // cbFdb
            // 
            this.cbFdb.AutoSize = true;
            this.cbFdb.Location = new System.Drawing.Point(16, 155);
            this.cbFdb.Name = "cbFdb";
            this.cbFdb.Size = new System.Drawing.Size(44, 17);
            this.cbFdb.TabIndex = 5;
            this.cbFdb.Text = ".fdb";
            this.cbFdb.UseVisualStyleBackColor = true;
            // 
            // cbFbk
            // 
            this.cbFbk.AutoSize = true;
            this.cbFbk.Location = new System.Drawing.Point(16, 178);
            this.cbFbk.Name = "cbFbk";
            this.cbFbk.Size = new System.Drawing.Size(44, 17);
            this.cbFbk.TabIndex = 6;
            this.cbFbk.Text = ".fbk";
            this.cbFbk.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 272);
            this.Controls.Add(this.cbFbk);
            this.Controls.Add(this.cbFdb);
            this.Controls.Add(this.cbBak);
            this.Controls.Add(this.folderPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnClean);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.CheckBox cbBak;
        private System.Windows.Forms.CheckBox cbFdb;
        private System.Windows.Forms.CheckBox cbFbk;
    }
}

