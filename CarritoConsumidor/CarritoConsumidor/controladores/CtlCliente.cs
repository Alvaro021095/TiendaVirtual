using CarritoConsumidor.ServicioCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoConsumidor.controladores
{
    public class CtlCliente
    {

        public void crear()
        {

            ClienteCtlClient ws = new ClienteCtlClient();

            ws.operacionCrearCliente("22","ddd","ggg","dfdf@","222","df");

        }

    }
}
