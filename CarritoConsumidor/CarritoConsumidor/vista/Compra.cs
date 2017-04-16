using CarritoConsumidor.controladores;
using CarritoConsumidor.ServiceLogin;
using CarritoConsumidor.ServiceProducto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarritoConsumidor.vista
{
    public partial class Compra : Form
    {
        usuario thisUser;
        public CtlCompras ctlCom;
        private CtlFactura ctlFactura;
        private CtlCarrito ctlcarrito;
        int cantidadInicial;
        int cantidadRequerida = 0;

        public Compra(usuario users)
        {
            InitializeComponent();
            this.thisUser = users;
            ctlCom = new CtlCompras();
            ctlcarrito = new CtlCarrito();
            ctlFactura = new CtlFactura();
            cantidadInicial = 0;
            listarCarrito();

        }

        private void btnBuscarPro_Click(object sender, EventArgs e)
        {

            //DataTable dt = (DataTable)ProductosBuscados.DataSource;

            if (ProductosBuscados != null)
            {
                ProductosBuscados.Rows.Clear();
            }

            String nombrePro = txtNombrePro.Text;

            producto[] listaDeProdcutos = ctlCom.listarProducto(nombrePro);

            if (listaDeProdcutos != null)
            {
                for (int i = 0; i < listaDeProdcutos.Length; i++)
                {

                    ProductosBuscados.Rows.Add(listaDeProdcutos.ElementAt(i).id, listaDeProdcutos.ElementAt(i).nombre,
                        listaDeProdcutos.ElementAt(i).valor, listaDeProdcutos.ElementAt(i).cantidad);
                }


            }
            else
            {
                MessageBox.Show("No existe el producto");
            }
        }

        private void Compra_Load(object sender, EventArgs e)
        {

            //DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            //c1.HeaderText = "Nombree";
            //c1.Width = 50;


            //DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            //c2.HeaderText = "Valor";
            //c2.Width = 50;

            //DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            //c3.HeaderText = "Cantidad";
            //c3.Width = 50;

            //ProductosBuscados.Columns.Add(c1);
            //ProductosBuscados.Columns.Add(c2);
            //ProductosBuscados.Columns.Add(c3);

        }

        private void btnAgregarCarri_Click(object sender, EventArgs e)
        {
            try
            {
                double total = 0.0;

                if (ProductosBuscados.CurrentRow.Cells["CantidadRequest"].Value != null)
                {

                    cantidadInicial = (int)ProductosBuscados.CurrentRow.Cells["Cantidad"].Value;

                    int id = (int)ProductosBuscados.CurrentRow.Cells["Id"].Value;

                    //var objeto = ProductosBuscados.CurrentRow.Cells["CantidadRequest"].Value != null ? ProductosBuscados.CurrentRow.Cells["CantidadRequest"].Value : 0;
                    // var valorObjeto = ProductosBuscados.CurrentRow.Cells["Valor"].Value;
                    //var objetoCadena = ProductosBuscados.CurrentRow.Cells["Nombre"].Value;

                    cantidadRequerida = Convert.ToInt32(ProductosBuscados.CurrentRow.Cells["CantidadRequest"].Value != null ? ProductosBuscados.CurrentRow.Cells["CantidadRequest"].Value : 0);

                        double valor = (Convert.ToDouble(ProductosBuscados.CurrentRow.Cells["Valor"].Value)) * cantidadRequerida;

                        String nombre = Convert.ToString(ProductosBuscados.CurrentRow.Cells["Nombre"].Value);

                        if (validarProducto(id))
                        {

                            bool result = ctlcarrito.adicionarCarrito(id, thisUser.id, cantidadRequerida, Convert.ToDecimal(valor));

                            if (result)
                            {

                                Carrito.Rows.Add(id, nombre, cantidadRequerida, valor);
                                

                            }
                            else
                            {

                                MessageBox.Show("No puedes comprar lo que no hay.");
                            }

                        }
                        foreach (DataGridViewRow row in Carrito.Rows)
                        {

                            total += Convert.ToDouble(row.Cells["ValorCompra"].Value);

                        }

                        txtTotalFac.Text = total + "";
                    
                }

            }
            catch (Exception exception)
            {

                MessageBox.Show("Por Favor seleccion o busque un producto");
            }

        }

        public void listarCarrito()
        {

           CarritoConsumidor.ServiceCarrito.carrito [] lista =  ctlcarrito.listarCarrito(thisUser.id);

           if (lista != null)
           {
               for (int i = 0; i < lista.Length; i++)
               {

                   Carrito.Rows.Add(lista.ElementAt(i).producto.id, lista.ElementAt(i).producto.nombre,
                        lista.ElementAt(i).cantidad,lista.ElementAt(i).valorTotal);

               }
           }

        }

        public bool validarProducto(int id)
        {

            foreach (DataGridViewRow row in Carrito.Rows)
            {

                int ids = Convert.ToInt32(row.Cells["IdCompra"].Value);

                if (id == ids)
                {

                    return false;

                }

            }

            return true;

        }

        private void ProductosBuscados_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine("entre");
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            List<CarritoConsumidor.ServiceFactura.itemsDTO> items = new List<ServiceFactura.itemsDTO>();

            foreach (DataGridViewRow row in Carrito.Rows)
            {
                CarritoConsumidor.ServiceFactura.itemsDTO item = new ServiceFactura.itemsDTO();

                var objCantidad =  row.Cells["CantidadCompra"].Value;

                var objId = row.Cells["IdCompra"].Value;

                var objValor = row.Cells["ValorCompra"].Value;

                item.cantidad = Convert.ToString(objCantidad);
                item.id = Convert.ToString(objId);
                item.valorTotal = Convert.ToString(objValor);

                items.Add(item);

            }

            ctlFactura.crearCompra(thisUser.id, Convert.ToInt32(txtTotalFac.Text),items);
            
        }
    }
}
