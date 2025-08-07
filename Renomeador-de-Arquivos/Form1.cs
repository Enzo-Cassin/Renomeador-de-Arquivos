using Ookii.Dialogs.WinForms;
using System;
using System.IO;
using System.Windows.Forms;


namespace Renomeador_de_Arquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAtualizarNomes_Click(object sender, EventArgs e)
        {
            labelUpdate.Text = "Aguarde um momento.";
            string path = textBoxPath.Text;

            if (Directory.Exists(path))
            {
                var naoRenomeados = Renomeador.Renomear(path);
                if (naoRenomeados.Count == 0)
                {
                    labelUpdate.Text = "Todos os arquivos foram renomeados.";
                }
                else
                {
                    labelUpdate.Text = "Alguns arquivos não foram renomeados:";
                    MessageBox.Show(
                        "Os seguintes arquivos não foram renomeados por poderem sobrescrever outro arquivo:\n\n" +
                        string.Join("\n", naoRenomeados),
                        "Arquivos não renomeados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            else
            {
                labelUpdate.Text = "Esse diretório não existe";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Renomeador.Renomear(@"C:\Users\est-enzo.cassin\OneDrive - Tribunal de Justica de Sao Paulo\Área de Trabalho\portal");
            labelUpdate.Text = "Todos os arquivos foram renomeados.";
        }

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            using (var dialog = new VistaFolderBrowserDialog())
            {
                dialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                dialog.Description = "Selecione a pasta";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxPath.Text = dialog.SelectedPath;
                }
            }
        }
    }
}
