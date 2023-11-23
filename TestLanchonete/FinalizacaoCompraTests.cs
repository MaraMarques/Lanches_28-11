using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lanchonete_AVD2.Itens;
using Lanchonete_AVD2;

namespace TestLanchonete
{
    [TestClass]
    public class FinalizacaoCompraTests
    {
        [TestMethod]
        public void ObterPedidosSelecionados_teste()
        {
            // Arrange
            Pedido pedidoEscolhido = new Pedido()
            {
                NomeCliente = "João",
                ItensPedido = new List<IItemPedido>
                {
                    new Lanche { Nome = "X-Burger" }, //Tem que definir o preço do lanche através dos ingredientes.
                    new Bebida { Nome = "Coca-Cola", Preco = 3.0m }

        }
            };
            // Definir o preço do lanche explicitamente
            decimal precoTotalEsperado = pedidoEscolhido.CalcularPrecoTotal();
            foreach (var itemPedido in pedidoEscolhido.ItensPedido)
            {
                if (itemPedido is Lanche lanche)
                {
                    lanche.AdicionarIngrediente(new Ingrediente { Nome = "Queijo", Preco = 1.0m });
                    lanche.AdicionarIngrediente(new Ingrediente { Nome = "Carne Bovina", Preco = 4.0m });
                    lanche.AdicionarIngrediente(new Ingrediente { Nome = "Cebola", Preco = 1.0m });
                }
            }

            // Act
            List<IItemPedido> pedidosSelecionados = FinalizacaoCompra.ObterPedidosSelecionados(pedidoEscolhido);

            // Assert
            Assert.IsNotNull(pedidosSelecionados);
            Assert.AreEqual(2, pedidosSelecionados.Count);
            Assert.AreEqual("X-Burger", pedidosSelecionados[0].Nome);
            Assert.AreEqual(6.0m, pedidosSelecionados[0].CalcularPreco());
            Assert.AreEqual("Coca-Cola", pedidosSelecionados[1].Nome);
            Assert.AreEqual(3.0m, pedidosSelecionados[1].CalcularPreco());
        }
    }
}
