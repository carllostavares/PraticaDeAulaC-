Banda queem = new Banda("Queem");

Album albumDoQueem = new Album("A night at the opera");

Musica musica1 = new Musica(queem, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};


Musica musica2 = new Musica(queem, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
}; 


albumDoQueem.AdicionarMusica(musica1);
albumDoQueem.AdicionarMusica(musica2);
queem.AdicionaAlbum(albumDoQueem);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueem.ExibirAlbum();
queem.ExibirDicografia();
