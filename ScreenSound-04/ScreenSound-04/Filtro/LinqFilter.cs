using ScreenSound_04.Modelos;
using System.Security.Cryptography.X509Certificates;

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

    public  static void FiltrarMusicaDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista))
            .ToList();
        Console.WriteLine(nomeDoArtista);
        foreach(var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
            Console.WriteLine($"- {musica.Nome}");
        }

 
    }

    internal static void FiltrarMusicaEmCSharp(List<Musica> musicas)
    {
        var musicaEmCSharp = musicas.Where(musica => musica.Tonalidade.Equals("C#")).ToList();

        foreach (var musica in musicaEmCSharp)
        {
            Console.WriteLine($"{musica.Nome} ");
            Console.WriteLine($"{musica.Tonalidade}");
        }
    }
}

