using Lanchonete_AVD2.Itens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestLanchonete
{
    [TestClass]
    public class LancheTests
    {
        [TestMethod]
        public void CalcularPreco_DeveRetornarPrecoCorreto()
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
            // Act
            decimal resultado = lanche.CalcularPreco();
            // Assert
            decimal precoEsperado = alface.Preco + queijo.Preco + carne.Preco;
            Assert.AreEqual(precoEsperado, resultado, "O preço do lanche está incorreto.");
        }
        [TestMethod]
        public void AdicionarIngrediente_DeveAdicionarIngredienteCorretamente()
        {
            // Arrange
            Ingrediente alface = new Ingrediente
            {
                Nome = "Alface",
                Preco = 0.5m
            };
            Lanche lanche = new Lanche { Nome = "X-Burger" };
            // Act
            lanche.AdicionarIngrediente(alface);
            // Assert
            Assert.IsTrue(lanche.Ingredientes.Contains(alface), "O ingrediente não foi adicionado corretamente.");
        }
    }
}