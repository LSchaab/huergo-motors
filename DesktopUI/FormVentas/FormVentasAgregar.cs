using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DTO;
using Negocio;
using DesktopUI.FormClientes;
using System.Globalization;

namespace DesktopUI.FormVentas
{
    public partial class FormVentasAgregar : Form
    {
        private readonly VendedoresNegocio vendedoresNegocio = new VendedoresNegocio();

        private readonly VehiculosNegocio vehiculosNegocio = new VehiculosNegocio();

        private readonly AccesoriosNegocio accesoriosNegocio = new AccesoriosNegocio();

        private readonly List<Accesorios> accesoriosAgregados = new List<Accesorios>();

        private readonly VentasNegocio ventasNegocio = new VentasNegocio();

        private readonly UiHelper helper = new UiHelper();

        private int IdClienteSeleccionado { get; set; }

        public FormVentasAgregar()
        {
            InitializeComponent();
        }

        private void FormVentasAgregar_Load(object sender, EventArgs e)
        {
            try
            {
                gridView.AutoGenerateColumns = false;
                helper.LlenarComboVendedores(CbVendedor, "NombreApellido", "Id");
                helper.LlenarComboModeloVehiculos(CbModeloVehiculo, "Modelo", "Id");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarGrilla()
        {
            gridView.DataSource = new BindingList<Accesorios>(this.accesoriosAgregados);
        }

        private void RefrescarPrecioTotal()
        {
            decimal total = 0;
            total += Convert.ToDecimal(LbCostoVehiculo.Text);
            foreach (Accesorios accesorio in this.accesoriosAgregados)
            {
                total += accesorio.Precio;
            }
            LbPrecioTotal.Text = total.ToString(CultureInfo.InvariantCulture);
        }

        private void CbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)CbVendedor.SelectedValue;
                Vendedores vendedor = vendedoresNegocio.LeerPorId(id);
                LbSucursalVendedor.Text = vendedor.Sucursal;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbModeloVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)CbModeloVehiculo.SelectedValue;
                Vehiculos vehiculo = vehiculosNegocio.LeerPorId(id);
                LbTipoVehiculo.Text = vehiculo.Tipo;
                LbCostoVehiculo.Text = vehiculo.PrecioVenta.ToString(CultureInfo.InvariantCulture);

                this.accesoriosAgregados.Clear();
                RefrescarGrilla();
                RefrescarPrecioTotal();
                helper.LlenarComboAccesorios(CbAccesorio, id, "NombreTipo", "Id");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtSeleccionarCliente_Click(object sender, EventArgs e)
        {
            FormClientesMain form = new FormClientesMain();
            form.MostrarBtSeleccionar();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                this.IdClienteSeleccionado = form.ClienteSeleccionado.Id;
                LbNombreCliente.Text = form.ClienteSeleccionado.Nombre;
                LbTelefonoCliente.Text = form.ClienteSeleccionado.Telefono;
                LbEmailCliente.Text = form.ClienteSeleccionado.Email;
            }
            else
            {
                LbNombreCliente.Text = string.Empty;
                LbTelefonoCliente.Text = string.Empty;
                LbEmailCliente.Text = string.Empty;
            }
        }

        private void BtAgregarAccesorio_Click(object sender, EventArgs e)
        {
            if (CbAccesorio.Text == string.Empty)
            {
                MessageBox.Show($"No has seleccionado ningun accesorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int id = (int)CbAccesorio.SelectedValue;
                this.accesoriosAgregados.Add(accesoriosNegocio.LeerPorId(id));
                RefrescarGrilla();
                RefrescarPrecioTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridView.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                try
                {
                    this.accesoriosAgregados.Remove(this.accesoriosAgregados[e.RowIndex]);
                    RefrescarGrilla();
                    RefrescarPrecioTotal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (LbNombreCliente.Text == ". . ." || LbSucursalVendedor.Text == ". . ." || LbTipoVehiculo.Text == ". . .")
                {
                    throw new Exception("Uno o mas campos están vacíos");
                }

                int idVehiculo = (int)CbModeloVehiculo.SelectedValue;
                Vehiculos vehiculo = vehiculosNegocio.LeerPorId(idVehiculo);
                if (vehiculo.Stock <= 0)
                    throw new Exception("No hay mas stock del vehiculo seleccionado");

                Ventas venta = new Ventas
                {
                    Fecha = dateTimePickerFecha.Value,
                    IdVehiculo = idVehiculo,
                    ModeloVehiculo = CbModeloVehiculo.Text,
                    IdCliente = this.IdClienteSeleccionado,
                    NombreCliente = LbNombreCliente.Text,
                    IdVendedor = (int)CbVendedor.SelectedValue,
                    NombreVendedor = CbVendedor.Text,
                    Observaciones = TxObservaciones.Text,
                    Total = Convert.ToDecimal(LbPrecioTotal.Text)
                };

                ventasNegocio.CrearVenta(venta, this.accesoriosAgregados);

                MessageBox.Show("Registros creados exitosamente", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
