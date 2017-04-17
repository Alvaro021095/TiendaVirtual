using CarritoConsumidor.ServiceFactura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoConsumidor.controladores
{
    public class CtlFactura
    {

        public String crearCompra(int idUsuario, double valorFactura, List<itemsDTO> lista)
        {

            FacturaControllerClient wsFactura2 = new FacturaControllerClient();
            itemsDTO[] nuevLi = lista.ToArray();
            String resu = wsFactura2.operacionCrearCompra(idUsuario,valorFactura,nuevLi);
            return resu;
        }

    }
}
