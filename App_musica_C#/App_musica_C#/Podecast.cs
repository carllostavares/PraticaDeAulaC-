class Podecast
{
    private List<Episodio> episodios = new List<Episodio>();
    public Podecast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; set; }
    public string Host { get; set; }

    public int TotalEpisodio { get; set; }

    public void AdicionaEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
        
    }

}