using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CleanTrash
{
    public partial class FormCleanTrash : Form
    {
        deleteManager dm = new deleteManager();
        public FormCleanTrash()
        {
            InitializeComponent();
        }

        private void cbFileName_CheckStateChanged_1(object sender, EventArgs e)
        {
            tbFileName.Visible = (cbFileName.CheckState == CheckState.Checked);
            lbFileName.Visible = (cbFileName.CheckState == CheckState.Checked);
        }

        private void cleanByName()
        {
            if (folderPath.Text != "")
            {
                if (tbFileName.Text != "")
                {
                    string fileName = tbFileName.Text + "*.*";
                    dm.delete(fileName, folderPath.Text, progressBar);
                }
                else
                {
                    MessageBox.Show("Invalid file name");
                }
            }
            else
            {
                MessageBox.Show("Invalid path");
            }
        }

        private void clean()
        {
            List<string> extensions = new List<string>();
            if (folderPath.Text != "")
            {
                if (textBox1.Text != "")
                {
                    var newExtensions = textBox1.Text.Trim().Split(',');
                    foreach (var e in newExtensions)
                    {
                        extensions.Add($"*.{e}");
                    }
                }

                if (cbBak.Checked || cbFbk.Checked || cbFdb.Checked || textBox1.Text != "")
                {
                    if (cbBak.Checked)
                        extensions.Add("*.bak");
                    if (cbFbk.Checked)
                        extensions.Add("*.fbk");
                    if (cbFdb.Checked)
                        extensions.Add("*.fdb");

                    dm.delete(extensions, folderPath.Text, progressBar);
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
            progressBar.Visible = true;
            clean();
            if (cbFileName.Checked)
            {
                progressBar.Visible = true;
                cleanByName();
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            folderPath.Text = dialog.SelectedPath;
        }
    }
}
