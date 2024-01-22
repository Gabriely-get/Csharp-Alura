Dictionary<string, List<int>> bandasRegistras = new Dictionary<string, List<int>>();
bandasRegistras.Add("Linkin Park", new List<int> { 2, 10, 9 });
bandasRegistras.Add("The Beatles", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"


░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░"); //@ -> verbatim literal
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();

    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.WriteLine("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!; //!diz que nao pode ser nulo

    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ListarBandasRegistradas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4: MediaNotasBanda();
            break;
        case -1:
            Console.WriteLine("Tchau tchau ");
            break;
        default:
            Console.WriteLine("Opcao inválida!");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirLogo();

    ExibirTitulo("Registro de Banda");

    Console.WriteLine("Digite o nome da banda que deseja registrar");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistras.Add(nomeDaBanda, new List<int>());

    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!!");

    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ListarBandasRegistradas()
{
    Console.Clear();
    ExibirTitulo("Listar Bandas Registradas");

    foreach (string banda in bandasRegistras.Keys)
    {
        Console.WriteLine($"BANDA {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirLogo();
    ExibirTitulo("Avaliar Banda");

    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistras.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual valor deseja avaliar a banda {nomeDaBanda}? ");
        int nota = int.Parse(Console.ReadLine()!);

        bandasRegistras[nomeDaBanda].Add(nota);
        Console.WriteLine("Banda avaliada!");

        Thread.Sleep(1500);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não está registrada!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();

        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}

void MediaNotasBanda()
{
    Console.Clear();
    ExibirLogo();
    ExibirTitulo("Checar avaliação média de uma Banda");

    Console.Write("\nDigite a banda que você deseja saber a média: ");
    string nomeBanda = Console.ReadLine()!;

    if (bandasRegistras.ContainsKey (nomeBanda))
    {
        List<int> notas = bandasRegistras[nomeBanda];
        Console.WriteLine($"A média registrada da banda {nomeBanda} é {notas.Average()}");

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else
    {
        Console.WriteLine($"A banda {nomeBanda} não está registrada");

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}


void ExibirTitulo(string titulo)
{
    int lengthTitulo = titulo.Length;
    string asteriscos = string.Empty.PadLeft(lengthTitulo, '-');

    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

ExibirOpcoesDoMenu();
