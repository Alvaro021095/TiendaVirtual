namespace CarritoConsumidor.vista
{
    partial class Compra
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombrePro = new System.Windows.Forms.TextBox();
            this.btnBuscarPro = new System.Windows.Forms.Button();
            this.btnAgregarCarri = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.txtTotalFac = new System.Windows.Forms.TextBox();
            this.ProductosBuscados = new System.Windows.Forms.DataGridView();
            this.Carrito = new System.Windows.Forms.DataGridView();
            this.btnComprar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosBuscados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carrito)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Producto:";
            // 
            // txtNombrePro
            // 
            this.txtNombrePro.Location = new System.Drawing.Point(333, 31);
            this.txtNombrePro.Name = "txtNombrePro";
            this.txtNombrePro.Size = new System.Drawing.Size(189, 20);
            this.txtNombrePro.TabIndex = 1;
            // 
            // btnBuscarPro
            // 
            this.btnBuscarPro.Location = new System.Drawing.Point(545, 31);
            this.btnBuscarPro.Name = "btnBuscarPro";
            this.btnBuscarPro.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPro.TabIndex = 2;
            this.btnBuscarPro.Text = "Buscar ";
            this.btnBuscarPro.UseVisualStyleBackColor = true;
            this.btnBuscarPro.Click += new System.EventHandler(this.btnBuscarPro_Click);
            // 
            // btnAgregarCarri
            // 
            this.btnAgregarCarri.Location = new System.Drawing.Point(355, 127);
            this.btnAgregarCarri.Name = "btnAgregarCarri";
            this.btnAgregarCarri.Size = new System.Drawing.Size(75, 40);
            this.btnAgregarCarri.TabIndex = 3;
            this.btnAgregarCarri.Text = "Agregar al Carrito";
            this.btnAgregarCarri.UseVisualStyleBackColor = true;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(315, 212);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(34, 13);
            this.Total.TabIndex = 4;
            this.Total.Text = "Total:";
            // 
            // txtTotalFac
            // 
            this.txtTotalFac.Location = new System.Drawing.Point(355, 209);
            this.txtTotalFac.Name = "txtTotalFac";
            this.txtTotalFac.Size = new System.Drawing.Size(94, 20);
            this.txtTotalFac.TabIndex = 5;
            // 
            // ProductosBuscados
            // 
            this.ProductosBuscados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosBuscados.Location = new System.Drawing.Point(24, 105);
            this.ProductosBuscados.Name = "ProductosBuscados";
            this.ProductosBuscados.Size = new System.Drawing.Size(249, 166);
            this.ProductosBuscados.TabIndex = 6;
            // 
            // Carrito
            // 
            this.Carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Carrito.Location = new System.Drawing.Point(503, 105);
            this.Carrito.Name = "Carrito";
            this.Carrito.Size = new System.Drawing.Size(245, 166);
            this.Carrito.TabIndex = 7;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(309, 320);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(184, 23);
            this.btnComprar.TabIndex = 8;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 388);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.Carrito);
            this.Controls.Add(this.ProductosBuscados);
            this.Controls.Add(this.txtTotalFac);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.btnAgregarCarri);
            this.Controls.Add(this.btnBuscarPro);
            this.Controls.Add(this.txtNombrePro);
            this.Controls.Add(this.label1);
            this.Name = "Compra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosBuscados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombrePro;
        private System.Windows.Forms.Button btnBuscarPro;
        private System.Windows.Forms.Button btnAgregarCarri;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox txtTotalFac;
        private System.Windows.Forms.DataGridView ProductosBuscados;
        private System.Windows.Forms.DataGridView Carrito;
        private System.Windows.Forms.Button btnComprar;
    }
}