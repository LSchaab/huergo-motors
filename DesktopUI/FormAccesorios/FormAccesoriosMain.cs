using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;
using Negocio;

namespace DesktopUI.FormAccesorios
{
    public partial class FormAccesoriosMain : Form
    {
        private readonly AccesoriosNegocio accesoriosNegocio = new AccesoriosNegocio();

        public FormAccesoriosMain()
        {
            InitializeComponent();
        }

        private void FormAccesoriosMain_Load(object sender, EventArgs e)
        {
            gridView.AutoGenerateColumns = false;
            RefrescarGrilla(TxFiltro.Text);
        }

        private void RefrescarGrilla(string filtro)
        {
            try
            {
                List<Accesorios> accesorios = accesoriosNegocio.LeerTodosPorFiltro(filtro);
                gridView.DataSource = accesorios;
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
            FormAccesoriosAgregar form = new FormAccesoriosAgregar();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
                RefrescarGrilla(TxFiltro.Text);
        }

        private void BtModificar_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count == 1)
            {
                int id = ((Accesorios)gridView.SelectedRows[0].DataBoundItem).Id;

                FormAccesoriosModificar form = new FormAccesoriosModificar
                {
                    Id = id,
                };

                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                {
                    RefrescarGrilla(TxFiltro.Text);
                }
            }
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count == 1)
            {
                DialogResult respuesta = MessageBox.Show("Realmente quiere eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        int id = ((Accesorios)gridView.SelectedRows[0].DataBoundItem).Id;

                        accesoriosNegocio.Borrar(id);

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
