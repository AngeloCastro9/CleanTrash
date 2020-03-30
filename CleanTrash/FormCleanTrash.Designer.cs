namespace CleanTrash
{
    partial class FormCleanTrash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCleanTrash));
            this.btnClean = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderPath = new System.Windows.Forms.TextBox();
            this.cbBak = new System.Windows.Forms.CheckBox();
            this.cbFdb = new System.Windows.Forms.CheckBox();
            this.cbFbk = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.cbFileName = new System.Windows.Forms.CheckBox();
            this.lbFileName = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(197, 271);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 0;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(435, 48);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(47, 20);
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
            this.cbBak.Location = new System.Drawing.Point(12, 95);
            this.cbBak.Name = "cbBak";
            this.cbBak.Size = new System.Drawing.Size(47, 17);
            this.cbBak.TabIndex = 4;
            this.cbBak.Text = ".bak";
            this.cbBak.UseVisualStyleBackColor = true;
            // 
            // cbFdb
            // 
            this.cbFdb.AutoSize = true;
            this.cbFdb.Location = new System.Drawing.Point(12, 118);
            this.cbFdb.Name = "cbFdb";
            this.cbFdb.Size = new System.Drawing.Size(44, 17);
            this.cbFdb.TabIndex = 5;
            this.cbFdb.Text = ".fdb";
            this.cbFdb.UseVisualStyleBackColor = true;
            // 
            // cbFbk
            // 
            this.cbFbk.AutoSize = true;
            this.cbFbk.Location = new System.Drawing.Point(12, 141);
            this.cbFbk.Name = "cbFbk";
            this.cbFbk.Size = new System.Drawing.Size(44, 17);
            this.cbFbk.TabIndex = 6;
            this.cbFbk.Text = ".fbk";
            this.cbFbk.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(16, 224);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(466, 23);
            this.progressBar.TabIndex = 7;
            this.progressBar.Visible = false;
            // 
            // cbFileName
            // 
            this.cbFileName.AutoSize = true;
            this.cbFileName.Location = new System.Drawing.Point(206, 95);
            this.cbFileName.Name = "cbFileName";
            this.cbFileName.Size = new System.Drawing.Size(239, 17);
            this.cbFileName.TabIndex = 8;
            this.cbFileName.Text = "If you need clean a file by name, check here.";
            this.cbFileName.UseVisualStyleBackColor = true;
            this.cbFileName.CheckStateChanged += new System.EventHandler(this.cbFileName_CheckStateChanged_1);
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Location = new System.Drawing.Point(203, 122);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(97, 13);
            this.lbFileName.TabIndex = 9;
            this.lbFileName.Text = "Input the file name:";
            this.lbFileName.Visible = false;
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(306, 119);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(149, 20);
            this.tbFileName.TabIndex = 10;
            this.tbFileName.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Aditional extensions: (Ex: rar, zip)";
            // 
            // FormCleanTrash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 308);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.lbFileName);
            this.Controls.Add(this.cbFileName);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.cbFbk);
            this.Controls.Add(this.cbFdb);
            this.Controls.Add(this.cbBak);
            this.Controls.Add(this.folderPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnClean);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCleanTrash";
            this.Text = "Clean Trash";
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
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox cbFileName;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

