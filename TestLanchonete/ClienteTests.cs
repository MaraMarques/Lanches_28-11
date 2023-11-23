using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lanchonete_AVD2.Itens;


namespace TestLanchonete
{
    [TestClass]
    public class ClienteTests
    {
        [TestMethod]
        public void
        CalcularPrecoTotalPedido_DeveRetornarPrecoTotalCorreto()
        {
            // Arrange
            Ingrediente alface = new Ingrediente
            {
                Nome = "Alface",
                Preco = 0.5m
            };
            Ingrediente queijo = new Ingrediente
            {
                Nome = "Queijo",
                Preco = 1.0m
            };
            Ingrediente carne = new Ingrediente
            {
                Nome = "Carne",
                Preco = 2.0m
            };
            Lanche lanche = new Lanche { Nome = "X-Burger" };
            lanche.AdicionarIngrediente(alface);
            lanche.AdicionarIngrediente(queijo);
            lanche.AdicionarIngrediente(carne);
            Pedido pedido = new Pedido();
            pedido.AdicionarItem(lanche);
            Cliente cliente = new Cliente { Nome = "João" };
            cliente.Pedidos.Add(pedido);
            // Act
            decimal resultado = cliente.Pedidos.First().CalcularPrecoTotal();
            // Assert
            decimal precoEsperado = alface.Preco + queijo.Preco + carne.Preco;
            Assert.AreEqual(precoEsperado, resultado, "O preço total do pedido do cliente está incorreto.");
        }
    }
}
