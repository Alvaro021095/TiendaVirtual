using CarritoConsumidor.ServiceFactura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoConsumidor.controladores
{
    class CtlFactura
    {

         public void crearCompra(int idUsuario, double valorFactura,List<itemsDTO> lista)
        {

            FacturaControllerClient wsFactura = new FacturaControllerClient();

            wsFactura.crearCompra(idUsuario,valorFactura,lista.ToArray());

        }

    }
}
