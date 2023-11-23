using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lanchonete_AVD2.Itens;

namespace TestLanchonete
{
    [TestClass]
    public class BebidaTests
    {
        [TestMethod]
        public void CalcularPreco_DeveRetornarPrecoCorreto()
        {
            // Arrange
            Bebida cocaCola = new Bebida
            {
                Nome = "Coca-Cola",
                Preco = 3.0m
            };
            // Act
            decimal resultado = cocaCola.CalcularPreco();
            // Assert
            Assert.AreEqual(cocaCola.Preco, resultado, "O preço da bebida está incorreto.");
        }
    }
}
