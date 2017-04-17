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

            FacturaControllerClient wsFactura = new FacturaControllerClient();
            itemsDTO[] nuevLi = lista.ToArray();
            Console.WriteLine(nuevLi[0].id);
            String resu = wsFactura.operacionCrearCompra(idUsuario,valorFactura,nuevLi);
            return resu;
        }

    }
}
