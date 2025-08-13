namespace AulasBD2025
{
    partial class frmAlunos
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
            lblNome = new Label();
            lblIdade = new Label();
            lblCurso = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            txtCurso = new TextBox();
            btnInserir = new Button();
            btnCarregaGrid = new Button();
            dgvAlunos = new DataGridView();
            button1 = new Button();
            btnAtualizarAluno = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 14F);
            lblNome.Location = new Point(12, 19);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(67, 25);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Font = new Font("Segoe UI", 14F);
            lblIdade.Location = new Point(12, 69);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(63, 25);
            lblIdade.TabIndex = 0;
            lblIdade.Text = "Idade:";
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Font = new Font("Segoe UI", 14F);
            lblCurso.Location = new Point(12, 110);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(65, 25);
            lblCurso.TabIndex = 0;
            lblCurso.Text = "Curso:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14F);
            txtNome.Location = new Point(115, 16);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(474, 32);
            txtNome.TabIndex = 0;
            // 
            // txtIdade
            // 
            txtIdade.Font = new Font("Segoe UI", 14F);
            txtIdade.Location = new Point(115, 62);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(68, 32);
            txtIdade.TabIndex = 1;
            // 
            // txtCurso
            // 
            txtCurso.Font = new Font("Segoe UI", 14F);
            txtCurso.Location = new Point(115, 107);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(474, 32);
            txtCurso.TabIndex = 2;
            // 
            // btnInserir
            // 
            btnInserir.Font = new Font("Segoe UI", 14F);
            btnInserir.Location = new Point(12, 420);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(147, 44);
            btnInserir.TabIndex = 3;
            btnInserir.Text = "Inserir Aluno";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnCarregaGrid
            // 
            btnCarregaGrid.Font = new Font("Segoe UI", 14F);
            btnCarregaGrid.Location = new Point(638, 167);
            btnCarregaGrid.Name = "btnCarregaGrid";
            btnCarregaGrid.Size = new Size(340, 44);
            btnCarregaGrid.TabIndex = 3;
            btnCarregaGrid.Text = "Carregar usando SQLDataReader";
            btnCarregaGrid.UseVisualStyleBackColor = true;
            btnCarregaGrid.Click += carregaComSqlDataReader;
            // 
            // dgvAlunos
            // 
            dgvAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlunos.Location = new Point(20, 167);
            dgvAlunos.Name = "dgvAlunos";
            dgvAlunos.Size = new Size(569, 235);
            dgvAlunos.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(638, 217);
            button1.Name = "button1";
            button1.Size = new Size(340, 44);
            button1.TabIndex = 3;
            button1.Text = "Atualizar lista de Alunos (Gridview)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAtualizarAluno
            // 
            btnAtualizarAluno.Font = new Font("Segoe UI", 14F);
            btnAtualizarAluno.Location = new Point(185, 420);
            btnAtualizarAluno.Name = "btnAtualizarAluno";
            btnAtualizarAluno.Size = new Size(182, 44);
            btnAtualizarAluno.TabIndex = 3;
            btnAtualizarAluno.Text = "Atualizar Aluno";
            btnAtualizarAluno.UseVisualStyleBackColor = true;
            btnAtualizarAluno.Click += btnAtualizarAluno_Click;
            // 
            // frmAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 476);
            Controls.Add(dgvAlunos);
            Controls.Add(button1);
            Controls.Add(btnCarregaGrid);
            Controls.Add(btnAtualizarAluno);
            Controls.Add(btnInserir);
            Controls.Add(txtCurso);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(lblCurso);
            Controls.Add(lblIdade);
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
        private Label lblIdade;
        private Label lblCurso;
        private TextBox txtNome;
        private TextBox txtIdade;
        private TextBox txtCurso;
        private Button btnInserir;
        private Button btnCarregaGrid;
        private DataGridView dgvAlunos;
        private Button button1;
        private Button btnAtualizarAluno;
    }
}
