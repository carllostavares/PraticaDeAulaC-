﻿Album albumDoQueem = new Album();
albumDoQueem.Nome = "A night at the opera";

Musica musica1 = new Musica();
musica1.Nome = "Love of my life";
musica1.Duracao = 213;

Musica musica2 = new Musica();
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracao = 354;

albumDoQueem.AdicionarMusica(musica1);
albumDoQueem.AdicionarMusica(musica2);

Banda queem = new Banda();
queem.Nome = "Queem";

queem.AdicionaAlbum(albumDoQueem);
queem.ExibirDicografia();
