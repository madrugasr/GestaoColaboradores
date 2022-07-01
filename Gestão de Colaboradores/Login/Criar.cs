using System.Data.SqlClient;

namespace Gestão_de_Colaboradores
{
    public partial class Criar : Form
    {
        public Criar()
        {
            InitializeComponent();
        }

        private void CriarRegistro_Click(object sender, EventArgs e)
        {

            
            //Validação de Senhas Repetidas
            if (password.Text != repeatPassword.Text)
            {
                MessageBox.Show("Senhas não Coincidem!", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            //Validação dos dados Nulos
            else if (email.Text == "" || password.Text == "")
            {
                MessageBox.Show("Preencha todos os Campos", "Erro" , MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            else
            {

                //Conectar a Base de Dados
                SqlConnection conexaoBD = new("Data Source=WP-01-NBK-02654; Initial Catalog=Colaboradores; " +
                    "Integrated Security= True;");

                //Manipulação
                try
                {
                    conexaoBD.Open();

                    //Verifica se não há dados repetidos na Base de Dados.
                    SqlCommand SqlConsult = new()
                    {
                        Connection = conexaoBD,
                        CommandText = "SELECT * FROM Login WHERE email = '" + email.Text + "'"
                    };


                    SqlDataReader recordReader = SqlConsult.ExecuteReader();

                    if (recordReader.HasRows)
                    {
                        MessageBox.Show("Registro Existente!", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);                       
                    }
                    else
                    {    
                        recordReader.Close();
                        SqlCommand SqlInsert = new()
                        {
                            Connection = conexaoBD,

                            CommandText = "INSERT INTO Login (email, password) " +
                            "VALUES ('" + email.Text + "', '" + password.Text + "')"
                        };

                        //Executar o Statement
                        SqlInsert.ExecuteNonQuery();

                        MessageBox.Show("Registro Criado!");
                        this.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Erro SQL", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    conexaoBD.Close();
                }
            }
        }
    }
}
