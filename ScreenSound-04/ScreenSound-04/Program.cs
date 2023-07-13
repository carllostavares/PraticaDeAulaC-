using ScreenSound_04.Modelos;
using System.Net.Http.Json;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musica = JsonSerializer.Deserialize<List<Musica>>(resposta);

        musica[0].ExibirDetalhesDaMusica();
    }
    catch (Exception ex) 
    {
        Console.WriteLine($" Temos um problema: {ex.Message}");
          
    }

}
