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

        public bool crear(String apellido, String cedula, String correo, String nombre, String telefono,
            String usuario, String contrasenia)
        {
            cliente c = new cliente();
            c.apellido = apellido;
            c.cedula = cedula;
            c.correo = correo;
            c.nombre = nombre;
            c.telefono = telefono;

            ClientesControllerClient wsCliente = new ClientesControllerClient();

            
            String resp = wsCliente.operacionCrear(c, contrasenia, usuario);

            if(resp.Equals("OK")){
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
