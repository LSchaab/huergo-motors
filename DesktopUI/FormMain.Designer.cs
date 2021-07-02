
namespace DesktopUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelHijo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.BtCerrarFormulario = new System.Windows.Forms.Button();
            this.LbTitulo = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtVentas = new System.Windows.Forms.Button();
            this.BtVendedores = new System.Windows.Forms.Button();
            this.BtVehiculos = new System.Windows.Forms.Button();
            this.BtClientes = new System.Windows.Forms.Button();
            this.BtAccessorios = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.LbLogo = new System.Windows.Forms.Label();
            this.panelHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHijo
            // 
            this.panelHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelHijo.Controls.Add(this.pictureBox1);
            this.panelHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHijo.Location = new System.Drawing.Point(220, 80);
            this.panelHijo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panelHijo.Name = "panelHijo";
            this.panelHijo.Size = new System.Drawing.Size(964, 681);
            this.panelHijo.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(238, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelTitleBar.Controls.Add(this.BtCerrarFormulario);
            this.panelTitleBar.Controls.Add(this.LbTitulo);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(964, 80);
            this.panelTitleBar.TabIndex = 4;
            // 
            // BtCerrarFormulario
            // 
            this.BtCerrarFormulario.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtCerrarFormulario.FlatAppearance.BorderSize = 0;
            this.BtCerrarFormulario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCerrarFormulario.Image = ((System.Drawing.Image)(resources.GetObject("BtCerrarFormulario.Image")));
            this.BtCerrarFormulario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtCerrarFormulario.Location = new System.Drawing.Point(0, 0);
            this.BtCerrarFormulario.Name = "BtCerrarFormulario";
            this.BtCerrarFormulario.Size = new System.Drawing.Size(90, 80);
            this.BtCerrarFormulario.TabIndex = 0;
            this.BtCerrarFormulario.UseVisualStyleBackColor = true;
            this.BtCerrarFormulario.Click += new System.EventHandler(this.BtCerrarFormulario_Click);
            // 
            // LbTitulo
            // 
            this.LbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbTitulo.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold);
            this.LbTitulo.ForeColor = System.Drawing.Color.White;
            this.LbTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbTitulo.Location = new System.Drawing.Point(0, 0);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(964, 80);
            this.LbTitulo.TabIndex = 0;
            this.LbTitulo.Text = "HOME";
            this.LbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.BtVentas);
            this.panelMenu.Controls.Add(this.BtVendedores);
            this.panelMenu.Controls.Add(this.BtVehiculos);
            this.panelMenu.Controls.Add(this.BtClientes);
            this.panelMenu.Controls.Add(this.BtAccessorios);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 761);
            this.panelMenu.TabIndex = 3;
            // 
            // BtVentas
            // 
            this.BtVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtVentas.FlatAppearance.BorderSize = 0;
            this.BtVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.BtVentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtVentas.Image = ((System.Drawing.Image)(resources.GetObject("BtVentas.Image")));
            this.BtVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtVentas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtVentas.Location = new System.Drawing.Point(0, 280);
            this.BtVentas.Name = "BtVentas";
            this.BtVentas.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.BtVentas.Size = new System.Drawing.Size(220, 50);
            this.BtVentas.TabIndex = 5;
            this.BtVentas.Text = "Ventas";
            this.BtVentas.UseVisualStyleBackColor = true;
            this.BtVentas.Click += new System.EventHandler(this.BtVentas_Click);
            // 
            // BtVendedores
            // 
            this.BtVendedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtVendedores.FlatAppearance.BorderSize = 0;
            this.BtVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtVendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.BtVendedores.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtVendedores.Image = ((System.Drawing.Image)(resources.GetObject("BtVendedores.Image")));
            this.BtVendedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtVendedores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtVendedores.Location = new System.Drawing.Point(0, 230);
            this.BtVendedores.Name = "BtVendedores";
            this.BtVendedores.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.BtVendedores.Size = new System.Drawing.Size(220, 50);
            this.BtVendedores.TabIndex = 4;
            this.BtVendedores.Text = "Vendedores";
            this.BtVendedores.UseVisualStyleBackColor = true;
            this.BtVendedores.Click += new System.EventHandler(this.BtVendedores_Click);
            // 
            // BtVehiculos
            // 
            this.BtVehiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtVehiculos.FlatAppearance.BorderSize = 0;
            this.BtVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.BtVehiculos.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtVehiculos.Image = ((System.Drawing.Image)(resources.GetObject("BtVehiculos.Image")));
            this.BtVehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtVehiculos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtVehiculos.Location = new System.Drawing.Point(0, 180);
            this.BtVehiculos.Name = "BtVehiculos";
            this.BtVehiculos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.BtVehiculos.Size = new System.Drawing.Size(220, 50);
            this.BtVehiculos.TabIndex = 3;
            this.BtVehiculos.Text = "Vehiculos";
            this.BtVehiculos.UseVisualStyleBackColor = true;
            this.BtVehiculos.Click += new System.EventHandler(this.BtVehiculos_Click);
            // 
            // BtClientes
            // 
            this.BtClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtClientes.FlatAppearance.BorderSize = 0;
            this.BtClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.BtClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtClientes.Image = ((System.Drawing.Image)(resources.GetObject("BtClientes.Image")));
            this.BtClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtClientes.Location = new System.Drawing.Point(0, 130);
            this.BtClientes.Name = "BtClientes";
            this.BtClientes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.BtClientes.Size = new System.Drawing.Size(220, 50);
            this.BtClientes.TabIndex = 2;
            this.BtClientes.Text = "Clientes";
            this.BtClientes.UseVisualStyleBackColor = true;
            this.BtClientes.Click += new System.EventHandler(this.BtClientes_Click);
            // 
            // BtAccessorios
            // 
            this.BtAccessorios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtAccessorios.FlatAppearance.BorderSize = 0;
            this.BtAccessorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAccessorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.BtAccessorios.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtAccessorios.Image = ((System.Drawing.Image)(resources.GetObject("BtAccessorios.Image")));
            this.BtAccessorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAccessorios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtAccessorios.Location = new System.Drawing.Point(0, 80);
            this.BtAccessorios.Name = "BtAccessorios";
            this.BtAccessorios.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.BtAccessorios.Size = new System.Drawing.Size(220, 50);
            this.BtAccessorios.TabIndex = 0;
            this.BtAccessorios.Text = "Accesorios";
            this.BtAccessorios.UseVisualStyleBackColor = true;
            this.BtAccessorios.Click += new System.EventHandler(this.BtAccessorios_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.LbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // LbLogo
            // 
            this.LbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbLogo.AutoSize = true;
            this.LbLogo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.LbLogo.ForeColor = System.Drawing.Color.LightGray;
            this.LbLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbLogo.Location = new System.Drawing.Point(29, 27);
            this.LbLogo.Name = "LbLogo";
            this.LbLogo.Size = new System.Drawing.Size(161, 30);
            this.LbLogo.TabIndex = 1;
            this.LbLogo.Text = "Huergo Motors";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panelHijo);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Huergo Motors";
            this.panelHijo.ResumeLayout(false);
            this.panelHijo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHijo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button BtCerrarFormulario;
        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button BtVentas;
        private System.Windows.Forms.Button BtVendedores;
        private System.Windows.Forms.Button BtVehiculos;
        private System.Windows.Forms.Button BtClientes;
        private System.Windows.Forms.Button BtAccessorios;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label LbLogo;
    }
}

