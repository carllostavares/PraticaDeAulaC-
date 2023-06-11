using System.Linq.Expressions;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

/*TestaArrayInt();

void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do Array {idades.Length}");

    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"índice [{i}] = {idade}");
        acumulador += idade;
    }

    int media = acumulador / idades.Length;
    Console.WriteLine($"Média de idades = {media}");

}*/

void TestandoPalavra()
{
    string[] arrayDePalavra = new string[5];

    for (int i = 0;i < arrayDePalavra.Length;i++)
    {
        Console.WriteLine($"Digite a palavra de número {i + 1}");
        arrayDePalavra[i] = Console.ReadLine();
    }

Console.WriteLine("Digite a palavra que deseja pesquisar:");
string busca = Console.ReadLine();

    bool acertou = false;
    foreach (string palavra in arrayDePalavra)
    {
        
        if(palavra.Equals(busca))
        {
            acertou = true;
        }
    }

    switch (acertou)
    {
        case true:
            Console.WriteLine($"Palavra {busca} foi encontrada !");
            break;
        case false:
            Console.WriteLine($"Palavra {busca} não encontrada !");
            break;
        default:
            break;
    }


}

 TestandoPalavra();
