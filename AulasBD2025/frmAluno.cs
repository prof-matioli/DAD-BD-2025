
using Microsoft.Data.SqlClient;
using System.Data;
using System.Runtime.ConstrainedExecution;
using static System.Net.WebRequestMethods;

namespace AulasBD2025
{
    public partial class frmAlunos : Form
    {
        private string stringConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AppData\MeuBanco.mdf;Integrated Security=True";

        public frmAlunos()
        {
            InitializeComponent();
            this.AcceptButton = btnInserir;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text; // Supondo que você tem um TextBox chamado txtNome
            int idade = Convert.ToInt32(txtIdade.Text); // Supondo que você tenha um textbox chamado txtIdade
            string curso = txtCurso.Text; // Supondo que você tenha um textbox chamado txtCurso

            // Comando SQL para inserir dados
            string sqlInsert = "INSERT INTO Alunos (Nome, Idade, Curso) VALUES(@Nome, @Idade, @Curso)";

            // Usando 'using' para garantir que a conexão e o comando sejam fechados corretamente
            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                using (SqlCommand comando = new SqlCommand(sqlInsert, conexao))
                {
                    // Adicionando parâmetros para evitar SQL Injection(MUITO IMPORTANTE!)
                    comando.Parameters.AddWithValue("@Nome",
                    nome);
                    comando.Parameters.AddWithValue("@Idade",
                    idade);
                    comando.Parameters.AddWithValue("@Curso",
                    curso);
                    try
                    {
                        conexao.Open(); // Abre a conexão com o banco
                        int linhasAfetadas =
                        comando.ExecuteNonQuery(); // Executa o comando
                        MessageBox.Show($"Aluno inserido com sucesso! Linhas afetadas: {linhasAfetadas}");
                        carregarGridView();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao inserir aluno: " + ex.Message);
                    }
                }
            }
        }

        private void carregaComSqlDataReader(object sender, EventArgs e)
        {
            string sqlSelect = "SELECT Id, Nome, Idade, Curso FROM Alunos";
            string resultados = "Alunos Cadastrados:\n\n";
            using (SqlConnection conexao = new
            SqlConnection(stringConexao))
            {
                using (SqlCommand comando = new
                SqlCommand(sqlSelect, conexao))
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
                                int id = reader.GetInt32(0); //Coluna 0(Id)
                                string nome = reader.GetString(1);          // Coluna 1 (Nome)
                                int idade = reader.GetInt32(2); // Coluna 2(Idade)
                                string curso = reader.IsDBNull(3) ? "N/A" : reader.GetString(3); // Coluna 3 (Curso), verifica se é                                 nulo
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

        private void carregaComSqlDataAdapter(object sender, EventArgs e)
        {
            carregarGridView();
        }

        // Suponha que você tem um DataGridView chamado dgvAlunos
        private void carregarGridView()
        {
            string sqlSelect = "SELECT Id, Nome, Idade, Curso FROM Alunos";
            using (SqlConnection conexao = new
            SqlConnection(stringConexao))
            {
                // SqlDataAdapter preenche o DataTable
                using (SqlDataAdapter adapter = new
                SqlDataAdapter(sqlSelect, conexao))
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

        private void frmAlunos_Load(object sender, EventArgs e)
        {
            carregarGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carregarGridView();
        }

        private void btnAtualizarAluno_Click(object sender, EventArgs e)
        {
            frmAtualizaAluno fAtualizaAluno = new frmAtualizaAluno();
            fAtualizaAluno.ShowDialog();
            carregarGridView();
        }
    }
}
