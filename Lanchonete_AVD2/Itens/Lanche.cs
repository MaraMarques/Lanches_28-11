using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lanchonete_AVD2.Itens
{
    public class Lanche : IItemPedido
    {
        public string Nome { get; set; }
        public List<Ingrediente> Ingredientes { get; set; } = new List<Ingrediente>();
        public decimal Preco { get; set; }
        public void AdicionarIngrediente(Ingrediente ingrediente)
        {
            Ingredientes.Add(ingrediente);
        }
        public decimal CalcularPreco()
        {
            Preco = 0;
            foreach (var ingrediente in Ingredientes)
            {
                Preco += ingrediente.Preco;
            }
            return Preco;
        }
    }
}
