
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;

namespace BancoDados
{
    public partial class frmAlunos : Form
    {
        private string stringConexao = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Matioli\TDS2\BancoDados\APPDATA\MeuBanco.mdf;Integrated Security=True";

        public frmAlunos()
        {
            InitializeComponent();
            this.AcceptButton = btnInserir;
        }

        // Suponha que você tem um DataGridView chamado dgvAlunos
        private void CarregarAlunosNoDataGridView()
        {
            string sqlSelect = "SELECT Id, Nome, Idade, Curso FROM Alunos";
            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                // SqlDataAdapter preenche o DataTable
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, conexao))
                {
                    DataTable dtAlunos = new DataTable(); // Cria um DataTable vazio
                    try
                    {
                        conexao.Open();
                        adapter.Fill(dtAlunos); // Preenche o DataTable com os dados do banco
                        dgvAlunos.DataSource = dtAlunos; // Define o DataTable como fonte de dados do DataGridView
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao carregar alunos: " + ex.Message);
                    }
                }
            }
        }



        private void btnInserir_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int idade = Convert.ToInt32(txtIdade.Text);
            string curso = txtCurso.Text;

            string sqlInsert = "INSERT INTO Alunos (Nome, Idade, Curso) VALUES (@Nome, @Idade, @Curso)";

            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                using (SqlCommand comando = new SqlCommand(sqlInsert, conexao))
                {
                    // Adicionando parâmetros para evitar SQL Injection (MUITO IMPORTANTE!)
                    comando.Parameters.AddWithValue("@Nome", nome);
                    comando.Parameters.AddWithValue("@Idade", idade);
                    comando.Parameters.AddWithValue("@Curso", curso);

                    try
                    {
                        conexao.Open(); // Abre a conexão com o banco
                        int linhasAfetadas = comando.ExecuteNonQuery();
                        MessageBox.Show($"Aluno inserido com sucesso! Linhas afetadas: {linhasAfetadas}");
                        CarregarAlunosNoDataGridView(); //atualiza datagridview
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao inserir aluno: " + ex.Message);
                    }
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string sqlSelect = "SELECT Id, Nome, Idade, Curso FROM Alunos";
            string resultados = "Alunos Cadastrados:\n\n";
            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                using (SqlCommand comando = new SqlCommand(sqlSelect, conexao))
                {
                    try
                    {
                        conexao.Open();
                        // ExecuteReader() retorna um SqlDataReader
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Loop enquanto houver linhas para ler
                            while (reader.Read())
                            {
                                // Acessa os dados pelas colunas
                                int id = reader.GetInt32(0); // Coluna 0 (Id)
                                string nome = reader.GetString(1); // Coluna 1 (Nome)
                                int idade = reader.GetInt32(2); // Coluna 2 (Idade)
                                string curso = reader.IsDBNull(3) ? "N/A" : reader.GetString(3); // Coluna 3 (Curso), verifica se é nulo
                                resultados += $"ID: {id}, Nome: {nome}, Idade: {idade}, Curso: {curso}\n";
                            }
                        }
                        MessageBox.Show(resultados);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao consultar alunos: " + ex.Message);
                    }
                }
            }
        }

        private void frmAlunos_Load(object sender, EventArgs e)
        {
            CarregarAlunosNoDataGridView();
        }

        private void dgvAlunos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgvAlunos.CurrentRow;
            if (currentRow != null)
            {
                int rowIndex = currentRow.Index;
                // Faça algo com a linha atual, como acessar seus valores
                object cellNome = currentRow.Cells["nome"].Value;
                object cellIdade = currentRow.Cells["idade"].Value;
                object cellCurso = currentRow.Cells["curso"].Value;
                if (cellNome != null)
                {
                    txtNome.Text = cellNome.ToString();
                }
                if (cellIdade != null)
                {
                    txtIdade.Text = cellIdade.ToString();
                }
                if (cellCurso != null)
                {
                    txtCurso.Text = cellCurso.ToString();
                }
            }
        }

        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {
            frmAtualizaAluno atualizaAlunoForm = new frmAtualizaAluno();
            atualizaAlunoForm.ShowDialog(); // Abre o formulário de atualização como modal
            CarregarAlunosNoDataGridView(); // Recarrega os dados após a atualização
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgvAlunos.SelectedRows[0];
            if (currentRow.Cells.Count > 0 && currentRow.Cells[0].Value != null)
            {
                Int32 idAluno = Convert.ToInt32(currentRow.Cells[0].Value.ToString());
                string sqlDelete = "DELETE FROM Alunos WHERE Id = @IdAluno";
                using (SqlConnection conexao = new SqlConnection(stringConexao))
                {
                    using (SqlCommand comando = new SqlCommand(sqlDelete, conexao))
                    {
                        comando.Parameters.AddWithValue("@IdAluno", idAluno);
                        try
                        {
                            conexao.Open();

                            int linhasAfetadas = comando.ExecuteNonQuery();
                            if (linhasAfetadas > 0)
                            {
                                MessageBox.Show($"Aluno com ID {idAluno} excluído com sucesso!");
                                // Opcional: recarregar o DataGridView
                                CarregarAlunosNoDataGridView();
                            }
                            else
                            {
                                MessageBox.Show($"Nenhum aluno encontrado com ID {idAluno}.");
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Erro ao excluir aluno: " + ex.Message);
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("A célula da coluna zero da linha selecionada não tem um valor ou não existe.", "Erro",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}