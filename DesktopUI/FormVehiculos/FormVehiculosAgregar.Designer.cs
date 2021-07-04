
namespace DesktopUI.FormVehiculos
{
    partial class FormVehiculosAgregar
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
            this.label5 = new System.Windows.Forms.Label();
            this.BtConfirmar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxPrecio = new System.Windows.Forms.TextBox();
            this.TxModelo = new System.Windows.Forms.TextBox();
            this.TxTipo = new System.Windows.Forms.TextBox();
            this.NumericStock = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumericStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 14);
            this.label5.TabIndex = 109;
            this.label5.Text = "Stock";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtConfirmar
            // 
            this.BtConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtConfirmar.FlatAppearance.BorderSize = 0;
            this.BtConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtConfirmar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtConfirmar.ForeColor = System.Drawing.Color.White;
            this.BtConfirmar.Location = new System.Drawing.Point(249, 114);
            this.BtConfirmar.Name = "BtConfirmar";
            this.BtConfirmar.Size = new System.Drawing.Size(85, 25);
            this.BtConfirmar.TabIndex = 108;
            this.BtConfirmar.Text = "Confirmar";
            this.BtConfirmar.UseVisualStyleBackColor = false;
            this.BtConfirmar.Click += new System.EventHandler(this.BtConfirmar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtCancelar.FlatAppearance.BorderSize = 0;
            this.BtCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCancelar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCancelar.ForeColor = System.Drawing.Color.White;
            this.BtCancelar.Location = new System.Drawing.Point(158, 114);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(85, 25);
            this.BtCancelar.TabIndex = 107;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = false;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 106;
            this.label3.Text = "Precio";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 105;
            this.label2.Text = "Modelo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 104;
            this.label1.Text = "Tipo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxPrecio
            // 
            this.TxPrecio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxPrecio.Location = new System.Drawing.Point(77, 61);
            this.TxPrecio.Name = "TxPrecio";
            this.TxPrecio.Size = new System.Drawing.Size(253, 20);
            this.TxPrecio.TabIndex = 103;
            // 
            // TxModelo
            // 
            this.TxModelo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxModelo.Location = new System.Drawing.Point(77, 35);
            this.TxModelo.Name = "TxModelo";
            this.TxModelo.Size = new System.Drawing.Size(253, 20);
            this.TxModelo.TabIndex = 102;
            // 
            // TxTipo
            // 
            this.TxTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxTipo.Location = new System.Drawing.Point(77, 9);
            this.TxTipo.Name = "TxTipo";
            this.TxTipo.Size = new System.Drawing.Size(253, 20);
            this.TxTipo.TabIndex = 101;
            // 
            // NumericStock
            // 
            this.NumericStock.Location = new System.Drawing.Point(77, 86);
            this.NumericStock.Name = "NumericStock";
            this.NumericStock.Size = new System.Drawing.Size(253, 20);
            this.NumericStock.TabIndex = 111;
            // 
            // FormVehiculosAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(346, 151);
            this.Controls.Add(this.NumericStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtConfirmar);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxPrecio);
            this.Controls.Add(this.TxModelo);
            this.Controls.Add(this.TxTipo);
            this.MaximumSize = new System.Drawing.Size(362, 190);
            this.MinimumSize = new System.Drawing.Size(362, 190);
            this.Name = "FormVehiculosAgregar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Vehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.NumericStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtConfirmar;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxPrecio;
        private System.Windows.Forms.TextBox TxModelo;
        private System.Windows.Forms.TextBox TxTipo;
        private System.Windows.Forms.NumericUpDown NumericStock;
    }
}