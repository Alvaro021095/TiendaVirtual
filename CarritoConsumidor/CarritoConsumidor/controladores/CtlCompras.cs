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
            
            producto[] listaProductos = ctlPro.operacionListarProductos(nombre);

            if (listaProductos != null)
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
