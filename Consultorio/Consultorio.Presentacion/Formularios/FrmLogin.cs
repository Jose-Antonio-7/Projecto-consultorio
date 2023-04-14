using Consultorio.Dominio.Entidades;
using Consultorio.Presentacion.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio.Presentacion.Formularios
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();

        }

        private async void btnContinuar_click(object sender, EventArgs e)
        {
            var correo = txtCorreo.Text;
            var contraseña = txtContraseña.Text;

            User user = new User(correo, contraseña);

            var securityService = new SecurityService(); // Checar por que este es nulo

            var httpmessage = await securityService.Login(user);

            if (httpmessage != null)
            {
                var frmprincipal = new FrmPrincipal(httpmessage);

                frmprincipal.ShowDialog();
            }
            else
            {

            }
        }

        private async void btnCrear_click(object sender, EventArgs e)
        {
            //var FrmPrincipal = new FrmUsers(_authContext);
            //FrmPrincipal.ShowDialog();
        }

    }
}
