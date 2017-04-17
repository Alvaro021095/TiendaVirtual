using CarritoConsumidor.controladores;
using CarritoConsumidor.ServiceLogin;
using CarritoConsumidor.ServiceNoti;
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
        //private CtlNotificar ctlNoti;
        int cantidadInicial;
        int cantidadRequerida = 0;

        public Compra(usuario users)
        {
            InitializeComponent();
            this.thisUser = users;
            ctlCom = new CtlCompras();
            ctlcarrito = new CtlCarrito();
            ctlFactura = new CtlFactura();
            //ctlNoti = new CtlNotificar();
            cantidadInicial = 0;
            listarCarrito();
            txtTotalFac.Enabled=false;
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
                Console.WriteLine(exception);
                MessageBox.Show("Por Favor seleccion o busque un producto");
            }

        }

        public void listarCarrito()
        {

           CarritoConsumidor.ServiceCarrito.carrito [] lista =  ctlcarrito.listarCarrito(thisUser.id);
           decimal total = 0;
           if (lista != null)
           {
               for (int i = 0; i < lista.Length; i++)
               {

                   Carrito.Rows.Add(lista.ElementAt(i).producto.id, lista.ElementAt(i).producto.nombre,
                        lista.ElementAt(i).cantidad,lista.ElementAt(i).valorTotal);
                   total = total + (lista.ElementAt(i).producto.valor*lista.ElementAt(i).cantidad);
               }
           }
           txtTotalFac.Text = ""+total;

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
            
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
           if(!txtTotalFac.Text.Equals("")){
               List<CarritoConsumidor.ServiceFactura.itemsDTO> items = new List<ServiceFactura.itemsDTO>();

               String productos = "";
               String total = txtTotalFac.Text;

               foreach (DataGridViewRow row in Carrito.Rows)
               {
                   CarritoConsumidor.ServiceFactura.itemsDTO item = new ServiceFactura.itemsDTO();

                   String objNombre = (String)row.Cells["NombreCompra"].Value;

                   var objCantidad = row.Cells["CantidadCompra"].Value;

                   var objId = row.Cells["IdCompra"].Value;

                   var objValor = row.Cells["ValorCompra"].Value;

                   item.cantidad = Convert.ToString(objCantidad);
                   item.id = Convert.ToString(objId);
                   item.valorTotal = Convert.ToString(objValor);

                   items.Add(item);
                   productos += item.cantidad + " " + objNombre;
               }

               for (int i = 0; i < items.Count; i++)
               {
                   if (items.ElementAt(i).id.Equals(""))
                   {
                       items.Remove((items.ElementAt(i)));
                   }
               }


               String resul = ctlFactura.crearCompra(thisUser.id, Convert.ToDouble(txtTotalFac.Text), items);

               if (resul.Equals("Exito"))
               {
                   MessageBox.Show("Exito en la compra");
                   notificacionesService not = new notificacionesService();
                   not.Url = "http://104.197.238.134:8080/notificaciones/notificacionesService";
                   mail m = new mail();
                   m.body = "Señor(a) " + thisUser.cliente.nombre + " " + thisUser.cliente.apellido +
                       " le confirmamos que usted a realizado la compra de los siguietes productos: " +
                       productos + " y su costo total es de: " + total;
                   m.from = "tienda@gmail.com";
                   m.subject = "TIENDA";
                   m.to = thisUser.cliente.correo;

                   sms s = new sms();
                   s.texto = "Señor(a) " + thisUser.cliente.nombre +
                       " a realizado una compra por el valor de: " + total;
                   s.to = thisUser.cliente.telefono;

                   not.enviarSMS(s);
                   not.enviarMail(m);
                   /*
                    * Se refresca la tabla de productos buscados 
                    * Se pone el total del valor en 0
                    * Se limpia la tabla del carrito
                    * */
                   refrescar(txtNombrePro.Text);
                   txtTotalFac.Text = "0";
                   Carrito.Rows.Clear();

               }
               else
               {
                   MessageBox.Show("No se pudo realizar la compra");
               }
           }
           else
           {
               MessageBox.Show("No hay un valor total");
           }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        public void refrescar(String nombree)
        {
            producto[] listaDeProdcutosDeNuevo = ctlCom.listarProducto(nombree);
            if (ProductosBuscados != null)
            {
                ProductosBuscados.Rows.Clear();
            }

            if (listaDeProdcutosDeNuevo != null)
            {
                for (int i = 0; i < listaDeProdcutosDeNuevo.Length; i++)
                {

                    ProductosBuscados.Rows.Add(listaDeProdcutosDeNuevo.ElementAt(i).id, listaDeProdcutosDeNuevo.ElementAt(i).nombre,
                        listaDeProdcutosDeNuevo.ElementAt(i).valor, listaDeProdcutosDeNuevo.ElementAt(i).cantidad);
                }
            }
            else
            {
                MessageBox.Show("No existe el producto");
            }
        }
    }
}
