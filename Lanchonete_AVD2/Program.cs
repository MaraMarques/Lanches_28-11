using Lanchonete_AVD2;
using Lanchonete_AVD2.Itens;


class Program
{
    static void Main()
    {
        // Criar ingredientes e itens do menu
        Ingrediente alface = new Ingrediente { Nome = "Alface", Preco = 0.5m };
        Ingrediente queijo = new Ingrediente { Nome = "Queijo", Preco = 1.0m };
        Ingrediente carne = new Ingrediente { Nome = "Carne Bovina", Preco = 4.0m };
        Ingrediente tomate = new Ingrediente { Nome = "Tomate", Preco = 1.0m };
        Ingrediente proteina = new Ingrediente { Nome = "Proteina Texturizada", Preco = 3.0m };
        Ingrediente bacon = new Ingrediente { Nome = "Bacon", Preco = 3.0m };
        Ingrediente cebola = new Ingrediente { Nome = "Cebola", Preco = 1.0m };
        Ingrediente frango = new Ingrediente { Nome = "Carne de Frango", Preco = 4.0m };


        Lanche xBurger = new Lanche { Nome = "X-Burger" };
        xBurger.AdicionarIngrediente(queijo);
        xBurger.AdicionarIngrediente(carne);
        xBurger.AdicionarIngrediente(cebola);

        Lanche xSalada = new Lanche { Nome = "X-Salada" };
        xSalada.AdicionarIngrediente(alface);
        xSalada.AdicionarIngrediente(tomate);
        xSalada.AdicionarIngrediente(carne);
        xSalada.AdicionarIngrediente(cebola);

        Lanche xFrango = new Lanche { Nome = "Frango Crispy" };
        xFrango.AdicionarIngrediente(frango);
        xFrango.AdicionarIngrediente(queijo);
        xFrango.AdicionarIngrediente(alface);
        xFrango.AdicionarIngrediente(tomate);
        xFrango.AdicionarIngrediente(cebola);

        Lanche xBacon = new Lanche { Nome = "X-Bacon" };
        xBacon.AdicionarIngrediente(bacon);
        xBacon.AdicionarIngrediente(cebola);
        xBacon.AdicionarIngrediente(carne);
        xBacon.AdicionarIngrediente(queijo);

        Lanche xVegano = new Lanche { Nome = "Veggie Burger" };
        xVegano.AdicionarIngrediente(proteina);
        xVegano.AdicionarIngrediente(tomate);
        xVegano.AdicionarIngrediente(alface);
        xVegano.AdicionarIngrediente(cebola);


        Bebida cocaCola = new Bebida { Nome = "Coca-Cola", Preco = 3.0m };
        Bebida fantaLaranja = new Bebida { Nome = "Fanta Laranja", Preco = 3.0m };
        Bebida activePlus = new Bebida { Nome = "Active Plus", Preco = 2.0m };
        Bebida pepsi = new Bebida { Nome = "Pepsi", Preco = 3.0m };
        Bebida agua = new Bebida { Nome = "Água s/ gás", Preco = 1.0m };
        Bebida sucoLaranja = new Bebida { Nome = "Suco de Laranja", Preco = 2.5m };

        // Criar menus
        List<IItemPedido> menuBebidas = new List<IItemPedido> { cocaCola, sucoLaranja, fantaLaranja, activePlus, pepsi, agua };
        List<IItemPedido> menuHamburgers = new List<IItemPedido> { xBurger, xBacon, xFrango, xSalada, xVegano };

        // Entrada do cliente
        Console.WriteLine("Bem-vindo ao Sistema de Pedido de Lanches!");
        Console.Write("Digite seu nome: ");
        string nomeCliente = Console.ReadLine();

        Pedido pedidoCliente = new Pedido();
        pedidoCliente.NomeCliente = nomeCliente;

        while (true)
        {
            // Exibir opções do menu
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Escolher Bebida");
            Console.WriteLine("2. Escolher Hambúrguer");
            Console.WriteLine("3. Finalizar Pedido");

            // Processar escolha do cliente
            string escolhaMenuPrincipal = Console.ReadLine();

            switch (escolhaMenuPrincipal)
            {
                case "1":
                    // Menu de bebidas
                    while (true)
                    {
                        Console.WriteLine("\nEscolha uma bebida:");
                        for (int i = 0; i < menuBebidas.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {menuBebidas[i].Nome} - {menuBebidas[i].CalcularPreco():C}");
                        }

                        Console.WriteLine($"{menuBebidas.Count + 1}. Voltar ao Menu Principal");

                        string escolhaBebida = Console.ReadLine();
                        if (int.TryParse(escolhaBebida, out int indiceBebida) && indiceBebida >= 1 && indiceBebida <= menuBebidas.Count)
                        {
                            pedidoCliente.AdicionarItem(menuBebidas[indiceBebida - 1]);
                            Console.WriteLine($"Bebida {menuBebidas[indiceBebida - 1].Nome} adicionada ao pedido.");
                        }
                        else if (indiceBebida == menuBebidas.Count + 1)
                        {
                            break; // Voltar ao Menu Principal
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida. Tente novamente.");
                        }
                    }
                    break;

                case "2":
                    // Menu de hambúrgueres
                    while (true)
                    {
                        Console.WriteLine("\nEscolha um hambúrguer:");
                        for (int i = 0; i < menuHamburgers.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {menuHamburgers[i].Nome} - {menuHamburgers[i].CalcularPreco():C}");
                        }

                        Console.WriteLine($"{menuHamburgers.Count + 1}. Voltar ao Menu Principal");

                        string escolhaHamburguer = Console.ReadLine();
                        if (int.TryParse(escolhaHamburguer, out int indiceHamburguer) && indiceHamburguer >= 1 && indiceHamburguer <= menuHamburgers.Count)
                        {
                            pedidoCliente.AdicionarItem(menuHamburgers[indiceHamburguer - 1]);
                            Console.WriteLine($"Hambúrguer {menuHamburgers[indiceHamburguer - 1].Nome} adicionado ao pedido.");
                        }
                        else if (indiceHamburguer == menuHamburgers.Count + 1)
                        {
                            break; // Voltar ao Menu Principal
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida. Tente novamente.");
                        }
                    }
                    break;

                case "3":
                    // Finalizar Pedido
                    decimal precoTotal = pedidoCliente.CalcularPrecoTotal();
                    List<IItemPedido> pedidosSelecionados = FinalizacaoCompra.ObterPedidosSelecionados(pedidoCliente);
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
