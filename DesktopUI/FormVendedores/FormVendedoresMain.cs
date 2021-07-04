using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;
using Negocio;

namespace DesktopUI.FormVendedores
{
    public partial class FormVendedoresMain : Form
    {
        private readonly VendedoresNegocio vendedoresNegocio = new VendedoresNegocio();
        
        public FormVendedoresMain()
        {
            InitializeComponent();
        }

        private void FormVendedoresMain_Load(object sender, EventArgs e)
        {
            gridView.AutoGenerateColumns = false;
            this.RefrescarGrilla(TxFiltro.Text);
        }

        private void RefrescarGrilla(string filtro)
        {
            try
            {
                List<Vendedores> vendedores = vendedoresNegocio.LeerTodosPorFiltro(filtro);
                gridView.DataSource = vendedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            RefrescarGrilla(TxFiltro.Text);
        }

        private void BtMostrarTodo_Click(object sender, EventArgs e)
        {
            RefrescarGrilla(TxFiltro.Text = string.Empty);
        }

        private void BtNuevo_Click(object sender, EventArgs e)
        {
            FormVendedoresAgregar form = new FormVendedoresAgregar();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
                RefrescarGrilla(TxFiltro.Text);
        }

        private void BtModificar_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count == 1)
            {
                int idSeleccionado = ((Vendedores)gridView.SelectedRows[0].DataBoundItem).Id;

                FormVendedoresModificar form = new FormVendedoresModificar
                {
                    Id = idSeleccionado
                };

                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                    RefrescarGrilla(TxFiltro.Text);
            }
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count == 1)
            {
                DialogResult respuesta = MessageBox.Show("Realmente quiere eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    Vendedores registro = (Vendedores)gridView.SelectedRows[0].DataBoundItem;

                    try
                    {
                        vendedoresNegocio.Borrar(registro.Id);

                        MessageBox.Show($"Registro eliminado exitosamente", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        RefrescarGrilla(TxFiltro.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
