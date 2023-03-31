using Consultorio.Presentacion.Services;
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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        List<Cliente> clienteList = new List<Cliente>();

        private async void btnConfirmarCliente_Click(object sender, EventArgs e)
        {

            //Agregar try catch
            try
            {
                btnConfirmarCliente.Enabled = false;

                GuardarCliente(
                    tbNombreCliente.Text,
                    tbApellidoCliente.Text,
                    int.Parse(tbEdadCliente.Text),
                    tbDireccionCliente.Text,
                    tbTelefonoCliente.Text
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally
            {
                btnConfirmarCliente.Enabled=true;
            }

        }

        private async Task GuardarCliente(string nombre, string apellido, int edad, string direccion, string telefono)
        {
            //if (string.IsNullOrWhiteSpace(nombre))
            //{
            //    throw new ArgumentException("Los valores no son validos", "Nombre:");
            //}
            //if (string.IsNullOrWhiteSpace(apellido))
            //{
            //    throw new ArgumentException("Los valores no son validos", "Apellido:");
            //}
            //if (string.IsNullOrWhiteSpace(direccion))
            //{
            //    throw new ArgumentException("Los valores no son validos", "Direccion:");
            //}
            //if (string.IsNullOrWhiteSpace(telefono))
            //{
            //    throw new ArgumentException("Los valores no son validos", "Telefono:");
            //}

            var cliente = new Cliente(nombre, apellido, edad, direccion, telefono);

            var clienteService = new ClienteService(); // Checar por que este es nulo

            await clienteService.Almacenar(cliente); 


            //List<Cliente> Clientes = context.Clientes.ToList();

            dtgClientes.DataSource = await clienteService.ConsultarTodos();

        }

       

        private void AlmacenarTxt(Cliente cliente)
        {
            
        }

        private async void FrmClientes_Load(object sender, EventArgs e)
        {
            try
            {
                var clienteService = new ClienteService();

                btnConfirmarCliente.Enabled = false;

                dtgClientes.DataSource = await clienteService.ConsultarTodos();

            }
            finally
            {
                btnConfirmarCliente.Enabled = true;

            }



        }
    }
}
