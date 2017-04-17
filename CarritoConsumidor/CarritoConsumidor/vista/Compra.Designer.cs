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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrito = new System.Windows.Forms.DataGridView();
            this.IdCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnComprar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosBuscados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carrito)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Producto:";
            // 
            // txtNombrePro
            // 
            this.txtNombrePro.Location = new System.Drawing.Point(162, 31);
            this.txtNombrePro.Name = "txtNombrePro";
            this.txtNombrePro.Size = new System.Drawing.Size(189, 20);
            this.txtNombrePro.TabIndex = 1;
            // 
            // btnBuscarPro
            // 
            this.btnBuscarPro.Location = new System.Drawing.Point(374, 31);
            this.btnBuscarPro.Name = "btnBuscarPro";
            this.btnBuscarPro.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPro.TabIndex = 2;
            this.btnBuscarPro.Text = "Buscar ";
            this.btnBuscarPro.UseVisualStyleBackColor = true;
            this.btnBuscarPro.Click += new System.EventHandler(this.btnBuscarPro_Click);
            // 
            // btnAgregarCarri
            // 
            this.btnAgregarCarri.Location = new System.Drawing.Point(218, 211);
            this.btnAgregarCarri.Name = "btnAgregarCarri";
            this.btnAgregarCarri.Size = new System.Drawing.Size(133, 23);
            this.btnAgregarCarri.TabIndex = 3;
            this.btnAgregarCarri.Text = "Agregar al Carrito";
            this.btnAgregarCarri.UseVisualStyleBackColor = true;
            this.btnAgregarCarri.Click += new System.EventHandler(this.btnAgregarCarri_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(389, 211);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(34, 13);
            this.Total.TabIndex = 4;
            this.Total.Text = "Total:";
            // 
            // txtTotalFac
            // 
            this.txtTotalFac.Location = new System.Drawing.Point(429, 208);
            this.txtTotalFac.Name = "txtTotalFac";
            this.txtTotalFac.Size = new System.Drawing.Size(94, 20);
            this.txtTotalFac.TabIndex = 5;
            // 
            // ProductosBuscados
            // 
            this.ProductosBuscados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosBuscados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Valor,
            this.Cantidad,
            this.CantidadRequest});
            this.ProductosBuscados.Location = new System.Drawing.Point(26, 73);
            this.ProductosBuscados.Name = "ProductosBuscados";
            this.ProductosBuscados.Size = new System.Drawing.Size(543, 126);
            this.ProductosBuscados.TabIndex = 6;
            this.ProductosBuscados.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductosBuscados_RowEnter);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad Disponible";
            this.Cantidad.Name = "Cantidad";
            // 
            // CantidadRequest
            // 
            this.CantidadRequest.HeaderText = "Cantidad Requerida";
            this.CantidadRequest.Name = "CantidadRequest";
            // 
            // Carrito
            // 
            this.Carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Carrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCompra,
            this.NombreCompra,
            this.CantidadCompra,
            this.ValorCompra});
            this.Carrito.Location = new System.Drawing.Point(26, 255);
            this.Carrito.Name = "Carrito";
            this.Carrito.Size = new System.Drawing.Size(443, 77);
            this.Carrito.TabIndex = 7;
            // 
            // IdCompra
            // 
            this.IdCompra.HeaderText = "Id";
            this.IdCompra.Name = "IdCompra";
            // 
            // NombreCompra
            // 
            this.NombreCompra.HeaderText = "Nombre";
            this.NombreCompra.Name = "NombreCompra";
            // 
            // CantidadCompra
            // 
            this.CantidadCompra.HeaderText = "Cantidad";
            this.CantidadCompra.Name = "CantidadCompra";
            // 
            // ValorCompra
            // 
            this.ValorCompra.HeaderText = "Valor Total";
            this.ValorCompra.Name = "ValorCompra";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(513, 269);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(88, 23);
            this.btnComprar.TabIndex = 8;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 344);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCompra;
    }
}