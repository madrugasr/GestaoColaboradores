using GestaoColaboradores.Colaborador;

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
        
        private void NovoColaborador_Click(object sender, EventArgs e)
        {

            Novo addCollaborator = new()
            {
                TopLevel = false
            };           

            if (panelPrincipal.Controls.Count > 1)
            {
                addCollaborator.Close();
            }
            else
            {
                addCollaborator.MdiParent = this;
                panelPrincipal.Controls.Add(addCollaborator);
                addCollaborator.Show();
            }
        }
        private void ConsultarColaborador_Click(object sender, EventArgs e)
        {
           
        }

        private void AlterarColaborador_Click(object sender, EventArgs e)
        {

            Alterar alter = new()
            {
                TopLevel = false
            };

            if (panelPrincipal.Controls.Count > 1)
            {
                alter.Close();
            }

            else
            {
                panelPrincipal.Controls.Add(alter);
                alter.Show();
            }
        }

        private void HoursNow_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            HoursNow.Start();
        }
    }
}
