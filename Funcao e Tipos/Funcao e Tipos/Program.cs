string mensagemDeBoasVindas = "Hello, colega!! Bem vinda";

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
        case 1: Console.WriteLine("Voce escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 2: Console.WriteLine("Voce escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 3: Console.WriteLine("Voce escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("Voce escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1: Console.WriteLine("Tchau tchau ");
            break;
        default: Console.WriteLine("Opcao inválida!");
            break;
    }
}

//atividade não obrigatória

void AdivinhacaoNumeroAleatorio()
{
    Random rnd = new Random();
    int numRandom = rnd.Next(1,101);
    int numChute = 0;

    do
    {
        Console.WriteLine("Chute um número entre 1 e 100!");
        numChute = int.Parse(Console.ReadLine()!);

        if (numChute > numRandom)
        {
            Console.WriteLine("\nO número é menor");
        }
        else if (numChute < numRandom)
        {
            Console.WriteLine("\nO número é maior");
        }
        else if (numChute == numRandom)
        {
            Console.WriteLine("\nVocê acertou! O número é " + numRandom);
        }
    } while (numChute != numRandom);
}


ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();
AdivinhacaoNumeroAleatorio();
