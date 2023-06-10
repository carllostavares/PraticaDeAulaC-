Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

TestaArrayInt();

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

}


int[,] numeros = new int[3,6];

numeros[0,1] = 9 ;
numeros[0,2] = 10;
numeros[0,3] = 8;

Console.WriteLine($"{numeros[0,1]}, {numeros[0, 2]}, {numeros[0, 3]}");