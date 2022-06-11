namespace WindowsFormsApp1
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
            this.button_inserir = new System.Windows.Forms.Button();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.button_alterar = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.button_contar = new System.Windows.Forms.Button();
            this.textBox_sobrenome = new System.Windows.Forms.TextBox();
            this.button_listar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_contaPessoas = new System.Windows.Forms.Label();
            this.textBox_lista = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_inserir
            // 
            this.button_inserir.Location = new System.Drawing.Point(12, 38);
            this.button_inserir.Name = "button_inserir";
            this.button_inserir.Size = new System.Drawing.Size(107, 20);
            this.button_inserir.TabIndex = 0;
            this.button_inserir.Text = "Inserir Pessoa";
            this.button_inserir.UseVisualStyleBackColor = true;
            this.button_inserir.Click += new System.EventHandler(this.button_inserir_Click);
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(12, 12);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(193, 20);
            this.textBox_nome.TabIndex = 2;
            this.textBox_nome.Text = "Digite o nome aqui";
            // 
            // button_alterar
            // 
            this.button_alterar.Location = new System.Drawing.Point(125, 38);
            this.button_alterar.Name = "button_alterar";
            this.button_alterar.Size = new System.Drawing.Size(107, 20);
            this.button_alterar.TabIndex = 3;
            this.button_alterar.Text = "Alterar Sobrenome";
            this.button_alterar.UseVisualStyleBackColor = true;
            this.button_alterar.Click += new System.EventHandler(this.button_alterar_Click);
            // 
            // button_deletar
            // 
            this.button_deletar.Location = new System.Drawing.Point(238, 38);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(107, 20);
            this.button_deletar.TabIndex = 4;
            this.button_deletar.Text = "Deletar Pessoa";
            this.button_deletar.UseVisualStyleBackColor = true;
            this.button_deletar.Click += new System.EventHandler(this.button_deletar_Click);
            // 
            // button_contar
            // 
            this.button_contar.Location = new System.Drawing.Point(12, 77);
            this.button_contar.Name = "button_contar";
            this.button_contar.Size = new System.Drawing.Size(107, 20);
            this.button_contar.TabIndex = 5;
            this.button_contar.Text = "Contar Pessoas";
            this.button_contar.UseVisualStyleBackColor = true;
            this.button_contar.Click += new System.EventHandler(this.button_contar_Click);
            // 
            // textBox_sobrenome
            // 
            this.textBox_sobrenome.Location = new System.Drawing.Point(211, 12);
            this.textBox_sobrenome.Name = "textBox_sobrenome";
            this.textBox_sobrenome.Size = new System.Drawing.Size(292, 20);
            this.textBox_sobrenome.TabIndex = 6;
            this.textBox_sobrenome.Text = "Digite o sobrenome aqui";
            // 
            // button_listar
            // 
            this.button_listar.Location = new System.Drawing.Point(12, 187);
            this.button_listar.Name = "button_listar";
            this.button_listar.Size = new System.Drawing.Size(107, 20);
            this.button_listar.TabIndex = 13;
            this.button_listar.Text = "Listar Pessoas";
            this.button_listar.UseVisualStyleBackColor = true;
            this.button_listar.Click += new System.EventHandler(this.button_listar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Número de Pessoas Cadastradas: ";
            // 
            // label_contaPessoas
            // 
            this.label_contaPessoas.AutoSize = true;
            this.label_contaPessoas.Location = new System.Drawing.Point(177, 61);
            this.label_contaPessoas.Name = "label_contaPessoas";
            this.label_contaPessoas.Size = new System.Drawing.Size(69, 13);
            this.label_contaPessoas.TabIndex = 15;
            this.label_contaPessoas.Text = "Não contado";
            // 
            // textBox_lista
            // 
            this.textBox_lista.Location = new System.Drawing.Point(12, 103);
            this.textBox_lista.Multiline = true;
            this.textBox_lista.Name = "textBox_lista";
            this.textBox_lista.ReadOnly = true;
            this.textBox_lista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_lista.Size = new System.Drawing.Size(491, 78);
            this.textBox_lista.TabIndex = 16;
            this.textBox_lista.Text = "Lista de pessoas cadastradas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 223);
            this.Controls.Add(this.textBox_lista);
            this.Controls.Add(this.label_contaPessoas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_listar);
            this.Controls.Add(this.textBox_sobrenome);
            this.Controls.Add(this.button_contar);
            this.Controls.Add(this.button_deletar);
            this.Controls.Add(this.button_alterar);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.button_inserir);
            this.Name = "Form1";
            this.Text = "Gerenciamento de pessoas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_inserir;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Button button_alterar;
        private System.Windows.Forms.Button button_deletar;
        private System.Windows.Forms.Button button_contar;
        private System.Windows.Forms.TextBox textBox_sobrenome;
        private System.Windows.Forms.Button button_listar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_contaPessoas;
        private System.Windows.Forms.TextBox textBox_lista;
    }
}

