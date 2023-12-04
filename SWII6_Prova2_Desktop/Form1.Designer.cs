namespace SWII6_Prova2_Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Nome = new Label();
            textNome = new TextBox();
            textSenha = new TextBox();
            label1 = new Label();
            radioAtivo = new RadioButton();
            radioInativo = new RadioButton();
            label2 = new Label();
            buttonAdicionar = new Button();
            buttonEditar = new Button();
            buttonExcluir = new Button();
            buttonAtualizarListagem = new Button();
            buttonLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(337, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(452, 294);
            dataGridView1.TabIndex = 0;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(41, 111);
            Nome.Name = "Nome";
            Nome.Size = new Size(43, 15);
            Nome.TabIndex = 1;
            Nome.Text = "Nome:";
            // 
            // textNome
            // 
            textNome.Location = new Point(41, 131);
            textNome.Name = "textNome";
            textNome.Size = new Size(210, 23);
            textNome.TabIndex = 2;
            // 
            // textSenha
            // 
            textSenha.Location = new Point(41, 192);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(210, 23);
            textSenha.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 172);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Senha:";
            // 
            // radioAtivo
            // 
            radioAtivo.AutoSize = true;
            radioAtivo.Location = new Point(50, 266);
            radioAtivo.Name = "radioAtivo";
            radioAtivo.Size = new Size(53, 19);
            radioAtivo.TabIndex = 5;
            radioAtivo.TabStop = true;
            radioAtivo.Text = "Ativo";
            radioAtivo.UseVisualStyleBackColor = true;
            // 
            // radioInativo
            // 
            radioInativo.AutoSize = true;
            radioInativo.Location = new Point(119, 266);
            radioInativo.Name = "radioInativo";
            radioInativo.Size = new Size(61, 19);
            radioInativo.TabIndex = 6;
            radioInativo.TabStop = true;
            radioInativo.Text = "Inativo";
            radioInativo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 237);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 7;
            label2.Text = "Status:";
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Location = new Point(176, 316);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(75, 23);
            buttonAdicionar.TabIndex = 8;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(574, 55);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 9;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(493, 55);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(75, 23);
            buttonExcluir.TabIndex = 10;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonAtualizarListagem
            // 
            buttonAtualizarListagem.Location = new Point(655, 55);
            buttonAtualizarListagem.Name = "buttonAtualizarListagem";
            buttonAtualizarListagem.Size = new Size(134, 23);
            buttonAtualizarListagem.TabIndex = 11;
            buttonAtualizarListagem.Text = "Atualizar Listagem";
            buttonAtualizarListagem.UseVisualStyleBackColor = true;
            buttonAtualizarListagem.Click += buttonAtualizarListagem_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Location = new Point(84, 316);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(75, 23);
            buttonLimpar.TabIndex = 12;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 390);
            Controls.Add(buttonLimpar);
            Controls.Add(buttonAtualizarListagem);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonEditar);
            Controls.Add(buttonAdicionar);
            Controls.Add(label2);
            Controls.Add(radioInativo);
            Controls.Add(radioAtivo);
            Controls.Add(textSenha);
            Controls.Add(label1);
            Controls.Add(textNome);
            Controls.Add(Nome);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label Nome;
        private TextBox textNome;
        private TextBox textSenha;
        private Label label1;
        private RadioButton radioAtivo;
        private RadioButton radioInativo;
        private Label label2;
        private Button buttonAdicionar;
        private Button buttonEditar;
        private Button buttonExcluir;
        private Button buttonAtualizarListagem;
        private Button buttonLimpar;
    }
}