using System.Data.SqlClient;

namespace Gestão_de_Colaboradores
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            email.Text = "dom.marquees@gmail.com";
            password.Text = "4433";
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
                //Validação
            if (email.Text == "" || password.Text == "")
            {
                MessageBox.Show("Preencha todos os Campos!",
                  "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                //Conectando a BD
                SqlConnection conexaoBD = new("Data Source=WP-01-NBK-02654; Initial Catalog=Colaboradores; " +
                    "Integrated Security= True;");

                //Manipulação
                try
                {
                    conexaoBD.Open();

                    //Verifica se os dados inseridos estão no BD
                    SqlCommand SqlSelect = new()
                    {
                        Connection = conexaoBD,

                        //Statement de SQLs
                        CommandText = "SELECT * FROM Login " +
                        "WHERE email = '" + email.Text + "' " +
                        "AND password = '" + password.Text + "'"
                    };

                    //Leitura dos Dados e execução do Statement
                    SqlDataReader recordReader = SqlSelect.ExecuteReader();

                    //Verificar se existe algum registo no Banco de Dados
                    if (recordReader.HasRows)
                    {

                        //Abrir o formulário principal Dash
                        Dash dash = new()
                        {
                            LoginDash = email.Text
                        };
                        dash.ShowDialog();

                        //Fechar o formulário Login
                        //Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Email ou Password incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    
                    MessageBox.Show(ex.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexaoBD.Close();
                }
            }
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            Criar registro = new();
            registro.ShowDialog();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            Editar editar = new()
            {
                //editar.email.Text = email.Text;
                AcessoLogin = email.Text
            };
            editar.ShowDialog();
        }
    }
}
