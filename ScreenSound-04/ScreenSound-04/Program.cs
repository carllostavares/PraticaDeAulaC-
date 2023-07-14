using ScreenSound_04.Modelos;
using ScreenSound_04.Filtro;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musica = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarTodosOsGenerosMusicais(musica);
     
    }
    catch (Exception ex) 
    {
        Console.WriteLine($" Temos um problema: {ex.Message}");
          
    }

}
