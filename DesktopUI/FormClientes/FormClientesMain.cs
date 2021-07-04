using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;
using Negocio;

namespace DesktopUI.FormClientes
{
    public partial class FormClientesMain : Form
    {
        public Clientes ClienteSeleccionado { get; set; }

        private readonly ClientesNegocio clientesNegocio = new ClientesNegocio();

        public FormClientesMain()
        {
            InitializeComponent();
        }

        private void FormClientesMain_Load(object sender, EventArgs e)
        {
            gridView.AutoGenerateColumns = false;
            this.RefrescarGrilla(TxFiltro.Text);
        }

        public void EsconderBtSeleccionar()
        {
            BtSeleccionar.Visible = false;
        }

        public void MostrarBtSeleccionar()
        {
            BtSeleccionar.Visible = true;
        }

        private void RefrescarGrilla(string filtro)
        {
            try
            {
                List<Clientes> clientes = clientesNegocio.LeerTodosPorFiltro(filtro);
                gridView.DataSource = clientes;
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
            FormClientesAgregar form = new FormClientesAgregar();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
                RefrescarGrilla(TxFiltro.Text);
        }

        private void BtModificar_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count == 1)
            {
                int idSeleccionado = ((Clientes)gridView.SelectedRows[0].DataBoundItem).Id;

                FormClientesModificar form = new FormClientesModificar
                {
                    IdCliente = idSeleccionado
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
                    Clientes registro = (Clientes)gridView.SelectedRows[0].DataBoundItem;

                    try
                    {
                        clientesNegocio.Borrar(registro.Id);

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

        private void BtSeleccionar_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count == 1)
            {
                Clientes cliente = new Clientes
                {
                    Id = (int)gridView.SelectedRows[0].Cells["Id"].Value,
                    Nombre = (string)gridView.SelectedRows[0].Cells["Nombre"].Value,
                    Direccion = (string)gridView.SelectedRows[0].Cells["Direccion"].Value,
                    Telefono = (string)gridView.SelectedRows[0].Cells["Telefono"].Value,
                    Email = (string)gridView.SelectedRows[0].Cells["Email"].Value
                };

                ClienteSeleccionado = cliente;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
