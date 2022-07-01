using System.Data;
using System.Data.SqlClient;


namespace GestaoColaboradores.Lista_Colaboradores
{
    public partial class MapaColaboradores : Form
    {
        public MapaColaboradores()
        {
            InitializeComponent();
            ListarDadosColaboradores();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListarDadosColaboradores()
        {

            //Listando de todos os Colaboradores na Base de Dados

            //Conexão a BD
            SqlConnection conexaoBD = new(@"Data Source=WP-01-NBK-02654; Initial Catalog=Colaboradores;
                                                  Integrated Security=True");

            try
            {
                conexaoBD.Open();
                
                //Barra de Status
                status.Text = "Conectado!";
                statusStrip.Refresh();

                //Seleciona todos as tuplas da tabela Colaboradores
                SqlCommand SqlSelect = new()
                {
                    Connection = conexaoBD,
                    CommandText = "SELECT * FROM Colaboradores ORDER BY id_colaborador"
                };
                
                
                SqlDataReader reader = SqlSelect.ExecuteReader();
                if (reader.RecordsAffected == 0)
                {
                    status.Text = "Não existem Colaboradores!";
                    statusStrip.Refresh();
                }
                else
                {                    
                    reader.Close();
                    
                    //Mostar os Dados no DataGrid
                    using (SqlDataAdapter dados = new(SqlSelect.CommandText, conexaoBD))
                    {
                        using (DataTable dLook = new())
                        {
                            dados.Fill(dLook);
                            listaColab.DataSource = dLook;
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
