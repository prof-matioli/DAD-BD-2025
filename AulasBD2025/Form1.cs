
using Microsoft.Data.SqlClient;

namespace AulasBD2025
{
    public partial class frmAlunos : Form
    {
        private string stringConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Aulas\DAD\AulasBD2025\AulasBD2025\AppData\MeuBanco.mdf;Integrated Security=True";

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
                        MessageBox.Show($"Aluno inserido com sucesso! Linhas afetadas: { linhasAfetadas}");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao inserir aluno: " + ex.Message);
                    }
                }
            }
        }
    }
}
