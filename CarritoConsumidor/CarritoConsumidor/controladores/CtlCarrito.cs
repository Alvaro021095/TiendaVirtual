using CarritoConsumidor.ServiceCarrito;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoConsumidor.controladores
{
    class CtlCarrito
    {

        public void adicionarCarrito(int idProducto, int idUsuario, int cantidad, decimal valorTotal)
        {
            productoDTO product = new productoDTO();

            product.id = idProducto +"";

            usuarioDTO users = new usuarioDTO();

            users.id = idUsuario +"";

            carritoDTO carro = new carritoDTO();


            carro.cantidad = cantidad +"";
            carro.productoDTO = product;
            carro.usuarioDTO = users;
            //carro.valorTotal = valorTotal +"";

            Console.WriteLine(carro.cantidad + " " + carro.productoDTO.id +" "+carro.usuarioDTO.id);

            CarritoControllerClient wsCarrito = new CarritoControllerClient();

            wsCarrito.operacionAgregarCarrito(carro);

        }

    }
}
