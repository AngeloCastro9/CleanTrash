using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CleanTrash
{
    class deleteManager
    {
        public void delete(List<string> extensions, string folderPath, ProgressBar pBar)
        {
            pBar.Visible = true;
            pBar.Minimum = 0;

            foreach (var extension in extensions)
            {
                var files = new DirectoryInfo(folderPath).GetFiles(extension, SearchOption.AllDirectories);

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
        public void delete(string fileName, string folderPath, ProgressBar pBar)
        {
            pBar.Visible = true;
            pBar.Minimum = 0;


            var files = new DirectoryInfo(folderPath).GetFiles(fileName, SearchOption.AllDirectories);

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