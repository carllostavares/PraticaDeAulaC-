class Banda
{
    private List<Album> albuns = new List<Album>();
    public string Nome { get; set; }

    public void AdicionaAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDicografia()
    {
        Console.WriteLine($"Discografia da Bnada {Nome}");

        foreach(Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal}) ");
        }
    }

}