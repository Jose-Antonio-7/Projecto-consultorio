using Consultorio.Presentacion.Formularios;
using Consultorio.Presentacion.Modelos;

namespace Consultorio.Presentacion
{
    public partial class FrmPrincipal : Form
    {

        private AuthContext _authContext;

        public FrmPrincipal(AuthContext authContext)
        {
            InitializeComponent();
            _authContext = authContext;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            var frmClientes = new FrmClientes(_authContext);

            frmClientes.ShowDialog();
        }

        private void btnDoctores_Click(object sender, EventArgs e)
        {
            var frmDoctores = new FrmDoctores();

            frmDoctores.ShowDialog();
        }
    }
}