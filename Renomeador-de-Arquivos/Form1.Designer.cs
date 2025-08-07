namespace Renomeador_de_Arquivos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAtualizarNomes = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelecionarArquivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAtualizarNomes
            // 
            this.btnAtualizarNomes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtualizarNomes.Location = new System.Drawing.Point(500, 260);
            this.btnAtualizarNomes.Name = "btnAtualizarNomes";
            this.btnAtualizarNomes.Size = new System.Drawing.Size(86, 26);
            this.btnAtualizarNomes.TabIndex = 2;
            this.btnAtualizarNomes.Text = "Atualizar";
            this.btnAtualizarNomes.UseVisualStyleBackColor = false;
            this.btnAtualizarNomes.Click += new System.EventHandler(this.btnAtualizarNomes_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(12, 119);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(574, 20);
            this.textBoxPath.TabIndex = 1;
            // 
            // labelUpdate
            // 
            this.labelUpdate.Location = new System.Drawing.Point(194, 171);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(200, 17);
            this.labelUpdate.TabIndex = 0;
            this.labelUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(7, 32);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(434, 25);
            this.Titulo.TabIndex = 3;
            this.Titulo.Text = "Selecione um destino para alterar os nomes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TODOS os arquivos serão renomeados nesta pasta:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(-2, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(601, 36);
            this.label2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Alt rapida pasta portal AT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(12, 145);
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(136, 23);
            this.btnSelecionarArquivo.TabIndex = 8;
            this.btnSelecionarArquivo.Text = "Selecionar pasta";
            this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 289);
            this.Controls.Add(this.btnSelecionarArquivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.btnAtualizarNomes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizador de Nomes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizarNomes;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSelecionarArquivo;
    }
}

