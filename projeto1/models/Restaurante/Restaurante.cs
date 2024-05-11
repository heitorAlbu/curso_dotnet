using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto1.models.Restaurante
{
    public class Restaurante
    {

        public List<Pedido> pedidos { get; set; }

        Dictionary<int, List<Pedido>> pedidosPorMesa { get; set; }


        public void AdicionarPedido(int mesa, Pedido pedido)
        {

        }

        public void ModificarPedido(int mesa, int indicePedido, Pedido novoPedido)
        {

        }


        public void CalcularTotalMesa(int mesa)
        {

        }


    }
}