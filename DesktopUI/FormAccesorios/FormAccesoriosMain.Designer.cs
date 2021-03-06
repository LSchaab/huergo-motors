
namespace DesktopUI.FormAccesorios
{
    partial class FormAccesoriosMain
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
            this.BtEliminar = new System.Windows.Forms.Button();
            this.BtNuevo = new System.Windows.Forms.Button();
            this.BtModificar = new System.Windows.Forms.Button();
            this.BtMostrarTodo = new System.Windows.Forms.Button();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxFiltro = new System.Windows.Forms.TextBox();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeloVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BtEliminar
            // 
            this.BtEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEliminar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEliminar.ForeColor = System.Drawing.Color.White;
            this.BtEliminar.Location = new System.Drawing.Point(15, 585);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(100, 50);
            this.BtEliminar.TabIndex = 78;
            this.BtEliminar.Text = "Eliminar";
            this.BtEliminar.UseVisualStyleBackColor = false;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // BtNuevo
            // 
            this.BtNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtNuevo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNuevo.ForeColor = System.Drawing.Color.White;
            this.BtNuevo.Location = new System.Drawing.Point(836, 585);
            this.BtNuevo.Name = "BtNuevo";
            this.BtNuevo.Size = new System.Drawing.Size(100, 50);
            this.BtNuevo.TabIndex = 77;
            this.BtNuevo.Text = "Nuevo";
            this.BtNuevo.UseVisualStyleBackColor = false;
            this.BtNuevo.Click += new System.EventHandler(this.BtNuevo_Click);
            // 
            // BtModificar
            // 
            this.BtModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtModificar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtModificar.ForeColor = System.Drawing.Color.White;
            this.BtModificar.Location = new System.Drawing.Point(730, 585);
            this.BtModificar.Name = "BtModificar";
            this.BtModificar.Size = new System.Drawing.Size(100, 50);
            this.BtModificar.TabIndex = 76;
            this.BtModificar.Text = "Modificar";
            this.BtModificar.UseVisualStyleBackColor = false;
            this.BtModificar.Click += new System.EventHandler(this.BtModificar_Click);
            // 
            // BtMostrarTodo
            // 
            this.BtMostrarTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtMostrarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtMostrarTodo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtMostrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtMostrarTodo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMostrarTodo.ForeColor = System.Drawing.Color.White;
            this.BtMostrarTodo.Location = new System.Drawing.Point(836, 20);
            this.BtMostrarTodo.Name = "BtMostrarTodo";
            this.BtMostrarTodo.Size = new System.Drawing.Size(100, 40);
            this.BtMostrarTodo.TabIndex = 75;
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
            this.BtBuscar.Location = new System.Drawing.Point(730, 20);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(100, 40);
            this.BtBuscar.TabIndex = 74;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = false;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
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
            // TxFiltro
            // 
            this.TxFiltro.Location = new System.Drawing.Point(12, 30);
            this.TxFiltro.Name = "TxFiltro";
            this.TxFiltro.Size = new System.Drawing.Size(673, 20);
            this.TxFiltro.TabIndex = 72;
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Tipo,
            this.Precio,
            this.ModeloVehiculo,
            this.IdVehiculo});
            this.gridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.gridView.Location = new System.Drawing.Point(12, 66);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(924, 513);
            this.gridView.TabIndex = 80;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // ModeloVehiculo
            // 
            this.ModeloVehiculo.DataPropertyName = "ModeloVehiculo";
            this.ModeloVehiculo.HeaderText = "Vehiculo";
            this.ModeloVehiculo.Name = "ModeloVehiculo";
            this.ModeloVehiculo.ReadOnly = true;
            // 
            // IdVehiculo
            // 
            this.IdVehiculo.DataPropertyName = "IdVehiculo";
            this.IdVehiculo.HeaderText = "IdVehiculo";
            this.IdVehiculo.Name = "IdVehiculo";
            this.IdVehiculo.ReadOnly = true;
            this.IdVehiculo.Visible = false;
            // 
            // FormAccesoriosMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(948, 642);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.BtNuevo);
            this.Controls.Add(this.BtModificar);
            this.Controls.Add(this.BtMostrarTodo);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxFiltro);
            this.MaximumSize = new System.Drawing.Size(964, 681);
            this.MinimumSize = new System.Drawing.Size(964, 681);
            this.Name = "FormAccesoriosMain";
            this.ShowIcon = false;
            this.Text = "ACCESORIOS - CONSULTA";
            this.Load += new System.EventHandler(this.FormAccesoriosMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Button BtNuevo;
        private System.Windows.Forms.Button BtModificar;
        private System.Windows.Forms.Button BtMostrarTodo;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxFiltro;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVehiculo;
    }
}