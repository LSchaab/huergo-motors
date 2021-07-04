using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;
using Negocio;

namespace DesktopUI.FormVentas
{
    public partial class FormVentasMain : Form
    {
        private readonly VentasNegocio ventasNegocio = new VentasNegocio();

        public FormVentasMain()
        {
            InitializeComponent();
        }

        private void FormVentasMain_Load(object sender, EventArgs e)
        {
            gridViewVentas.AutoGenerateColumns = false;
            gridViewVentasAccesorios.AutoGenerateColumns = false;
            RefrescarGrillaVentas(TxFiltro.Text);
        }

        private void RefrescarGrillaVentas(string filtro)
        {
            try
            {
                List<Ventas> ventas = ventasNegocio.LeerVentasPorFiltro(filtro);
                gridViewVentas.DataSource = ventas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            RefrescarGrillaVentas(TxFiltro.Text);
        }

        private void BtMostrarTodo_Click(object sender, EventArgs e)
        {
            RefrescarGrillaVentas(TxFiltro.Text = string.Empty);
        }

        private void BtNuevo_Click(object sender, EventArgs e)
        {
            FormVentasAgregar form = new FormVentasAgregar();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                RefrescarGrillaVentas(TxFiltro.Text = string.Empty);
            }
        }

        private void GridViewVentas_SelectionChanged(object sender, EventArgs e)
        {
            if (gridViewVentas.SelectedRows.Count == 1)
            {
                int id = ((Ventas)gridViewVentas.SelectedRows[0].DataBoundItem).Id;
                try
                {
                    List<VentasAccesorios> ventasAccesorios = ventasNegocio.LeerVentasAccesoriosPorIdVenta(id);
                    gridViewVentasAccesorios.DataSource = ventasAccesorios;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
