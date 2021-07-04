using System;
using DesktopUI;
using System.Windows.Forms;
using DesktopUI.FormClientes;
using DesktopUI.FormVentas;
using DesktopUI.FormVehiculos;
using DesktopUI.FormAccesorios;
using DesktopUI.FormVendedores;

namespace DesktopUI
{
    public partial class FormMain : Form
    {
        private Form formActivo = null;
        
        public FormMain()
        {
            InitializeComponent();
            this.Text = string.Empty;
            BtCerrarFormulario.Visible = false;
            // No permite que la app se superponga a la taskbar del os
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        /// <summary>
        /// Abre un formulario dentro de su panel hijo, actuando como mdi container
        /// </summary>
        /// <param name="formulario"></param>
        private void AbrirFormulario(Form formulario)
        {
            if (UiHelper.EstaAbierto(formulario))
            {
                return;
            }

            // Cierra cualquier formulario abierto
            if (formActivo != null)
            {
                formActivo.Close();
            }

            BtCerrarFormulario.Visible = true;
            formActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            this.panelHijo.Controls.Add(formulario);
            formulario.BringToFront();
            formulario.Show();
            LbTitulo.Text = formulario.Text;
        }


        /*
         * Eventos de click
         */
        private void BtAccessorios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormAccesoriosMain());
        }

        private void BtClientes_Click(object sender, EventArgs e)
        {
            FormClientesMain form = new FormClientesMain();
            form.EsconderBtSeleccionar();
            AbrirFormulario(form);
        }

        private void BtVehiculos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormVehiculosMain());
        }

        private void BtVendedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormVendedoresMain());
        }

        private void BtVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormVentasMain());
        }

        private void BtCerrarFormulario_Click(object sender, EventArgs e)
        {
            if (formActivo != null)
            {
                formActivo.Close();
                LbTitulo.Text = "HOME";
                BtCerrarFormulario.Visible = false;
            }
        }
    }
}
