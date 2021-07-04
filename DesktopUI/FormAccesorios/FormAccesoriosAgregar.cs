using System;
using Negocio;
using DTO;
using System.Windows.Forms;

namespace DesktopUI.FormAccesorios
{
    public partial class FormAccesoriosAgregar : Form
    {
        private readonly AccesoriosNegocio accesoriosNegocio = new AccesoriosNegocio();

        private readonly UiHelper helper = new UiHelper();

        public FormAccesoriosAgregar()
        {
            InitializeComponent();
        }

        private void FormAccesoriosAgregar_Load(object sender, EventArgs e)
        {
            try
            {
                helper.LlenarComboModeloVehiculos(CbVehiculo, "Modelo", "Id");
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
                    accesorio.Nombre = TxNombre.Text;
                    accesorio.Tipo = TxTipo.Text;
                    accesorio.Precio = Convert.ToDecimal(TxPrecio.Text);
                    accesorio.IdVehiculo = (int)CbVehiculo.SelectedValue;
                }
                catch
                {
                    throw new Exception("Uno o más campos poseen un tipo de dato erróneo");
                }

                accesoriosNegocio.Crear(accesorio);

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
