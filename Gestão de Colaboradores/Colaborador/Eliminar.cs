
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestaoColaboradores.Colaborador
{
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            //Validação do NIF                 
            if (nif.Text == "" || nif.Text.Length != 9)
            {
                MessageBox.Show("Preencha o NIF");
                nif.BackColor = Color.Red;
            }
            else
            {
                //Regra de Validação do NIF
                if (nif.Text.Substring(0, 8) != "0")
                {
                    MessageBox.Show("NIF inválido!");
                    nif.BackColor = Color.Red;
                }
                else
                {
                    SqlConnection conexaoBD = new(@"Data Source=WP-01-NBK-02654; Initial Catalog=Colaboradores;
                                                   Integrated Security=True");

                    try
                    {
                        conexaoBD.Open();

                        //Verificando o dado NIF existe na BD
                        SqlCommand SqlSelect = new()
                        {
                            Connection = conexaoBD,
                            CommandText = "SELECT * FROM Colaboradores WHERE NIF = " + nif.Text
                        };
                        
                        SqlDataReader reader = SqlSelect.ExecuteReader();
                        if (reader.RecordsAffected == 0)
                        {
                            MessageBox.Show("NIF INVÁLIDO!");
                        }
                        else
                        {
                            //Mostar os Dados no DataGrid
                            using (SqlDataAdapter dados = new(SqlSelect.CommandText, conexaoBD))
                            {
                                using (DataTable dLook = new())
                                {
                                    dados.Fill(dLook);
                                    listaColaboradores.DataSource = dLook;
                                }
                            }
                        }
                    }
                    catch (SqlException ex)
                    {

                        MessageBox.Show(ex.Message, "Erro ao conectar a Base de Dados", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexaoBD.Close();
                    }
                }
            }         
        }


        private void Excluir_Click(object sender, EventArgs e)
        {

            SqlConnection conexaoBD = new(@"Data Source=WP-01-NBK-02654; Initial Catalog=Colaboradores;
                                                   Integrated Security=True");
            
            //Verifica se existe dados no listaColaboradores
            if (listaColaboradores.HasChildren)
            {
                MessageBox.Show("Insira o NIF");
            }
            else
            {
                try
                {
                    DialogResult dialogDelete = MessageBox.Show("Deseja excluir o Colaborador?", "Excluir",
                            MessageBoxButtons.YesNo);

                    if (dialogDelete == DialogResult.Yes)
                    {
                        //Deletando os dados da tabela Colaboradores
                        SqlCommand SqlDelete = new()
                        {
                            Connection = conexaoBD,
                            CommandText = "DELETE FROM Colaboradores WHERE NIF = " + nif.Text
                        };

                        SqlDataReader recordDelete = SqlDelete.ExecuteReader();
                        if (recordDelete.RecordsAffected != 0)
                        {
                            MessageBox.Show("Colaborador Excluído!");
                        }
                    }

                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK,
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
