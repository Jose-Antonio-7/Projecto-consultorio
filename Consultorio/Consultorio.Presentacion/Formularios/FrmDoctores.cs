//using Consultorio.Presentacion.Contextos;
//using Consultorio.Presentacion.Entidades;
//using Consultorio.Presentacion.TextFilesRepositories;

//using Consultorio.Aplicacion.Servicios;

using Consultorio.Dominio.Entidades;
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
        public FrmDoctores()
        {
            InitializeComponent();
        }
        List<Doctor> doctorList = new List<Doctor>();

        private void btnConfirmarDoctor_Click(object sender, EventArgs e)
        {
            //Agregar try catch
            try
            {
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
        }

        private void GuardarDoctor(string nombre, string apellido, string cedula, string telefono)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("Los valores no son validos", "Nombre:");
            }
            if (string.IsNullOrWhiteSpace(apellido))
            {
                throw new ArgumentException("Los valores no son validos", "Apellido:");
            }
            if (string.IsNullOrWhiteSpace(cedula))
            {
                throw new ArgumentException("Los valores no son validos", "Direccion:");
            }
            if (string.IsNullOrWhiteSpace(telefono))
            {
                throw new ArgumentException("Los valores no son validos", "Telefono:");
            }

            var doctor = new Doctor(nombre, apellido, cedula, telefono);

            //var doctorService = new DoctorService();

            //doctorService.Almacenar(doctor);

            //dtgDoctores.DataSource = doctorService.ConsultarTodos();
            
        }

        //private void AlmacenarBD(Doctor doctor)
        //{
        //    var context = new ContextoSQLite();

        //    context.Doctores.Add(doctor);

        //    context.SaveChanges();

        //    List<Doctor> Doctores = context.Doctores.ToList();

        //    dtgDoctores.DataSource = Doctores;
        //}

        private void AlmacenarTxt(Doctor doctor)
        {
            //StreamWriter writer = new StreamWriter("C:\\Users\\Antonio\\Desktop\\Programas mios\\C#\\DoctoresCore.txt", true);

            //var datos = doctor;
            //writer.Write(datos);
            //writer.Close();
            //writer.Dispose();
        }

        private void FrmDoctores_Load(object sender, EventArgs e)
        {
            //var doctorService = new DoctorService();
            //dtgDoctores.DataSource = doctorService.ConsultarTodos();

        }
    }
}
