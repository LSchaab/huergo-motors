using System;
using DTO;
using Negocio;
using System.Windows.Forms;

namespace DesktopUI.FormClientes
{
    public partial class FormClientesModificar : Form
    {
        public int IdCliente { get; set; }

        private readonly ClientesNegocio clientesNegocio = new ClientesNegocio();

        public FormClientesModificar()
        {
            InitializeComponent();
        }

        private void FormClientesModificar_Load(object sender, EventArgs e)
        {
            try
            {
                Clientes cliente = clientesNegocio.LeerPorId(this.IdCliente);
                TxNombre.Text = cliente.Nombre;
                TxDireccion.Text = cliente.Direccion;
                TxTelefono.Text = cliente.Telefono;
                TxEmail.Text = cliente.Email;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes cliente = new Clientes();
                try
                {
                    cliente.Id = this.IdCliente;
                    cliente.Nombre = TxNombre.Text;
                    cliente.Direccion = TxDireccion.Text;
                    cliente.Telefono = TxTelefono.Text;
                    cliente.Email = TxEmail.Text;
                    
                }
                catch
                {
                    throw new Exception("Uno o más campos poseen un tipo de dato erróneo");
                }

                clientesNegocio.Modificar(cliente);

                MessageBox.Show("Registro modificado exitosamente", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
