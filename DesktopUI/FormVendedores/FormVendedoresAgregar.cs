using System;
using System.Windows.Forms;
using DTO;
using Negocio;

namespace DesktopUI.FormVendedores
{
    public partial class FormVendedoresAgregar : Form
    {
        private readonly VendedoresNegocio vendedoresNegocio = new VendedoresNegocio();

        public FormVendedoresAgregar()
        {
            InitializeComponent();
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Vendedores vendedor = new Vendedores();
                try
                {
                    vendedor.Nombre = TxNombre.Text;
                    vendedor.Apellido = TxApellido.Text;
                    vendedor.Sucursal = TxSucursal.Text;
                }
                catch
                {
                    throw new Exception("Uno o más campos poseen un tipo de dato erróneo");
                }

                vendedoresNegocio.Crear(vendedor);

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
