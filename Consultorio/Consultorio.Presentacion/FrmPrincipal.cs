using Consultorio.Presentacion.Formularios;

namespace Consultorio.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            var frmClientes = new FrmClientes();

            frmClientes.ShowDialog();
        }

        private void btnDoctores_Click(object sender, EventArgs e)
        {
            var frmDoctores = new FrmDoctores();

            frmDoctores.ShowDialog();
        }
    }
}