using CarritoConsumidor.ServiceLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoConsumidor.controladores
{
    class CtlLogin
    {

        public usuario login(String usuario, String password)
        {

            LoginControllerClient wsLogin = new LoginControllerClient();

            usuario users = wsLogin.operacionLogin(usuario, password);

            return users;

        }
    }
}
