using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renomeador_de_Arquivos
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void Renomeador(string path)
        {
            var files = Directory.EnumerateFiles(path, "*.*", SearchOption.TopDirectoryOnly);
            foreach (string file in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(file);
                string extension = Path.GetExtension(file);

                fileName = RemoveAccents(fileName);

                fileName = Regex.Replace(fileName, @"\s+|[.,;_]", "-");
                while (fileName.Contains("--"))
                {
                    fileName = Regex.Replace(fileName, @"--", "-");
                }

                fileName += Path.GetExtension(file);
                string newpath = path + @"\" + fileName;

                File.Move(file, newpath);
            }
            Console.WriteLine("Todos os arquivos foram alterados.");
        }

        static string RemoveAccents(string text)
        {
            StringBuilder sbReturn = new StringBuilder();
            var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();

            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }

            return sbReturn.ToString();
        }
    }
}
