namespace Mercadito
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInventario
            // 
            this.btnInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInventario.BackColor = System.Drawing.Color.Azure;
            this.btnInventario.Location = new System.Drawing.Point(114, 423);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(116, 46);
            this.btnInventario.TabIndex = 0;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProveedor.BackColor = System.Drawing.Color.Azure;
            this.btnProveedor.Location = new System.Drawing.Point(463, 423);
            this.btnProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(116, 46);
            this.btnProveedor.TabIndex = 1;
            this.btnProveedor.Text = "Proveedores";
            this.btnProveedor.UseVisualStyleBackColor = false;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVentas.BackColor = System.Drawing.Color.Azure;
            this.btnVentas.Location = new System.Drawing.Point(785, 423);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(116, 46);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(776, 675);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(239, 50);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar Programa";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1051, 731);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.btnInventario);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1069, 778);
            this.MinimumSize = new System.Drawing.Size(1069, 778);
            this.Name = "FrmMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "FrmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCerrar;
    }
}

