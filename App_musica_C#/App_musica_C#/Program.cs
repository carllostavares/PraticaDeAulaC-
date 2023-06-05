Banda queem = new Banda();
queem.Nome = "Queem";

Album albumDoQueem = new Album();
albumDoQueem.Nome = "A night at the opera";

Musica musica1 = new Musica(queem);
musica1.Nome = "Love of my life";
musica1.Duracao = 213;

Musica musica2 = new Musica(queem);
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracao = 354;

albumDoQueem.AdicionarMusica(musica1);
albumDoQueem.AdicionarMusica(musica2);



queem.AdicionaAlbum(albumDoQueem);
queem.ExibirDicografia();
