using BrisaDoMar;

int opcao = 0;

while (opcao != 4) { 

    Console.WriteLine("Bem vindo ao Brisa do Mar!");

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
