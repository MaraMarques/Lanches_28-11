using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lanchonete_AVD2.Itens
{
    public class Pedido
    {
        public string NomeCliente { get; set; }
        public List<IItemPedido> ItensPedido { get; set; } = new List<IItemPedido>();
        public decimal PrecoTotal { get; set; }
        public void AdicionarItem(IItemPedido itemPedido)
        {
            ItensPedido.Add(itemPedido);
        }
        public decimal CalcularPrecoTotal()
        {
            PrecoTotal = 0;
            foreach (var itemPedido in ItensPedido)
            {
                PrecoTotal += itemPedido.CalcularPreco();
            }
            return PrecoTotal;
        }
    }
}
