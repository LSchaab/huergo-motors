
namespace DesktopUI.FormVentas
{
    partial class FormVentasMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridViewVentasAccesorios = new System.Windows.Forms.DataGridView();
            this.IdVentaAccesorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAccesorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAccesorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.gridViewVentas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeloVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxFiltro = new System.Windows.Forms.TextBox();
            this.BtMostrarTodo = new System.Windows.Forms.Button();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVentasAccesorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 79;
            this.label3.Text = "Venta";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 18);
            this.label2.TabIndex = 78;
            this.label2.Text = "Accesorios Incluidos en la Venta";
            // 
            // gridViewVentasAccesorios
            // 
            this.gridViewVentasAccesorios.AllowUserToAddRows = false;
            this.gridViewVentasAccesorios.AllowUserToDeleteRows = false;
            this.gridViewVentasAccesorios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewVentasAccesorios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewVentasAccesorios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.gridViewVentasAccesorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewVentasAccesorios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVentaAccesorio,
            this.IdAccesorio,
            this.NombreAccesorio,
            this.Precio});
            this.gridViewVentasAccesorios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.gridViewVentasAccesorios.Location = new System.Drawing.Point(12, 471);
            this.gridViewVentasAccesorios.Name = "gridViewVentasAccesorios";
            this.gridViewVentasAccesorios.ReadOnly = true;
            this.gridViewVentasAccesorios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewVentasAccesorios.Size = new System.Drawing.Size(924, 103);
            this.gridViewVentasAccesorios.TabIndex = 77;
            // 
            // IdVentaAccesorio
            // 
            this.IdVentaAccesorio.DataPropertyName = "Id";
            this.IdVentaAccesorio.HeaderText = "Id";
            this.IdVentaAccesorio.Name = "IdVentaAccesorio";
            this.IdVentaAccesorio.ReadOnly = true;
            this.IdVentaAccesorio.Visible = false;
            // 
            // IdAccesorio
            // 
            this.IdAccesorio.DataPropertyName = "IdAccesorio";
            this.IdAccesorio.HeaderText = "IdAccesorio";
            this.IdAccesorio.Name = "IdAccesorio";
            this.IdAccesorio.ReadOnly = true;
            this.IdAccesorio.Visible = false;
            // 
            // NombreAccesorio
            // 
            this.NombreAccesorio.DataPropertyName = "NombreAccesorio";
            this.NombreAccesorio.HeaderText = "Nombre Accesorio";
            this.NombreAccesorio.Name = "NombreAccesorio";
            this.NombreAccesorio.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio Accesorio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 73;
            this.label1.Text = "Buscar por Filtro";
            // 
            // gridViewVentas
            // 
            this.gridViewVentas.AllowUserToAddRows = false;
            this.gridViewVentas.AllowUserToDeleteRows = false;
            this.gridViewVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.gridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Fecha,
            this.IdVehiculo,
            this.ModeloVehiculo,
            this.IdCliente,
            this.NombreCliente,
            this.IdVendedor,
            this.NombreVendedor,
            this.Observaciones,
            this.Total});
            this.gridViewVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.gridViewVentas.Location = new System.Drawing.Point(12, 91);
            this.gridViewVentas.Name = "gridViewVentas";
            this.gridViewVentas.ReadOnly = true;
            this.gridViewVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewVentas.Size = new System.Drawing.Size(924, 354);
            this.gridViewVentas.TabIndex = 71;
            this.gridViewVentas.SelectionChanged += new System.EventHandler(this.GridViewVentas_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // IdVehiculo
            // 
            this.IdVehiculo.DataPropertyName = "IdVehiculo";
            this.IdVehiculo.HeaderText = "IdVehiculo";
            this.IdVehiculo.Name = "IdVehiculo";
            this.IdVehiculo.ReadOnly = true;
            this.IdVehiculo.Visible = false;
            // 
            // ModeloVehiculo
            // 
            this.ModeloVehiculo.DataPropertyName = "ModeloVehiculo";
            this.ModeloVehiculo.HeaderText = "Modelo";
            this.ModeloVehiculo.Name = "ModeloVehiculo";
            this.ModeloVehiculo.ReadOnly = true;
            // 
            // IdCliente
            // 
            this.IdCliente.DataPropertyName = "IdCliente";
            this.IdCliente.HeaderText = "IdCliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Visible = false;
            // 
            // NombreCliente
            // 
            this.NombreCliente.DataPropertyName = "NombreCliente";
            this.NombreCliente.HeaderText = "Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            // 
            // IdVendedor
            // 
            this.IdVendedor.DataPropertyName = "IdVendedor";
            this.IdVendedor.HeaderText = "IdVendedor";
            this.IdVendedor.Name = "IdVendedor";
            this.IdVendedor.ReadOnly = true;
            this.IdVendedor.Visible = false;
            // 
            // NombreVendedor
            // 
            this.NombreVendedor.DataPropertyName = "NombreVendedor";
            this.NombreVendedor.HeaderText = "Vendedor";
            this.NombreVendedor.Name = "NombreVendedor";
            this.NombreVendedor.ReadOnly = true;
            // 
            // Observaciones
            // 
            this.Observaciones.DataPropertyName = "Observaciones";
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // TxFiltro
            // 
            this.TxFiltro.Location = new System.Drawing.Point(15, 32);
            this.TxFiltro.Name = "TxFiltro";
            this.TxFiltro.Size = new System.Drawing.Size(673, 20);
            this.TxFiltro.TabIndex = 80;
            // 
            // BtMostrarTodo
            // 
            this.BtMostrarTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtMostrarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtMostrarTodo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtMostrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtMostrarTodo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMostrarTodo.ForeColor = System.Drawing.Color.White;
            this.BtMostrarTodo.Location = new System.Drawing.Point(836, 21);
            this.BtMostrarTodo.Name = "BtMostrarTodo";
            this.BtMostrarTodo.Size = new System.Drawing.Size(100, 40);
            this.BtMostrarTodo.TabIndex = 82;
            this.BtMostrarTodo.Text = "Mostrar todo";
            this.BtMostrarTodo.UseVisualStyleBackColor = false;
            this.BtMostrarTodo.Click += new System.EventHandler(this.BtMostrarTodo_Click);
            // 
            // BtBuscar
            // 
            this.BtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBuscar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBuscar.ForeColor = System.Drawing.Color.White;
            this.BtBuscar.Location = new System.Drawing.Point(730, 21);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(100, 40);
            this.BtBuscar.TabIndex = 81;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = false;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtNuevo
            // 
            this.BtNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtNuevo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNuevo.ForeColor = System.Drawing.Color.White;
            this.BtNuevo.Location = new System.Drawing.Point(836, 580);
            this.BtNuevo.Name = "BtNuevo";
            this.BtNuevo.Size = new System.Drawing.Size(100, 50);
            this.BtNuevo.TabIndex = 83;
            this.BtNuevo.Text = "Nuevo";
            this.BtNuevo.UseVisualStyleBackColor = false;
            this.BtNuevo.Click += new System.EventHandler(this.BtNuevo_Click);
            // 
            // FormVentasMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(948, 642);
            this.Controls.Add(this.BtNuevo);
            this.Controls.Add(this.BtMostrarTodo);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.TxFiltro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridViewVentasAccesorios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridViewVentas);
            this.MaximumSize = new System.Drawing.Size(964, 681);
            this.MinimumSize = new System.Drawing.Size(964, 681);
            this.Name = "FormVentasMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VENTAS";
            this.Load += new System.EventHandler(this.FormVentasMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVentasAccesorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridViewVentasAccesorios;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVentaAccesorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAccesorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAccesorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridViewVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox TxFiltro;
        private System.Windows.Forms.Button BtMostrarTodo;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtNuevo;
    }
}