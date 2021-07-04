using System;
using System.Windows.Forms;
using DTO;
using Negocio;

namespace DesktopUI.FormVendedores
{
    public partial class FormVendedoresModificar : Form
    {
        private readonly VendedoresNegocio vendedoresNegocio = new VendedoresNegocio();

        public int Id { get; set; }

        public FormVendedoresModificar()
        {
            InitializeComponent();
        }

        private void FormVendedoresModificar_Load(object sender, EventArgs e)
        {
            try
            {
                Vendedores vendedor = vendedoresNegocio.LeerPorId(this.Id);
                TxNombre.Text = vendedor.Nombre;
                TxApellido.Text = vendedor.Apellido;
                TxSucursal.Text = vendedor.Sucursal;
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
                Vendedores vendedor = new Vendedores();
                try
                {
                    vendedor.Id = this.Id;
                    vendedor.Nombre = TxNombre.Text;
                    vendedor.Apellido = TxApellido.Text;
                    vendedor.Sucursal = TxSucursal.Text;
                }
                catch
                {
                    throw new Exception("Uno o más campos poseen un tipo de dato erróneo");
                }

                vendedoresNegocio.Modificar(vendedor);

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
