using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete_AVD2.Itens
{
    public class Cliente
    {
        public string Nome { get; set; }
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
