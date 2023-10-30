using Estacionamento.Models;

// Exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Sistema de Estacionamento: ");

bool exibirMenu = true;

while (exibirMenu) {
    //Console.Clear();
    Console.WriteLine("Sistema de Estacionamento: ");
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1- cadastrar veículo");
    Console.WriteLine("2- Remover veículo");
    Console.WriteLine("3- Listar todos os veículos");
    Console.WriteLine("5- Listar um veículo");
    Console.WriteLine("0- Sair");
    
    switch (Console.ReadLine()) {
        case "1":
        Console.WriteLine("Caso1");
        break;

        case "0":
        exibirMenu = false;
        break;

        default:
        Console.WriteLine("Opção inváçida!");
        break;
    }

}