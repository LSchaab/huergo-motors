using System;
using System.Globalization;
using System.Windows.Forms;
using DTO;
using Negocio;

namespace DesktopUI.FormVehiculos
{
    public partial class FormVehiculosModificar : Form
    {
        private readonly VehiculosNegocio vehiculosNegocio = new VehiculosNegocio();

        public int Id { get; set; }

        public FormVehiculosModificar()
        {
            InitializeComponent();
        }

        private void FormVehiculosModificar_Load(object sender, EventArgs e)
        {
            try
            {
                Vehiculos vehiculo = vehiculosNegocio.LeerPorId(this.Id);
                TxTipo.Text = vehiculo.Tipo;
                TxModelo.Text = vehiculo.Modelo;
                TxPrecio.Text = vehiculo.PrecioVenta.ToString(CultureInfo.InvariantCulture);
                TxStock.Text = vehiculo.Stock.ToString(CultureInfo.InvariantCulture);
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
                Vehiculos vehiculo = new Vehiculos();
                try
                {
                    vehiculo.Id = this.Id;
                    vehiculo.Tipo = TxTipo.Text;
                    vehiculo.Modelo = TxModelo.Text;
                    vehiculo.PrecioVenta = Convert.ToDecimal(TxPrecio.Text);
                    vehiculo.Stock = Convert.ToInt32(TxStock.Text);
                }
                catch
                {
                    throw new Exception("Uno o más campos poseen un tipo de dato erróneo");
                }

                vehiculosNegocio.Modificar(vehiculo);

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
