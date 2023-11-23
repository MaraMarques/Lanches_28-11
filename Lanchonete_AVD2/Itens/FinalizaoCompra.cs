using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lanchonete_AVD2.Itens
{
    public abstract class FinalizacaoCompra
    {
        public static List<IItemPedido> ObterPedidosSelecionados(Pedido pedido)
        {
            List<IItemPedido> pedidosSelecionados = new List<IItemPedido>();

            Console.WriteLine($"\nPedido de {pedido.NomeCliente}:");

            foreach (var itemPedido in pedido.ItensPedido)
            {
                Console.WriteLine($"{itemPedido.Nome} - {itemPedido.CalcularPreco():C}");
                pedidosSelecionados.Add(itemPedido);
            }

            decimal precoTotal = pedido.CalcularPrecoTotal();
            Console.WriteLine("\n---------------------------");
            Console.WriteLine($"Preço Total: {precoTotal:C}");

            return pedidosSelecionados;
        }
    }
}
