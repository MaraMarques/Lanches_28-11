using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lanchonete_AVD2.Itens
{
    public class Bebida : IItemPedido
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public decimal CalcularPreco()
        {
            return Preco;
        }
    }
}
