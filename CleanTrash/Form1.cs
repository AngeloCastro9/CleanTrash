using System;
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
                    if (cbBak.Checked)
                        dm.delete("*.txt", folderPath.Text);
                    if (cbFbk.Checked)
                        dm.delete("*.bmp", folderPath.Text);
                    if (cbFdb.Checked)
                        dm.delete("*.rar", folderPath.Text);
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
