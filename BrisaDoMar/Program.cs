using BrisaDoMar;

int opcao = 0;

var restaurante = new Restaurante
{
    NomeRestaurante = "Brisa do Mar",
    Cardapio = new List<ItemCardapio>
    {
        new ItemCardapio { Nome = "Hambúrguer", Descricao = "Pão, carne e queijo", Preco = 22.90m },
        new ItemCardapio { Nome = "Pizza", Descricao = "Mussarela", Preco = 39.90m },
        new ItemCardapio { Nome = "Espetinho", Descricao = "Carne", Preco = 10.00m }
    },
    Mesas = new List<Mesa>
    {
        new Mesa { NumeroMesa = 1 },
        new Mesa { NumeroMesa = 2 },
        new Mesa { NumeroMesa = 3 }
    }
};

while (opcao != 4) { 

    Console.WriteLine($"Bem vindo ao {restaurante.NomeRestaurante}");

    Console.WriteLine("Digite 1 para ver o Cardápio: \n");
    Console.WriteLine("Digite 2 para adicionar um produto ao pedido: \n");
    Console.WriteLine("Digite 3 para verificar o pedido completo da Mesa: \n");
    Console.WriteLine("Digite 4 para fechar a conta de uma mesa: \n");

    opcao = int.Parse(Console.ReadLine() ?? "0");

    switch (opcao)
    {
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        default:
            break;
    }

}
void ExibirCardapio()
{
    Console.WriteLine("---Cardápio---");
    int i = 1;

    foreach (var item in restaurante.Cardapio)
    {
        Console.WriteLine($"{i} | {item.Nome} - {item.Descricao} - R$ {item.Preco:F2}");
        i++;
    }
}
void AdicionarProduto()
{
    Console.WriteLine("\n Número da mesa: ");
    if(!int.TryParse(Console.ReadLine(), out int numeroMesa))
    {
        Console.WriteLine("Mesa inválida");
        return;
    }
    Console.Clear();

    ExibirCardapio();

    Console.WriteLine("\n Digite o item: ");
    if(!int.TryParse(Console.ReadLine(), out int escolha) || escolha < 1 || escolha > restaurante.Cardapio.Count)
    {
        Console.WriteLine("Item inválido");
        return;
    }
    Console.Clear();

    Console.WriteLine("\nQuantidade: ");
    if (!int.TryParse(Console.ReadLine(), out int qtd) || qtd <= 0)
    {
        Console.WriteLine("Quantidade inválida");
        return;
    }
    Console.Clear();

    var itemEscolhido = restaurante.Cardapio[escolha - 1];

    
    
}