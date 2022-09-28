namespace Projeto_Form_em_OOP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button buttonSair;
            this.labeltiTulo = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listBoxMensagem = new System.Windows.Forms.ListBox();
            this.ButtonFinalizar = new System.Windows.Forms.Button();
            buttonSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labeltiTulo
            // 
            this.labeltiTulo.AutoSize = true;
            this.labeltiTulo.Font = new System.Drawing.Font("Eras Demi ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltiTulo.Location = new System.Drawing.Point(140, 32);
            this.labeltiTulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltiTulo.Name = "labeltiTulo";
            this.labeltiTulo.Size = new System.Drawing.Size(281, 36);
            this.labeltiTulo.TabIndex = 0;
            this.labeltiTulo.Text = "Sistema de Dados";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(48, 116);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(143, 19);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome Completo:";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPF.Location = new System.Drawing.Point(48, 175);
            this.labelCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(45, 19);
            this.labelCPF.TabIndex = 2;
            this.labelCPF.Text = "CPF:";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereco.Location = new System.Drawing.Point(48, 232);
            this.labelEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(90, 19);
            this.labelEndereco.TabIndex = 3;
            this.labelEndereco.Text = "Endereço:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 117);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 174);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(146, 231);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(365, 20);
            this.textBox3.TabIndex = 6;
            // 
            // listBoxMensagem
            // 
            this.listBoxMensagem.FormattingEnabled = true;
            this.listBoxMensagem.ItemHeight = 14;
            this.listBoxMensagem.Location = new System.Drawing.Point(77, 335);
            this.listBoxMensagem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxMensagem.Name = "listBoxMensagem";
            this.listBoxMensagem.Size = new System.Drawing.Size(398, 88);
            this.listBoxMensagem.TabIndex = 7;
            // 
            // ButtonFinalizar
            // 
            this.ButtonFinalizar.BackColor = System.Drawing.Color.Green;
            this.ButtonFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonFinalizar.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFinalizar.Location = new System.Drawing.Point(199, 274);
            this.ButtonFinalizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonFinalizar.Name = "ButtonFinalizar";
            this.ButtonFinalizar.Size = new System.Drawing.Size(148, 43);
            this.ButtonFinalizar.TabIndex = 8;
            this.ButtonFinalizar.Text = "FINALIZAR";
            this.ButtonFinalizar.UseVisualStyleBackColor = false;
            this.ButtonFinalizar.Click += new System.EventHandler(this.ButtonFinalizar_Click);
            // 
            // buttonSair
            // 
            buttonSair.BackColor = System.Drawing.Color.Red;
            buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            buttonSair.Font = new System.Drawing.Font("Eras Bold ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonSair.Location = new System.Drawing.Point(450, 458);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new System.Drawing.Size(75, 31);
            buttonSair.TabIndex = 9;
            buttonSair.Text = "SAIR";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(563, 513);
            this.Controls.Add(buttonSair);
            this.Controls.Add(this.ButtonFinalizar);
            this.Controls.Add(this.listBoxMensagem);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labeltiTulo);
            this.Font = new System.Drawing.Font("Eras Demi ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltiTulo;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox listBoxMensagem;
        private System.Windows.Forms.Button ButtonFinalizar;
    }
}

