
namespace DesktopUI.FormVentas
{
    partial class FormVentasAgregar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.BtAgregarAccesorio = new System.Windows.Forms.Button();
            this.BtConfirmar = new System.Windows.Forms.Button();
            this.CbAccesorio = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LbPrecioTotal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TxObservaciones = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtSeleccionarCliente = new System.Windows.Forms.Button();
            this.LbNombreCliente = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LbEmailCliente = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LbTelefonoCliente = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LbTipoVehiculo = new System.Windows.Forms.Label();
            this.CbModeloVehiculo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LbCostoVehiculo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.CbVendedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbSucursalVendedor = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 57;
            this.label6.Text = "Accesorios";
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Tipo,
            this.Precio,
            this.Eliminar});
            this.gridView.Location = new System.Drawing.Point(14, 255);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(815, 165);
            this.gridView.TabIndex = 56;
            this.gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellContentClick);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtCancelar.FlatAppearance.BorderSize = 0;
            this.BtCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCancelar.ForeColor = System.Drawing.Color.White;
            this.BtCancelar.Location = new System.Drawing.Point(621, 744);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(105, 40);
            this.BtCancelar.TabIndex = 55;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = false;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // BtAgregarAccesorio
            // 
            this.BtAgregarAccesorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtAgregarAccesorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtAgregarAccesorio.FlatAppearance.BorderSize = 0;
            this.BtAgregarAccesorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAgregarAccesorio.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAgregarAccesorio.ForeColor = System.Drawing.Color.White;
            this.BtAgregarAccesorio.Location = new System.Drawing.Point(648, 221);
            this.BtAgregarAccesorio.Name = "BtAgregarAccesorio";
            this.BtAgregarAccesorio.Size = new System.Drawing.Size(103, 30);
            this.BtAgregarAccesorio.TabIndex = 47;
            this.BtAgregarAccesorio.Text = "Agregar";
            this.BtAgregarAccesorio.UseVisualStyleBackColor = false;
            this.BtAgregarAccesorio.Click += new System.EventHandler(this.BtAgregarAccesorio_Click);
            // 
            // BtConfirmar
            // 
            this.BtConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtConfirmar.FlatAppearance.BorderSize = 0;
            this.BtConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtConfirmar.ForeColor = System.Drawing.Color.White;
            this.BtConfirmar.Location = new System.Drawing.Point(732, 744);
            this.BtConfirmar.Name = "BtConfirmar";
            this.BtConfirmar.Size = new System.Drawing.Size(105, 40);
            this.BtConfirmar.TabIndex = 54;
            this.BtConfirmar.Text = "Confirmar";
            this.BtConfirmar.UseVisualStyleBackColor = false;
            this.BtConfirmar.Click += new System.EventHandler(this.BtConfirmar_Click);
            // 
            // CbAccesorio
            // 
            this.CbAccesorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbAccesorio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CbAccesorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAccesorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbAccesorio.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbAccesorio.FormattingEnabled = true;
            this.CbAccesorio.Location = new System.Drawing.Point(188, 227);
            this.CbAccesorio.Name = "CbAccesorio";
            this.CbAccesorio.Size = new System.Drawing.Size(454, 22);
            this.CbAccesorio.TabIndex = 46;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkGray;
            this.label15.Location = new System.Drawing.Point(5, 719);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 25);
            this.label15.TabIndex = 53;
            this.label15.Text = "$";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(116, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 45;
            this.label13.Text = "Nombre";
            // 
            // LbPrecioTotal
            // 
            this.LbPrecioTotal.AutoSize = true;
            this.LbPrecioTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPrecioTotal.ForeColor = System.Drawing.Color.DarkGray;
            this.LbPrecioTotal.Location = new System.Drawing.Point(24, 719);
            this.LbPrecioTotal.Name = "LbPrecioTotal";
            this.LbPrecioTotal.Size = new System.Drawing.Size(37, 25);
            this.LbPrecioTotal.TabIndex = 52;
            this.LbPrecioTotal.Text = ". . .";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(4, 680);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(267, 25);
            this.label14.TabIndex = 44;
            this.label14.Text = "Total ( Vehiculo + Accesorios )";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.Controls.Add(this.TxObservaciones);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(10, 438);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(827, 206);
            this.groupBox5.TabIndex = 51;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Observaciones";
            // 
            // TxObservaciones
            // 
            this.TxObservaciones.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TxObservaciones.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxObservaciones.Location = new System.Drawing.Point(6, 29);
            this.TxObservaciones.Multiline = true;
            this.TxObservaciones.Name = "TxObservaciones";
            this.TxObservaciones.Size = new System.Drawing.Size(815, 171);
            this.TxObservaciones.TabIndex = 34;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.BtSeleccionarCliente);
            this.groupBox3.Controls.Add(this.LbNombreCliente);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.LbEmailCliente);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.LbTelefonoCliente);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(565, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 177);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // BtSeleccionarCliente
            // 
            this.BtSeleccionarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtSeleccionarCliente.FlatAppearance.BorderSize = 0;
            this.BtSeleccionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSeleccionarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSeleccionarCliente.Location = new System.Drawing.Point(83, 33);
            this.BtSeleccionarCliente.Name = "BtSeleccionarCliente";
            this.BtSeleccionarCliente.Size = new System.Drawing.Size(103, 30);
            this.BtSeleccionarCliente.TabIndex = 21;
            this.BtSeleccionarCliente.Text = "Seleccionar";
            this.BtSeleccionarCliente.UseVisualStyleBackColor = false;
            this.BtSeleccionarCliente.Click += new System.EventHandler(this.BtSeleccionarCliente_Click);
            // 
            // LbNombreCliente
            // 
            this.LbNombreCliente.AutoSize = true;
            this.LbNombreCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNombreCliente.ForeColor = System.Drawing.Color.DarkGray;
            this.LbNombreCliente.Location = new System.Drawing.Point(87, 83);
            this.LbNombreCliente.Name = "LbNombreCliente";
            this.LbNombreCliente.Size = new System.Drawing.Size(22, 15);
            this.LbNombreCliente.TabIndex = 20;
            this.LbNombreCliente.Text = ". . .";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(14, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Nombre";
            // 
            // LbEmailCliente
            // 
            this.LbEmailCliente.AutoSize = true;
            this.LbEmailCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LbEmailCliente.ForeColor = System.Drawing.Color.DarkGray;
            this.LbEmailCliente.Location = new System.Drawing.Point(86, 115);
            this.LbEmailCliente.Name = "LbEmailCliente";
            this.LbEmailCliente.Size = new System.Drawing.Size(22, 15);
            this.LbEmailCliente.TabIndex = 18;
            this.LbEmailCliente.Text = ". . .";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Email";
            // 
            // LbTelefonoCliente
            // 
            this.LbTelefonoCliente.AutoSize = true;
            this.LbTelefonoCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LbTelefonoCliente.ForeColor = System.Drawing.Color.DarkGray;
            this.LbTelefonoCliente.Location = new System.Drawing.Point(86, 147);
            this.LbTelefonoCliente.Name = "LbTelefonoCliente";
            this.LbTelefonoCliente.Size = new System.Drawing.Size(22, 15);
            this.LbTelefonoCliente.TabIndex = 16;
            this.LbTelefonoCliente.Text = ". . .";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.LbTipoVehiculo);
            this.groupBox2.Controls.Add(this.CbModeloVehiculo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.LbCostoVehiculo);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(287, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 177);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehiculo";
            // 
            // LbTipoVehiculo
            // 
            this.LbTipoVehiculo.AutoSize = true;
            this.LbTipoVehiculo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTipoVehiculo.ForeColor = System.Drawing.Color.DarkGray;
            this.LbTipoVehiculo.Location = new System.Drawing.Point(92, 78);
            this.LbTipoVehiculo.Name = "LbTipoVehiculo";
            this.LbTipoVehiculo.Size = new System.Drawing.Size(29, 20);
            this.LbTipoVehiculo.TabIndex = 18;
            this.LbTipoVehiculo.Text = ". . .";
            // 
            // CbModeloVehiculo
            // 
            this.CbModeloVehiculo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CbModeloVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbModeloVehiculo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbModeloVehiculo.FormattingEnabled = true;
            this.CbModeloVehiculo.Location = new System.Drawing.Point(96, 36);
            this.CbModeloVehiculo.Name = "CbModeloVehiculo";
            this.CbModeloVehiculo.Size = new System.Drawing.Size(139, 22);
            this.CbModeloVehiculo.TabIndex = 17;
            this.CbModeloVehiculo.SelectedIndexChanged += new System.EventHandler(this.CbModeloVehiculo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Precio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(14, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tipo";
            // 
            // LbCostoVehiculo
            // 
            this.LbCostoVehiculo.AutoSize = true;
            this.LbCostoVehiculo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCostoVehiculo.ForeColor = System.Drawing.Color.DarkGray;
            this.LbCostoVehiculo.Location = new System.Drawing.Point(92, 124);
            this.LbCostoVehiculo.Name = "LbCostoVehiculo";
            this.LbCostoVehiculo.Size = new System.Drawing.Size(29, 20);
            this.LbCostoVehiculo.TabIndex = 16;
            this.LbCostoVehiculo.Text = ". . .";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerFecha);
            this.groupBox1.Controls.Add(this.CbVendedor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LbSucursalVendedor);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 177);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fecha";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFecha.CustomFormat = "yyyy/dd/MM";
            this.dateTimePickerFecha.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(96, 36);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(139, 22);
            this.dateTimePickerFecha.TabIndex = 12;
            // 
            // CbVendedor
            // 
            this.CbVendedor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbVendedor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbVendedor.FormattingEnabled = true;
            this.CbVendedor.Location = new System.Drawing.Point(96, 80);
            this.CbVendedor.Name = "CbVendedor";
            this.CbVendedor.Size = new System.Drawing.Size(139, 22);
            this.CbVendedor.TabIndex = 14;
            this.CbVendedor.SelectedIndexChanged += new System.EventHandler(this.CbVendedor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sucursal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Vendedor";
            // 
            // LbSucursalVendedor
            // 
            this.LbSucursalVendedor.AutoSize = true;
            this.LbSucursalVendedor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSucursalVendedor.ForeColor = System.Drawing.Color.DarkGray;
            this.LbSucursalVendedor.Location = new System.Drawing.Point(92, 124);
            this.LbSucursalVendedor.Name = "LbSucursalVendedor";
            this.LbSucursalVendedor.Size = new System.Drawing.Size(29, 20);
            this.LbSucursalVendedor.TabIndex = 16;
            this.LbSucursalVendedor.Text = ". . .";
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
            // Eliminar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "X";
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // FormVentasAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(849, 796);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtAgregarAccesorio);
            this.Controls.Add(this.BtConfirmar);
            this.Controls.Add(this.CbAccesorio);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.LbPrecioTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(865, 835);
            this.MinimumSize = new System.Drawing.Size(865, 835);
            this.Name = "FormVentasAgregar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva Venta";
            this.Load += new System.EventHandler(this.FormVentasAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button BtAgregarAccesorio;
        private System.Windows.Forms.Button BtConfirmar;
        private System.Windows.Forms.ComboBox CbAccesorio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LbPrecioTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TxObservaciones;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtSeleccionarCliente;
        private System.Windows.Forms.Label LbNombreCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LbEmailCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LbTelefonoCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LbTipoVehiculo;
        private System.Windows.Forms.ComboBox CbModeloVehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LbCostoVehiculo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.ComboBox CbVendedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbSucursalVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}