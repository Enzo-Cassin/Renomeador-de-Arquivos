using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Renomeador_de_Arquivos
{
    static class Renomeador
    {
        public static List<String> Renomear(string path)
        {
            var files = Directory.EnumerateFiles(path, "*.*", SearchOption.TopDirectoryOnly);
            var naoRenomeados = new List<string>();
            foreach (string file in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(file);
                string extension = Path.GetExtension(file);

                string newFileName = RemoveAccents(fileName);
                newFileName = Regex.Replace(newFileName, @"\s+|[.,;°ºª_]", "-");
                newFileName = Regex.Replace(newFileName, "-{2,}", "-").Trim('-');
                newFileName += extension;

                string newPath = Path.Combine(path, newFileName);

                if (!file.Equals(newPath, StringComparison.OrdinalIgnoreCase) && !File.Exists(newPath))
                {
                    File.Move(file, newPath);
                }
                else if (!file.Equals(newPath, StringComparison.OrdinalIgnoreCase))
                {
                    naoRenomeados.Add(Path.GetFileName(file));
                }
            }
            Console.WriteLine("Todos os arquivos foram alterados.");
            return naoRenomeados;
        }

        private static string RemoveAccents(string text)
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
