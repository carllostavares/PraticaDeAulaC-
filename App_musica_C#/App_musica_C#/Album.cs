class Album
{
	private List<Musica> musicas = new List<Musica>();
	public string Nome { get; set; }
	public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);
	//para cada musica soma a dura��o


	public void AdicionarMusica(Musica musica)
	{
		musicas.Add(musica);
	}

	public void ExibirAlbum()
	{
		Console.WriteLine($"Lsita de m�sicas do �lbum {Nome}:\n ");
		foreach (var musica in musicas)
		{
		Console.WriteLine($"M�sica: {musica.Nome}");
		}
		Console.WriteLine($"\nA dura��o do �lbum � {DuracaoTotal} segundos.");
	}

}