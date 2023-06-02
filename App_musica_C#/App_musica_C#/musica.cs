class Musica
{
    public string Nome { get; set; }
    public string artista { get; set; }
    public int duracao { get; set; }
    public bool Disponivel{get; set;}

    public void ExibirFichaTecnica()

    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (disponível)
        {
            Console.WriteLine("Disponível para plano!");
        }else
        {
            Console.WriteLine("Não disponível para plano!");
        }
    }



} 