using System;
using System.IO;
using System.Windows.Forms;

namespace CleanTrash
{
    class deleteManager
    {
        public void delete(string extension, string folderPath, ProgressBar pBar)
        {
            var files = new DirectoryInfo(folderPath).GetFiles(extension, SearchOption.AllDirectories);
            pBar.Visible = true;
            pBar.Minimum = 0;
            pBar.Maximum = files.Length;
            pBar.Step = 1;

            if (files.Length == 0)
                MessageBox.Show("All clean!");
            foreach (var file in files)
            {
                try
                {
                    File.Delete(Path.GetFullPath(file.FullName));
                    if (pBar.Value != files.Length)
                        pBar.Value++;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}
