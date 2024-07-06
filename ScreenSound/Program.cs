// Screen Sound

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> bandas = new List<string>() { "Queen", "Imagine Dragons"};
Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>();
bandas.Add("Linkin Park", new List<int>() { 10, 8, 7 });
bandas.Add("Beatles", new List<int>());

void BoasVindas()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
}

void OpcoesMenu()
{
    BoasVindas();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcao = Console.ReadLine()!;
    int opcaoEscolhida = int.Parse(opcao);

    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            MediaBandas();
            break;
        case 0:
            Console.WriteLine("Tchau tchau * :)");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    TituloDasOpcoes("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    OpcoesMenu();
}
void MostrarBandas()
{
    Console.Clear();
    TituloDasOpcoes("Exibindo todas as bandas registradas");
    foreach (string i in bandas.Keys)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("\nPrecione qualquer tecla para voltar para o menu");
    Console.ReadKey();
    Console.Clear();
    OpcoesMenu();
}
void TituloDasOpcoes(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asterisco = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asterisco);
    Console.WriteLine(titulo);
    Console.WriteLine(asterisco + "\n");
}
void AvaliarBanda()
{
    Console.Clear();
    TituloDasOpcoes("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandas.ContainsKey(nomeBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandas[nomeBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para banda {nomeBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        OpcoesMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
        Console.WriteLine("Precione qualquer tecla para voltar para o menu");
        Console.ReadKey();
        Console.Clear();
        OpcoesMenu();
    }
}
void MediaBandas()
{
    Console.Clear();
    TituloDasOpcoes("Media das bandas");
    Console.Write("Digite o nome da banda que deseja vizualizar a media de avaliações: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandas.ContainsKey(nomeBanda))
    {
        Console.WriteLine($"A banda {nomeBanda} tem a media {bandas[nomeBanda].Average().ToString("F2")}");
        Thread.Sleep(4000);
        Console.Clear();
        OpcoesMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
        Console.WriteLine("Precione qualquer tecla para voltar para o menu");
        Console.ReadKey();
        Console.Clear();
        OpcoesMenu();
    }
}

OpcoesMenu();