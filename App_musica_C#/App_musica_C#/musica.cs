class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponível;

    public void ExibirFichaTecnica()

    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (disponível)
        {
            Console.WriteLine("Disponível para plano!");
        }else
        {
            Console.WriteLine("Não disponível para plano!");
        }
    }



} 