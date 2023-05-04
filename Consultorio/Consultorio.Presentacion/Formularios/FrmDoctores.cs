//using Consultorio.Presentacion.Contextos;
//using Consultorio.Presentacion.Entidades;
//using Consultorio.Presentacion.TextFilesRepositories;

//using Consultorio.Aplicacion.Servicios;

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
    public partial class FrmDoctores : Form
    {
        private AuthContext _authContext;

        public FrmDoctores(AuthContext authContext)
        {
            InitializeComponent();
            _authContext = authContext;
        }
        List<Doctor> doctorList = new List<Doctor>();

        private async void btnConfirmarDoctor_Click(object sender, EventArgs e)
        {
            //Agregar try catch
            try
            {
                btnConfirmarDoctor.Enabled = false;
                GuardarDoctor(
                    tbNombreDoctor.Text,
                    tbApellidoDoctor.Text,
                    tbCedulaDoctor.Text,
                    tbTelefonoDoctor.Text
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnConfirmarDoctor.Enabled = true;
            }
        }

        private async Task GuardarDoctor(string nombre, string apellido, string cedula, string telefono)
        {
            var doctor = new Doctor(nombre, apellido, cedula, telefono);

            var doctorService = new DoctorService(_authContext);

            await doctorService.Almacenar(doctor);

            dtgDoctores.DataSource = await doctorService.ConsultarTodos();

        }

        private void AlmacenarTxt(Doctor doctor)
        {
        }

        private async void FrmDoctores_Load(object sender, EventArgs e)
        {
            try
            {
                var doctorService = new DoctorService(_authContext);

                btnConfirmarDoctor.Enabled = false;

                dtgDoctores.DataSource = await doctorService.ConsultarTodos();

            }
            finally
            {
                btnConfirmarDoctor.Enabled = true;
            }
        }
    }
}
