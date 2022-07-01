using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoColaboradores.Arquivos
{
    public partial class SalvarArquivos : Form
    {
        public SalvarArquivos()
        {
            InitializeComponent();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            //Abrir Arquivo
            OpenFileDialog abrir = new();
            abrir.ShowDialog();
            caminho.Text = abrir.FileName;

        }
        
        private void SaveFile(string caminhoArquivo)
        {
            //Salvando Arquivo
            using (Stream stream = File.OpenRead(caminhoArquivo))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                string s = new FileInfo(caminhoArquivo).Extension;
            }
        }

        
        private void Salvar_Click(object sender, EventArgs e)
        {

            //SaveFile(caminho.Text);
            

            
            //Conexão a BD
            SqlConnection conexaoBD = new(@"Data Source=WP-01-NBK-02654; Initial Catalog=Colaboradores;
                                                  Integrated Security=True");

            try
            {
                conexaoBD.Open();


                SqlCommand SqlSelectNIF = new()
                {
                    Connection = conexaoBD,
                    CommandText = "SELECT * FROM Colaboradores  WHERE  nif = " + nif.Text +
                    "ORDER BY id_colaborador"
                };

                SqlDataReader recordNIF = SqlSelectNIF.ExecuteReader();
                if (recordNIF.RecordsAffected == 0)
                {
                    MessageBox.Show("NIF Inválido!");
                }
                else
                {
                    SqlCommand SqlSelect = new()
                    {
                        Connection = conexaoBD,
                        CommandText = "SELECT * FROM Colaboradores  WHERE  nif = " + nif.Text +
                        "ORDER BY id_colaborador"
                    };

                    SqlSelect.ExecuteNonQuery();
                    

                    //Salvando arquivos em PDF
                    using (conexaoBD)
                    {
                        string querySelect = "SELECT * FROM Colaboradores  WHERE  nif = " + nif.Text + 
                            "ORDER BY id_colaborador";
                        SqlDataAdapter select = new()
                        {
                            SelectCommand = new SqlCommand(querySelect, conexaoBD)
                        };
                        //select.Fill(select);
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
