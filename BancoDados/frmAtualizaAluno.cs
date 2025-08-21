using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BancoDados
{
    public partial class frmAtualizaAluno : Form
    {
        private string stringConexao = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Matioli\TDS2\BancoDados\APPDATA\MeuBanco.mdf;Integrated Security=True";
        public frmAtualizaAluno()
        {
            InitializeComponent();
        }

        private void btnAtualizarAluno_Click(object sender, EventArgs e)
        {

            int idAluno = Convert.ToInt32(txtId.Text); // ID do aluno a ser atualizado
            string novoNome = txtNome.Text;
            int novaIdade = Convert.ToInt32(txtIdade.Text);
            string sqlUpdate = "UPDATE Alunos SET Nome = @NovoNome, Idade = @NovaIdade WHERE Id = @IdAluno"; 
            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                using (SqlCommand comando = new SqlCommand(sqlUpdate, conexao))
                {
                    comando.Parameters.AddWithValue("@NovoNome", novoNome);
                    comando.Parameters.AddWithValue("@NovaIdade", novaIdade);
                    comando.Parameters.AddWithValue("@IdAluno", idAluno);
                    try
                    {
                        conexao.Open();
                        int linhasAfetadas = comando.ExecuteNonQuery();
                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show($"Aluno com ID {idAluno} atualizado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show($"Nenhum aluno encontrado com ID {idAluno}.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao atualizar aluno: " + ex.Message);
                    }
                    finally
                    {
                        this.Close(); // Fecha o formulário após a atualização
                    }
                }
            }
        }
    }
}
