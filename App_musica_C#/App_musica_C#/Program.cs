
Episodio ep1 = new Episodio(1, "Senhor do Aneis", 354);
ep1.AdicionaConvidados("Carlos");
ep1.AdicionaConvidados("Leia");
ep1.AdicionaConvidados("Priscila");


Episodio ep2 = new Episodio(2, "O hobbit", 454);
ep2.AdicionaConvidados("Naman");
ep2.AdicionaConvidados("Kauã");
ep2.AdicionaConvidados("Bruna");


Podecast podcast = new("Podcasat do Carlos","Tavares");
podcast.AdicionaEpisodio(ep1);
podcast.AdicionaEpisodio(ep2);
podcast.ExibirDetalhes();