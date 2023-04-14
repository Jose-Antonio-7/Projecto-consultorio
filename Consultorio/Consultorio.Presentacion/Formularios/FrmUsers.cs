using Consultorio.Dominio.Entidades;
using Consultorio.Presentacion.Modelos;
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
    public partial class FrmUsers : Form
    {
        private AuthContext _authContext;//Agregado
        public FrmUsers(AuthContext authContext /*Agregado*/)
        {
            InitializeComponent();
            _authContext = authContext; //Agregado

        }

        private async void btnCrearUser_Click(object sender, EventArgs e)
        {

            //Agregar try catch
            try
            {
                btnCrearUser.Enabled = false;

                GuardarUser(
                    txtLogin.Text,
                    txtContraseña.Text
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnCrearUser.Enabled = true;
            }

        }

        private async Task GuardarUser(string login, string contraseña)
        {

            var user = new User(login, contraseña);

            var userService = new UserService(_authContext); // Checar por que este es nulo

            await userService.Almacenar(user);

        }
    }
}
