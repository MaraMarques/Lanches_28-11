using Lanchonete_AVD2.Itens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLanchonete
{
    [TestClass]
    public class PedidoTets
    {
        [TestMethod]
        public void CalcularPrecoTotal_DeveRetornarPrecoTotalCorreto()
        {
            // Arrange
            Ingrediente alface = new Ingrediente { Nome = "Alface", Preco = 0.5m };
            Ingrediente queijo = new Ingrediente { Nome = "Queijo", Preco = 1.0m };
            Ingrediente carne = new Ingrediente { Nome = "Carne", Preco = 2.0m };
            Lanche lanche = new Lanche { Nome = "X-Burger" };
            lanche.AdicionarIngrediente(alface);
            lanche.AdicionarIngrediente(queijo);
            lanche.AdicionarIngrediente(carne);
            Bebida cocaCola = new Bebida { Nome = "Coca-Cola", Preco = 3.0m };
            Pedido pedido = new Pedido();
            pedido.AdicionarItem(lanche);
            pedido.AdicionarItem(cocaCola);
            // Act
            decimal resultado = pedido.CalcularPrecoTotal();
            // Assert
            decimal precoEsperado = alface.Preco + queijo.Preco + carne.Preco + cocaCola.Preco;
            Assert.AreEqual(precoEsperado, resultado, "O preço total do pedido está incorreto.");
        }
    }
}
