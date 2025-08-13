namespace AulasBD2025
{
    partial class frmAtualizaAluno
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtID = new TextBox();
            txtNovoNome = new TextBox();
            txtNovaIdade = new TextBox();
            btnAtualizarAluno = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(27, 15);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 0;
            label1.Text = "ID do Aluno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(27, 57);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 0;
            label2.Text = "Novo Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(27, 102);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 0;
            label3.Text = "Nova Idade:";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 14F);
            txtID.Location = new Point(168, 8);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 32);
            txtID.TabIndex = 1;
            // 
            // txtNovoNome
            // 
            txtNovoNome.Font = new Font("Segoe UI", 14F);
            txtNovoNome.Location = new Point(168, 50);
            txtNovoNome.Name = "txtNovoNome";
            txtNovoNome.Size = new Size(429, 32);
            txtNovoNome.TabIndex = 1;
            // 
            // txtNovaIdade
            // 
            txtNovaIdade.Font = new Font("Segoe UI", 14F);
            txtNovaIdade.Location = new Point(168, 95);
            txtNovaIdade.Name = "txtNovaIdade";
            txtNovaIdade.Size = new Size(100, 32);
            txtNovaIdade.TabIndex = 1;
            // 
            // btnAtualizarAluno
            // 
            btnAtualizarAluno.Font = new Font("Segoe UI", 14F);
            btnAtualizarAluno.Location = new Point(141, 152);
            btnAtualizarAluno.Name = "btnAtualizarAluno";
            btnAtualizarAluno.Size = new Size(248, 48);
            btnAtualizarAluno.TabIndex = 2;
            btnAtualizarAluno.Text = "Atualizar Aluno";
            btnAtualizarAluno.UseVisualStyleBackColor = true;
            btnAtualizarAluno.Click += btnAtualizarAluno_Click;
            // 
            // frmAtualizaAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 209);
            Controls.Add(btnAtualizarAluno);
            Controls.Add(txtNovaIdade);
            Controls.Add(txtNovoNome);
            Controls.Add(txtID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAtualizaAluno";
            Text = "frmAtualizaAluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtID;
        private TextBox txtNovoNome;
        private TextBox txtNovaIdade;
        private Button btnAtualizarAluno;
    }
}