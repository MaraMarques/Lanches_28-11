using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete_AVD2
{
    public interface IItemPedido
    {
        public string Nome { get; set; }
        decimal CalcularPreco();
    }
}
