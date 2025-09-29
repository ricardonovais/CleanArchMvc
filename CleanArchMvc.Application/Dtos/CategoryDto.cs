#nullable disable

using System.ComponentModel.DataAnnotations;

namespace CleanArchMvc.Application.Dtos;

public class CategoryDto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [MinLength(3, ErrorMessage = "Name must have at least 3 characters")]
    [MaxLength(100, ErrorMessage = "Name must have a maximum of 100 characters")]
    public string Name { get; set; }
}
