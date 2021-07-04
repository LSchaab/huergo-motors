using System;
using System.Windows.Forms;
using Negocio;
using DTO;

namespace DesktopUI.FormClientes
{
    public partial class FormClientesAgregar : Form
    {
        private readonly ClientesNegocio clientesNegocio = new ClientesNegocio();

        public FormClientesAgregar()
        {
            InitializeComponent();
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes cliente = new Clientes();
                
                try
                {
                    cliente.Nombre = TxNombre.Text;
                    cliente.Direccion = TxDireccion.Text;
                    cliente.Telefono = TxTelefono.Text;
                    cliente.Email = TxEmail.Text;
                }
                catch
                {
                    throw new Exception("Uno o más campos poseen un tipo de dato erróneo");
                }

                clientesNegocio.Crear(cliente);

                MessageBox.Show("Registro creado exitosamente", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
