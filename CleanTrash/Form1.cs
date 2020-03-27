using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CleanTrash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clean()
        {
            deleteManager dm = new deleteManager();
            if (folderPath.Text != "")
            {
                if (cbBak.Checked || cbFbk.Checked || cbFdb.Checked)
                {
                    List<string> extensions = new List<string>();

                    if (cbBak.Checked)
                        extensions.Add("*.txt");
                    if (cbFbk.Checked)
                        extensions.Add("*.bmp");
                    if (cbFdb.Checked)
                        extensions.Add("*.rar");

                    foreach(var extension in extensions)
                    {
                        dm.delete(extension, folderPath.Text, progressBar);
                    }
                }
                else
                {
                    MessageBox.Show("Select a extension");
                }
            }
            else
            {
                MessageBox.Show("Invalid path");
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            folderPath.Text = dialog.SelectedPath;
        }
    }
}
