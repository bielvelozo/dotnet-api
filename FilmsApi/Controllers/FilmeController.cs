using FilmsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmsApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{

    private static List<Film> filmes = new List<Film>();
    private static int id = 0;

    [HttpPost]
    public IActionResult AdicionaFilme(
        [FromBody] Film film)
    {
        film.Id = id++;
        filmes.Add(film);
        return CreatedAtAction(nameof(RecuperaFilmePorId),
            new { id = film.Id },
            film);
    }

    [HttpGet]
    public IEnumerable<Film> RecuperaFilmes([FromQuery] int skip = 0, 
        [FromQuery] int take = 50)
    {
        return filmes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaFilmePorId(int id)
    {
        var filme = filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        return Ok(filme);
    }
}
        