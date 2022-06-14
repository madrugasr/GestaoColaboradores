﻿using System.Data.SqlClient;

namespace Gestão_de_Colaboradores
{
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
        }

        //Passagem de Parâmetro do textBox Login para o form Editar textBox Login
        //Propriedade
        public string AcessoLogin { set => email.Text = value; }

        private void Remover_Click(object sender, EventArgs e)
        {

            //Validação
            if (password.Text != repeatPassword.Text || password.Text == "")
            {
                MessageBox.Show("Senhas Inválidas!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Quer remover o registro?", "Remover Conta",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (dialogResult == DialogResult.Yes)
                {

                    //Conexão BD
                    SqlConnection conexaoBD = new("Data Source=WP-01-NBK-02654; Initial Catalog=Colaboradores; " +
                        "Integrated Security=True");

                    try
                    {
                        conexaoBD.Open();

                        //Token do BD
                        SqlCommand SqlDelete = new()
                        {
                            Connection = conexaoBD,

                            //Statement SQL Delete
                            CommandText = "DELETE FROM Login WHERE email = '" + email.Text +
                                           "' AND password = '" + password.Text + "'"
                        };

                        //Executa o comando SQL e retorna o número de linhas afetadas.
                        int i = SqlDelete.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Conta Eliminada", "Remover", MessageBoxButtons.OK);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Conta não Encontrada", "Erro", MessageBoxButtons.OK);
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
        }

        private void EditarRegistro_Click(object sender, EventArgs e)
        {

            //Validação
            if (password.Text != repeatPassword.Text || password.Text == "")
            {
                MessageBox.Show("Senhas Inválidas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conexaoBD = new("Data Source=WP-01-NBK-02654; Initial Catalog=Colaboradores; " +
                        "Integrated Security=True");

                try
                {
                    conexaoBD.Open();

                    //Verifica se os dados existem na BD.
                    SqlCommand SqlSelect = new()
                    {
                        Connection = conexaoBD,
                        CommandText = "SELECT * FROM Login WHERE email = '" + email.Text +
                                       "' AND password = '" + password.Text + "'"
                    };

                    SqlDataReader recordReader = SqlSelect.ExecuteReader();
                    if (recordReader.HasRows)
                    {
                        recordReader.Close();

                        MessageBox.Show("Dados Inexistentes ou Alterados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        recordReader.Close();

                        //Token do BD
                        SqlCommand SqlUpdate = new()
                        {
                            Connection = conexaoBD,

                            //Statement SQL Update
                            CommandText = "UPDATE Login SET email = '" + email.Text +
                            "', password = '" + password.Text + "' WHERE email = '" + email.Text + "'"
                        };

                        SqlUpdate.ExecuteNonQuery();

                        MessageBox.Show("Conta Alterada!", "Editar", MessageBoxButtons.OK);
                        this.Close();
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
    }
}

