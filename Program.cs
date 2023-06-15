// Scren Sounds


Dictionary<string, List<int>> BandasRegistradas = new Dictionary<string, List<int>>()
{
    {"Violent Vira", new List<int>{9, 10, 7, 8, 6} },
    {"Pierce the veil", new List<int>{7, 10, 6, 5, 7, 8} },
    {"Queens", new List<int>{9, 10, 7, 8, 10} }
};


void ExibirLogo()
{
    string messagemDeBoasVindas = "Boas vindas ao Screen Sound!!";

    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(messagemDeBoasVindas);
    Console.WriteLine(string.Empty);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();

    Console.WriteLine("Digite 1 para registrar uma banda.");
    Console.WriteLine("Digite 2 para mostrar todas as bandas.");
    Console.WriteLine("Digite 3 para avaliar uma banda.");
    Console.WriteLine("Digite 4 para exibir a media de notas das bandas.");
    Console.WriteLine("Digite 0 para encerrar.");

    Console.Write("\nDigite aqui sua opção escolhida: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumero = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumero)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMediaDeNotas();
            break;
        case 0:
            Console.WriteLine("Até logo!!");
            break;
        default:
            Console.WriteLine($"Opção {opcaoEscolhidaNumero} é invalida.");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();

    ExibirTituloOpcoes("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");

    string nomeDaBanda = Console.ReadLine()!;
    BandasRegistradas.Add(nomeDaBanda, new List<int>());

    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso.");
    Thread.Sleep(500);

    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();

    ExibirTituloOpcoes("Bandas registradas");

    foreach (string banda in BandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine(string.Empty);
    Console.WriteLine("Digite qualquer tecla para voltar");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void ExibirTituloOpcoes(string titulo)
{
    int quantidadeCaracters = titulo.Length;
    string travessao = string.Empty.PadLeft(quantidadeCaracters, '-');

    Console.WriteLine(travessao);
    Console.WriteLine(titulo);
    Console.WriteLine(travessao);
    Console.WriteLine(string.Empty);
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloOpcoes("Avaliar banda");

    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;

    if (BandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write($"Digite uma nota de 0 a 10 para a banda {nomeBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);

        BandasRegistradas[nomeBanda].Add(nota);
        Console.WriteLine($"Anotando sua nota {nota} para a banda {nomeBanda}... \n");
        Thread.Sleep(2500);
        Console.WriteLine("Sua nota foi registrada com sucesso! \n");
        Console.WriteLine("Voltando ao menu.");
        Thread.Sleep(1500);

        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine(string.Empty);
        Console.WriteLine($"Banda {nomeBanda} não é registrada.");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();

        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMediaDeNotas()
{
    Console.Clear();
    ExibirTituloOpcoes("Média de notas das bandas");

    Console.Write("Digite aqui o nome da banda que deseja buscar a média: ");
    string banda = Console.ReadLine()!;
    Console.WriteLine("Buscando banda...\n");
    Thread.Sleep(1000);


    if (BandasRegistradas.ContainsKey(banda))
    {
        double mediaNotas = BandasRegistradas[banda].Average();

        Console.WriteLine($"A média da banda {banda} é: {mediaNotas}\n");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();

        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"{banda} não possui registro e/ou não possui notas.");
        Console.WriteLine("Voltando ao menu principal...");
        Thread.Sleep(1500);

        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();