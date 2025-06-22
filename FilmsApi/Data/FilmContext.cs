using FilmsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmsApi.Data;

public class FilmContext : DbContext
{
    public FilmContext(DbContextOptions<FilmContext> options)
        : base(options)
    {
    }
    
    public DbSet<Film> Films { get; set; }
}