


string mensagemDeBoasVindas = "Hello, colega!! Bem vinda";
Dictionary<string, List<int>> bandasRegistras = new Dictionary<string, List<int>>();
bandasRegistras.Add("Linkin Park", new List<int> { 2, 10, 9 });
bandasRegistras.Add("The Beatles", new List<int>());

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"


░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░"); //@ -> verbatim literal
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
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
        case 3: AvaliarBanda();
            break;
        case 4:
            Console.WriteLine("Voce escolheu a opção " + opcaoEscolhidaNumerica);
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

void ExibirTitulo(string titulo)
{
    int lengthTitulo = titulo.Length;
    string asteriscos = string.Empty.PadLeft(lengthTitulo, '-');

    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarBanda()
{
    Console.Clear();
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

ExibirOpcoesDoMenu();


//media carro

void MediaVendaCarros() {
    Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
        { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
        { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
        { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
        { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
        { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
    };

    Console.WriteLine($"A media de vendas do Koenigsegg Agera RS é {vendasCarros["Koenigsegg Agera RS"].Average()}");
}
