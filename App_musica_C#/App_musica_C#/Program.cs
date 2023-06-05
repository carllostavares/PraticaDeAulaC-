Musica musica1 = new Musica();
musica1.Nome = "Carlos";
musica1.Artista = "Vocal";
musica1.Duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);

Musica musica2 = new Musica();
musica2.Nome = "Priscila";
musica2.Artista = "Amada";
musica2.Duracao = 173;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();