
namespace DesktopUI.FormClientes
{
    partial class FormClientesMain
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
            this.BtSeleccionar = new System.Windows.Forms.Button();
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
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BtSeleccionar
            // 
            this.BtSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSeleccionar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSeleccionar.ForeColor = System.Drawing.Color.White;
            this.BtSeleccionar.Location = new System.Drawing.Point(618, 584);
            this.BtSeleccionar.Name = "BtSeleccionar";
            this.BtSeleccionar.Size = new System.Drawing.Size(106, 50);
            this.BtSeleccionar.TabIndex = 70;
            this.BtSeleccionar.Text = "Seleccionar";
            this.BtSeleccionar.UseVisualStyleBackColor = false;
            this.BtSeleccionar.Click += new System.EventHandler(this.BtSeleccionar_Click);
            // 
            // BtEliminar
            // 
            this.BtEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEliminar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEliminar.ForeColor = System.Drawing.Color.White;
            this.BtEliminar.Location = new System.Drawing.Point(15, 584);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(100, 50);
            this.BtEliminar.TabIndex = 69;
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
            this.BtNuevo.Location = new System.Drawing.Point(836, 584);
            this.BtNuevo.Name = "BtNuevo";
            this.BtNuevo.Size = new System.Drawing.Size(100, 50);
            this.BtNuevo.TabIndex = 68;
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
            this.BtModificar.Location = new System.Drawing.Point(730, 584);
            this.BtModificar.Name = "BtModificar";
            this.BtModificar.Size = new System.Drawing.Size(100, 50);
            this.BtModificar.TabIndex = 67;
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
            this.BtMostrarTodo.Location = new System.Drawing.Point(836, 19);
            this.BtMostrarTodo.Name = "BtMostrarTodo";
            this.BtMostrarTodo.Size = new System.Drawing.Size(100, 40);
            this.BtMostrarTodo.TabIndex = 66;
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
            this.BtBuscar.Location = new System.Drawing.Point(730, 19);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(100, 40);
            this.BtBuscar.TabIndex = 65;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = false;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 64;
            this.label1.Text = "Buscar por Filtro";
            // 
            // TxFiltro
            // 
            this.TxFiltro.Location = new System.Drawing.Point(12, 29);
            this.TxFiltro.Name = "TxFiltro";
            this.TxFiltro.Size = new System.Drawing.Size(673, 20);
            this.TxFiltro.TabIndex = 63;
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
            this.Direccion,
            this.Telefono,
            this.Email});
            this.gridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.gridView.Location = new System.Drawing.Point(12, 65);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(924, 513);
            this.gridView.TabIndex = 62;
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
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // FormClientesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(948, 642);
            this.Controls.Add(this.BtSeleccionar);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.BtNuevo);
            this.Controls.Add(this.BtModificar);
            this.Controls.Add(this.BtMostrarTodo);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxFiltro);
            this.Controls.Add(this.gridView);
            this.MaximumSize = new System.Drawing.Size(964, 681);
            this.MinimumSize = new System.Drawing.Size(964, 681);
            this.Name = "FormClientesMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CLIENTES - CONSULTA";
            this.Load += new System.EventHandler(this.FormClientesMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtSeleccionar;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}