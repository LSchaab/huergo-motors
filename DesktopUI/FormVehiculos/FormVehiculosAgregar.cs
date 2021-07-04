using System;
using System.Windows.Forms;
using Negocio;
using DTO;

namespace DesktopUI.FormVehiculos
{
    public partial class FormVehiculosAgregar : Form
    {
        private readonly VehiculosNegocio vehiculosNegocio = new VehiculosNegocio();

        public FormVehiculosAgregar()
        {
            InitializeComponent();
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Vehiculos vehiculo = new Vehiculos();
                try
                {
                    vehiculo.Tipo = TxTipo.Text;
                    vehiculo.Modelo = TxModelo.Text;
                    vehiculo.PrecioVenta = Convert.ToDecimal(TxPrecio.Text);
                    vehiculo.Stock = Convert.ToInt32(NumericStock.Value);
                 
                }
                catch
                {
                    throw new Exception("Uno o más campos poseen un tipo de dato erróneo");
                }

                vehiculosNegocio.Crear(vehiculo);

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
