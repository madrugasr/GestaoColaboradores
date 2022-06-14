using GestaoColaboradores.Colaborador;

namespace Gestão_de_Colaboradores
{
    public partial class Dash : Form
    {
        public Dash()
        {
            InitializeComponent();
        }

        private void NovoColaborador_Click(object sender, EventArgs e)
        {
            Novo addCollaborator = new()
            {
                TopLevel = false
            };
            panelPrincipal.Controls.Add(addCollaborator);
            addCollaborator.Show();
        }
    }
}
