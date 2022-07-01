using GestaoColaboradores.Arquivos;
using GestaoColaboradores.Colaborador;
using GestaoColaboradores.Lista_Colaboradores;

namespace Gestão_de_Colaboradores
{
    public partial class Dash : Form
    {
        public Dash()
        {
            InitializeComponent();
        }

        //Passagem de Parâmetro do textBox Login para o form Dash textBox Login
        //Propriedade
        public string LoginDash { set => user.Text = value; }


        //Hora Atual
        private void HoursNow_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            HoursNow.Start();
        }
        
        private void NovoColaborador_Click(object sender, EventArgs e)
        {
            Novo novoColaborador = new()
            {
                TopLevel = false
            };
            if (panelPrincipal.Controls.Count > 1)
            {
                novoColaborador.Close();
            }
            else
            {
                novoColaborador.MdiParent = this;
                panelPrincipal.Controls.Add(novoColaborador);
                novoColaborador.Show();
            }

        }
        private void ConsultarColaborador_Click(object sender, EventArgs e)
        {
            Consultar consultar = new()
            {
                TopLevel = false
            };

            if (panelPrincipal.Controls.Count > 1)
            {
                consultar.Close();
            }
            else
            {
                consultar.MdiParent = this;
                panelPrincipal.Controls.Add(consultar);
                consultar.Show();
            }
        }

        private void AlterarColaborador_Click(object sender, EventArgs e)
        {
            Alterar alterar = new()
            {
                TopLevel = false
            };

            if (panelPrincipal.Controls.Count > 1)
            {
                alterar.Close();
            }
            else
            {
                alterar.MdiParent = this;
                panelPrincipal.Controls.Add(alterar);
                alterar.Show();
            }
        }

        private void EliminarColbadorador_Click(object sender, EventArgs e)
        {
            Eliminar eliminar = new()
            {
                TopLevel = false
            };
            if (panelPrincipal.Controls.Count > 1)
            {
                eliminar.Close();
            }
            else
            {
                eliminar.MdiParent = this;
                panelPrincipal.Controls.Add(eliminar);
                eliminar.Show();
            }
        }

        private void MapaColaborador_Click(object sender, EventArgs e)
        {
            MapaColaboradores mapaColaboradores = new()
            {
                TopLevel = false
            };
            if (panelPrincipal.Controls.Count > 1)
            {
                mapaColaboradores.Close();
            }
            else
            {
                mapaColaboradores.MdiParent = this;
                panelPrincipal.Controls.Add(mapaColaboradores);
                mapaColaboradores.Show();
            }

        }

        private void SalvarArquivo_Click(object sender, EventArgs e)
        {
            SalvarArquivos salvar = new()
            {
                TopLevel = false
            };
            if (panelPrincipal.Controls.Count > 1)
            {
                salvar.Close();
            }
            else
            {
                salvar.MdiParent = this;
                panelPrincipal.Controls.Add(salvar);
                salvar.Show();
            }
        }
    }
}
