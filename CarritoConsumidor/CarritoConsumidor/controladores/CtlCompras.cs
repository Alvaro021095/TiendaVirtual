using CarritoConsumidor.ServiceProducto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoConsumidor.controladores
{
    public class CtlCompras
    {

        public producto[] listarProducto(String nombre)
        {
            ProductoControllerClient ctlPro = new ProductoControllerClient();
            Console.WriteLine(nombre);
            producto[] listaProductos = ctlPro.operacionListarProductos(nombre);       

            if (listaProductos.Length>0)
            {
                return listaProductos;
            }
            else
            {
                return null;
            }
            
        }

        



    }
}
