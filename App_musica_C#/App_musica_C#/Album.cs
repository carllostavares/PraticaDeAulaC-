class Album
{
	private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get;}
	public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);
	//para cada musica soma a duração

	public void AdicionarMusica(Musica musica)
	{
		musicas.Add(musica);
	}

	public void ExibirAlbum()
	{
		Console.WriteLine($"Lsita de músicas do álbum {Nome}:\n ");
		foreach (var musica in musicas)
		{
		Console.WriteLine($"Música: {musica.Nome}");
		}
		Console.WriteLine($"\nA duração do álbum é {DuracaoTotal} segundos.");
	}

}


public class Genero
{
	public string Nome { get; set; }

}