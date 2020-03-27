using System;
using System.IO;
using System.Windows.Forms;

namespace CleanTrash
{
    class deleteManager
    {
        public void delete(string extension, string folderPath)
        {
            var pastaOrigem = folderPath;
            var arquivos = new DirectoryInfo(pastaOrigem).GetFiles(extension, SearchOption.AllDirectories);
            foreach (var arquivo in arquivos)
            {
                var nomeArquivo = Path.GetFullPath(arquivo.FullName);
                try
                {
                    File.Delete(nomeArquivo);

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}
