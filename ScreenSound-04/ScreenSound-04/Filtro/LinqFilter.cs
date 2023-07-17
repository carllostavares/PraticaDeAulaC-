using ScreenSound_04.Modelos;
namespace ScreenSound_04.Filtro;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => 
        generos.Genero).Distinct().ToList();
        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarPorGeneroMusical(List<Musica>musica,string genero)
    {
        var artistasPorGeneroMusical = musica.Where(musica =>
        musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct()
        .ToList();
        Console.WriteLine($"Exibindo os artistas por genero musical >>> {genero}");
        foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");

        }
    }
}
