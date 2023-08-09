
using Microsoft.AspNetCore.Mvc;
using FilmesAPI.Models;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[Controller]")]
public class FilmeController : Controller
{

    private static List<Filme> filmes = new List<Filme>();
    private static int id = 0;

    [HttpPost]
    public void AdicionaFilme([FromBody]Filme filme)
    {
        filme.Id = id++;
        filmes.Add(filme);
        Console.WriteLine(filme.Titulo);
        Console.WriteLine(filme.Duracao);
        Console.WriteLine(filme.Genero);
        Console.WriteLine(filme.Id);
    }

    [HttpGet]
    public IEnumerable<Filme> RecuperarFilmes()
    {
        return filmes;
    }

    [HttpGet("{id}")]
    public Filme? RecuperaFilmePorID(int id)
    {
        return filmes.FirstOrDefault(filme => filme.Id == id);
    }
}
