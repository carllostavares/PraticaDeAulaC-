using ScreenSound_04.Modelos;
using ScreenSound_04.Filtro;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musica = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //musica[0].ExibirDetalhesDaMusica();

        LinqFilter.FiltrarMusicaEmCSharp(musica);

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musica);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musica);
        //LinqFilter.FiltrarPorGeneroMusical(musica,"rock");
        //LinqFilter.FiltrarMusicaDeUmArtista(musica, "Hinder");

        //var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        //musicasPreferidasDoDaniel.AdicionarMusicaFavorita(musica[2]);
        //musicasPreferidasDoDaniel.AdicionarMusicaFavorita(musica[6]);
        //musicasPreferidasDoDaniel.AdicionarMusicaFavorita(musica[20]);
        //musicasPreferidasDoDaniel.AdicionarMusicaFavorita(musica[12]);

        //musicasPreferidasDoDaniel.ExibirMusicasFavoritas();

        //musicasPreferidasDoDaniel.GerarArquivoJson();


        //var musicasFavoritasDoGuilherme = new MusicasPreferidas("Guilherme");
        //musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(musica[980]);
        //musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(musica[513]);
        //musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(musica[1024]);
        //musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(musica[999]);
        //musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(musica[37]);

        //musicasFavoritasDoGuilherme.GerarDocumentoTXTComAsMusicasFavoritas();

    }
    catch (Exception ex) 
    {
        Console.WriteLine($" Temos um problema: {ex.Message}");
          
    }

}
