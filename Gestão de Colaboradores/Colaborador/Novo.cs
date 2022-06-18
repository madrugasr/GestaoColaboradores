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

namespace GestaoColaboradores.Colaborador
{
    public partial class Novo : Form
    {
        public Novo()
        {
            InitializeComponent();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastrarColaborador_Click(object sender, EventArgs e)
        {
            ValidateForm();

            //Validação do Formulário
            if (nomeCompleto.Text == "" || dataNascimento.Text == "" || sexo.Text == ""
                || nif.Text == "" || niss.Text == "" || rua.Text == "" || numero_casa.Text == ""
                || concelho.Text == "" || codigo_postal.Text == "" || telefone.Text == ""
                || cargo.Text == "" || ordenado_bruto.Text == "" || iban.Text == "" || cliente.Text == ""
                || ingresso.Text == "" || contrato.Text == "" || equipa.Text == "")
            {
                    MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                //Inserindo dados na tabela Colaboradores           
                SqlConnection conexaoBD = new(@"Data Source=WP-01-NBK-02654; Initial Catalog=Colaboradores;
                                                  Integrated Security=True");
                try
                {
                    
                    conexaoBD.Open();
                    
                    SqlCommand SqlInsertCollaborator = new()
                    {
                        Connection = conexaoBD,

                        CommandText = "INSERT INTO Colaboradores " +
                        "(nome, data_nascimento, sexo, niss, nif, rua, numero_casa, " +
                        "concelho, codigo_postal, telefone, email, cargo, ordenado_bruto, " +
                        "iban, cliente, data_ingresso, contrato, equipa) " +
                        "VALUES " +
                        "(@nomeCompleto, @dataNascimento, @sexo, @niss, @nif, @rua, @numero_casa, " +
                        "@concelho, @codigo_postal, @telefone, @email, @cargo, @ordenado_bruto, " +
                        "@iban, @cliente, @ingresso, @contrato, @equipa)"

                    };
                    

                    //Coleta de Dados para inserir na BD
                    SqlInsertCollaborator.Parameters.AddWithValue("@nomeCompleto", nomeCompleto.Text);

                    //Converte a Data Nascimento para DateTime
                    DateTime data_nascimento = Convert.ToDateTime(dataNascimento.Text);
                    SqlInsertCollaborator.Parameters.AddWithValue("@dataNascimento", data_nascimento);

                    //Converte lista Sexo em String
                    string sexo_ = Convert.ToString(sexo.Text);
                    SqlInsertCollaborator.Parameters.AddWithValue("@sexo", sexo_);

                    SqlInsertCollaborator.Parameters.AddWithValue("@niss", niss.Text);
                    SqlInsertCollaborator.Parameters.AddWithValue("@nif", nif.Text);
                    SqlInsertCollaborator.Parameters.AddWithValue("@rua", rua.Text);
                    SqlInsertCollaborator.Parameters.AddWithValue("@numero_casa", numero_casa.Text);
                    SqlInsertCollaborator.Parameters.AddWithValue("@concelho", concelho.Text);
                    SqlInsertCollaborator.Parameters.AddWithValue("@codigo_postal", codigo_postal.Text);
                    SqlInsertCollaborator.Parameters.AddWithValue("@telefone", telefone.Text);
                    SqlInsertCollaborator.Parameters.AddWithValue("@email", email.Text);
                    SqlInsertCollaborator.Parameters.AddWithValue("@cargo", cargo.Text);
                    SqlInsertCollaborator.Parameters.AddWithValue("@ordenado_bruto", ordenado_bruto.Text);
                    SqlInsertCollaborator.Parameters.AddWithValue("@iban", iban.Text);
                    SqlInsertCollaborator.Parameters.AddWithValue("@cliente", cliente.Text);

                    //Converte a Data de Ingresso para DateTime
                    DateTime dataIngresso = Convert.ToDateTime(ingresso.Text);
                    SqlInsertCollaborator.Parameters.AddWithValue("@ingresso", dataIngresso);

                    //Converte a lista Tipo de Contrato para String
                    string contrato_ = Convert.ToString(contrato.Text);
                    SqlInsertCollaborator.Parameters.AddWithValue("@contrato", contrato_);


                    //Convertendo a lista Equipa para String
                    string equipa_ = Convert.ToString(equipa.Text);
                    SqlInsertCollaborator.Parameters.AddWithValue("@equipa", equipa_);

                    SqlDataReader readerRecord = SqlInsertCollaborator.ExecuteReader();
                    if (readerRecord.RecordsAffected > 0)
                    {
                        MessageBox.Show("Colaborador inserido com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao inserir colaborador!");
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

        //Formulário de Validação.
        public void ValidateForm()
        {
            //Validação do Nome Completo
            if (nomeCompleto.Text == "")
            {
                MessageBox.Show("Preencha o Nome Completo!");
                nomeCompleto.BackColor = Color.Red;
            }

            //Validação da Data de Nascimento
            if (dataNascimento.Text == "")
            {
                MessageBox.Show("Preencha a Data de Nascimento!");
                dataNascimento.BackColor = Color.Red;
            }
            else
            {
                DateTime data_nascimento = Convert.ToDateTime(dataNascimento.Text);
                if (data_nascimento >= DateTime.Now || data_nascimento < DateTime.Now.AddYears(-65))
                {
                    MessageBox.Show("Data de Nascimento inválida!");
                    dataNascimento.BackColor = Color.Red;
                }
            }

            //Validação do Sexo
            if (sexo.Text == "")
            {
                MessageBox.Show("Preencha o Sexo!");
                sexo.BackColor = Color.Red;
            }
            else 
            {
                if (sexo.Text != "Masculino" || sexo.Text != "Feminino")
                {
                    MessageBox.Show("Sexo inválido!");
                    sexo.BackColor = Color.Red;
                }
            }

            //Validação do NISS
            if (niss.Text == "" || niss.Text.Length != 11)
            {
                MessageBox.Show("Preencha o NISS corretamente!");
                niss.BackColor = Color.Red;
            }
            else
            {
                //Regra de Validação do NISS
                if (niss.Text.Substring(0, 1) != "0")
                {
                    MessageBox.Show("NISS inválido!");
                    niss.BackColor = Color.Red;
                }
            }

            //Validação do NIF
            if (nif.Text == "" || nif.Text.Length != 9)
            {
                MessageBox.Show("Preencha o NIF corretamente!");
                nif.BackColor = Color.Red;
            }
            else
            {
                //Regra de Validação do NIF
                if (nif.Text.Substring(0, 1) != "0")
                {
                    MessageBox.Show("NIF inválido!");
                    nif.BackColor = Color.Red;
                }
            }
          
            //Validação da Rua
            if (rua.Text == "")
            {
                MessageBox.Show("Preencha a Rua!");
                rua.BackColor = Color.Red;
            }
            else
            {
                if (rua.Text.Length < 10)
                {
                    MessageBox.Show("Rua inválida!");
                    rua.BackColor = Color.Red;
                }
            }

            //Validação do Número da Casa
            if (numero_casa.Text == "" || numero_casa.Text.Length < 1)
            {
                MessageBox.Show("Preencha o Número da Casa corretamente!");
                numero_casa.BackColor = Color.Red;
            }

            //Validação do Concelho
            if (concelho.Text == "" || concelho.Text.Length < 5)
            {
                MessageBox.Show("Preencha o Concelho! correntamente");
                concelho.BackColor = Color.Red;
            }

            //Validação do Código Postal
            if (codigo_postal.Text == "" || codigo_postal.Text.Length < 4)
            {
                MessageBox.Show("Preencha o Código Postal corretamente!");
                codigo_postal.BackColor = Color.Red;
            }
            else
            {
                //Regra de Validação do Código Postal
                if (codigo_postal.Text.Substring(0, 1) == "0")
                {
                    MessageBox.Show("Código Postal inválido!");
                    codigo_postal.BackColor = Color.Red;
                }
            }

            //Validação do Telefone
            if (telefone.Text == "" || telefone.Text.Length < 9)
            {
                MessageBox.Show("Preencha o Telefone corretamente!");
                telefone.BackColor = Color.Red;
            }
            else
            {
                //Regra de Validação do Telefone
                if (telefone.Text.Substring(0, 1) == "0")
                {
                    MessageBox.Show("Telefone inválido!");
                    telefone.BackColor = Color.Red;
                }
            }

            //Validação do Email
            if (email.Text == "" || email.Text.Length < 10)
            {
                MessageBox.Show("Preencha o Email corretamente!");
                email.BackColor = Color.Red;
            }
            else
            {
                //Regra de Validação do Email
                if (email.Text.Substring(0, 1) != "@" || email.Text.Substring(0, 1) != ".")
                {
                    MessageBox.Show("Email inválido!");
                    email.BackColor = Color.Red;
                }                             
            }

            //Validação do Cargo
            if (cargo.Text == "" )
            {
                MessageBox.Show("Preencha o Cargo!");
                cargo.BackColor = Color.Red;
            }
            else
            {
                if (cargo.Text.Length <= 5)
                {
                    MessageBox.Show("Cargo inválido!");
                    cargo.BackColor = Color.Red;
                }
            }

            //Validação do Ordenado Bruto
            if (ordenado_bruto.Text == "" || ordenado_bruto.Text.Length < 705 || ordenado_bruto.Text.Length < 0)
            {
                MessageBox.Show("Preencha o Ordenado Bruto corretamente!");
                ordenado_bruto.BackColor = Color.Red;
            }
            else
            {
                //Regra de Validação do Ordenado Bruto
                if (ordenado_bruto.Text.Substring(0, 1) == "0")
                {
                    MessageBox.Show("Ordenado Bruto inválido!");
                    ordenado_bruto.BackColor = Color.Red;
                }
            }

            //Validação do IBAN
            if (iban.Text == "" || iban.Text.Length < 34)
            {
                MessageBox.Show("Preencha o IBAN corretamente!");
                iban.BackColor = Color.Red;
            }
            else
            {
                //Regra de Validação do IBAN
                if (iban.Text.Substring(0, 1) == "0")
                {
                    MessageBox.Show("IBAN inválido!");
                    iban.BackColor = Color.Red;
                }
            }

            //Validação da Data do Ingresso do Colaborador
            if (ingresso.Text == "")
            {
                MessageBox.Show("Preencha a Data de Ingresso corretamente!");
                dataNascimento.BackColor = Color.Red;
            }
            else
            {
                DateTime ingresso_colaborador = Convert.ToDateTime(ingresso.Text);
                if (ingresso_colaborador > DateTime.Now || ingresso_colaborador < DateTime.Now.AddYears(-2))
                {
                    MessageBox.Show("Data de Ingresso inválida!");
                    ingresso.BackColor = Color.Red;
                }
            }

            //Validação do Tipo de Contrato
            if (contrato.Text == "" || contrato.Text != "Efetivo" || 
                contrato.Text != "Temporário" || contrato.Text != "Sem Termo")
            {
                MessageBox.Show("Preencha o Tipo de Contrato corretamente!");
                contrato.BackColor = Color.Red;
            }
            else
            {
                //Regra de Validação do Tipo de Contrato
                if (contrato.Text.Substring(0, 1) == "0")
                {
                    MessageBox.Show("Tipo de Contrato inválido!");
                    contrato.BackColor = Color.Red;
                }
            }

            //Validação da Equipa
            if (equipa.Text == "" || equipa.Text != "Desenvolvimento" ||
                equipa.Text != "Engenharia" || equipa.Text != "Suporte IT" || 
                equipa.Text != "Produto" || equipa.Text != "Financeiros" ||
                equipa.Text != "Recursos Humanos" || equipa.Text != "Infraestrutura" ||
                equipa.Text != "Teste")
            {
                MessageBox.Show("Preencha a Equipa corretamente!");
                equipa.BackColor = Color.Red;
            }
            else
            {
                if (equipa.Text.Substring(0, 1) == "0")
                {
                    MessageBox.Show("Equipa inválida!");
                    equipa.BackColor = Color.Red;
                }
            }

            
        }
    }
}
