using System.ComponentModel.DataAnnotations;

namespace FilmsApi.Models;

public class Film
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "Movie title is required")]
    public string Title { get; set; }

    [Required(ErrorMessage = "The movie genre is required")]
    [MaxLength(50, ErrorMessage = "The size of movie genre is too long")]
    public string Genre { get; set; }

    [Required]
    [Range(70, 600, ErrorMessage = "The duration is too long")]
    public int Duration { get; set; }
}