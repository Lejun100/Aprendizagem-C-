//Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen sound";
string digiteOpcao = "Por favor, digite uma das opções abaixo para prosseguirmos: ";
//List<string> listaDasBandas = new List<string> { "U2", "Blink182", "MGK" };

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("Blink", new List<int> {10, 9, 7 });  

void ExibirLogo()
{
    Console.WriteLine(@"
     Screen Sound!!!
");    

    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine(digiteOpcao);  
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opçaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
      
    switch(opçaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
                break;
            case 2: MostrarBandasRegistradas();
                break; 
            case 3: AvaliarUmaBanda();
                break;
            case 4: ExibirMedia();
                break;
            case -1: Console.WriteLine("Sayonara ^w^");
            break;
        default: Console.WriteLine("Opção inválida");
            break;

    }



       // if (opçaoEscolhidaNumerica == 1)
   // {
     //   Console.WriteLine("Você digitou a opção" + opcaoEscolhida);
  //  }
  //  else if (opçaoEscolhidaNumerica == 2)
   // {
   //     Console.WriteLine("Você digitou a opção" + opcaoEscolhida);
  //  }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.WriteLine("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");
   
    //for (int i = 0; i < listaDasBandas.Count; i++)    //vai entender que precisa percorrer toda as bandas registradas
   // {
     //   Console.WriteLine($"Banda: {listaDasBandas[i]}");
   // }
   
    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    
    
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
}

void AvaliarUmaBanda()
{
    //digite qual banda deseja avaliar
    // se a banda existir no dicionário >> atribuir uma nota
    // senão, volta ao menu principal

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal: ");
        Console.ReadKey();
        ExibirOpcoesDoMenu();           
    }
}


void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média da banda");
    Console.WriteLine("Digite o nome da banda para exibir a nota média da banda");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDasBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDasBanda.Average()}.");

    }else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu");
    }
}

ExibirLogo();
ExibirOpcoesDoMenu();

