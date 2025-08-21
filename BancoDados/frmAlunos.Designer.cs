namespace BancoDados
{
    partial class frmAlunos
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
            lblNome = new Label();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            txtCurso = new TextBox();
            btnInserir = new Button();
            btnConsultar = new Button();
            dgvAlunos = new DataGridView();
            btnAtualizarDados = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 14F);
            lblNome.Location = new Point(7, 11);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(67, 25);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(7, 58);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Idade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(7, 100);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 0;
            label2.Text = "Curso:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14F);
            txtNome.Location = new Point(83, 15);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(387, 32);
            txtNome.TabIndex = 0;
            // 
            // txtIdade
            // 
            txtIdade.Font = new Font("Segoe UI", 14F);
            txtIdade.Location = new Point(83, 55);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(65, 32);
            txtIdade.TabIndex = 1;
            // 
            // txtCurso
            // 
            txtCurso.Font = new Font("Segoe UI", 14F);
            txtCurso.Location = new Point(83, 93);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(387, 32);
            txtCurso.TabIndex = 2;
            // 
            // btnInserir
            // 
            btnInserir.Font = new Font("Segoe UI", 14F);
            btnInserir.Location = new Point(11, 396);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(92, 40);
            btnInserir.TabIndex = 3;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 14F);
            btnConsultar.Location = new Point(118, 396);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(115, 40);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dgvAlunos
            // 
            dgvAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlunos.Location = new Point(14, 142);
            dgvAlunos.Name = "dgvAlunos";
            dgvAlunos.ReadOnly = true;
            dgvAlunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlunos.Size = new Size(465, 248);
            dgvAlunos.TabIndex = 4;
            dgvAlunos.SelectionChanged += dgvAlunos_SelectionChanged;
            // 
            // btnAtualizarDados
            // 
            btnAtualizarDados.Font = new Font("Segoe UI", 14F);
            btnAtualizarDados.Location = new Point(239, 396);
            btnAtualizarDados.Name = "btnAtualizarDados";
            btnAtualizarDados.Size = new Size(115, 40);
            btnAtualizarDados.TabIndex = 3;
            btnAtualizarDados.Text = "Atualizar";
            btnAtualizarDados.UseVisualStyleBackColor = true;
            btnAtualizarDados.Click += btnAtualizarDados_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 14F);
            btnExcluir.Location = new Point(364, 396);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(115, 40);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // frmAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 448);
            Controls.Add(dgvAlunos);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizarDados);
            Controls.Add(btnConsultar);
            Controls.Add(btnInserir);
            Controls.Add(txtCurso);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNome);
            Name = "frmAlunos";
            Text = "Cadastro de Alunos";
            Load += frmAlunos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtIdade;
        private TextBox txtCurso;
        private Button btnInserir;
        private Button btnConsultar;
        private DataGridView dgvAlunos;
        private Button btnAtualizarDados;
        private Button btnExcluir;
    }
}