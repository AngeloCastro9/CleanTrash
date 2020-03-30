using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CleanTrash
{
    public partial class FormCleanTrash : Form
    {
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
                    deleteManager dm = new deleteManager();
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

                    foreach (var extension in extensions)
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
            if (cbBak.Checked || cbFbk.Checked || cbFdb.Checked)
            {
                progressBar.Visible = true;
                clean();
            }
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
