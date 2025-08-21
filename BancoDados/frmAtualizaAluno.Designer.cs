namespace BancoDados
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
            txtId = new TextBox();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            btnAtualizarAluno = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(13, 55);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 0;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(13, 100);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 0;
            label3.Text = "Idade:";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 14F);
            txtId.Location = new Point(100, 8);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 32);
            txtId.TabIndex = 3;
            txtId.TabStop = false;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14F);
            txtNome.Location = new Point(100, 56);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(453, 32);
            txtNome.TabIndex = 0;
            // 
            // txtIdade
            // 
            txtIdade.Font = new Font("Segoe UI", 14F);
            txtIdade.Location = new Point(100, 100);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 32);
            txtIdade.TabIndex = 1;
            // 
            // btnAtualizarAluno
            // 
            btnAtualizarAluno.Font = new Font("Segoe UI", 14F);
            btnAtualizarAluno.Location = new Point(351, 148);
            btnAtualizarAluno.Name = "btnAtualizarAluno";
            btnAtualizarAluno.Size = new Size(202, 43);
            btnAtualizarAluno.TabIndex = 2;
            btnAtualizarAluno.Text = "Atualizar Aluno";
            btnAtualizarAluno.UseVisualStyleBackColor = true;
            btnAtualizarAluno.Click += btnAtualizarAluno_Click;
            // 
            // frmAtualizaAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 212);
            Controls.Add(btnAtualizarAluno);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAtualizaAluno";
            Text = "Atualizar Aluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtIdade;
        private Button btnAtualizarAluno;
    }
}