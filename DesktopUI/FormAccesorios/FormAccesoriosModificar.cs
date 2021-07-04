using System;
using System.Globalization;
using System.Windows.Forms;
using DTO;
using Negocio;

namespace DesktopUI.FormAccesorios
{
    public partial class FormAccesoriosModificar : Form
    {
        public int Id { get; set; }

        private readonly AccesoriosNegocio accesoriosNegocio = new AccesoriosNegocio();

        private readonly UiHelper helper = new UiHelper();

        public FormAccesoriosModificar()
        {
            InitializeComponent();
        }

        private void FormAccesoriosModificar_Load(object sender, EventArgs e)
        {
            try
            {
                helper.LlenarComboModeloVehiculos(CbVehiculo, "Modelo", "Id");

                Accesorios accesorio = accesoriosNegocio.LeerPorId(this.Id);
                TxNombre.Text = accesorio.Nombre;
                TxTipo.Text = accesorio.Tipo;
                TxPrecio.Text = accesorio.Precio.ToString(CultureInfo.InvariantCulture);
                CbVehiculo.SelectedValue = accesorio.IdVehiculo;
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
                Accesorios accesorio = new Accesorios();

                try
                {
                    accesorio.Id = this.Id;
                    accesorio.Nombre = TxNombre.Text;
                    accesorio.Tipo = TxTipo.Text;
                    accesorio.Precio = Convert.ToDecimal(TxPrecio.Text);
                    accesorio.IdVehiculo = (int)CbVehiculo.SelectedValue;
                }
                catch
                {
                    throw new Exception("Uno o más campos poseen un tipo de dato erróneo");
                }

                accesoriosNegocio.Modificar(accesorio);

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
