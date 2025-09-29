#nullable disable

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchMvc.Application.Dtos;

public class ProductDto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [MinLength(3, ErrorMessage = "Name must have at least 3 characters")]
    [MaxLength(100, ErrorMessage = "Name must have a maximum of 100 characters")]
    [DisplayName("Name")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Description is required")]
    [MinLength(5, ErrorMessage = "Description must have at least 5 characters")]
    [MaxLength(200, ErrorMessage = "Description must have a maximum of 200 characters")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Price is required")]
    [Column(TypeName = "decimal(18,2)")]
    [DisplayFormat(DataFormatString = "{0:C2}")]
    [DataType(DataType.Currency)]
    [DisplayName("Price")]

    public decimal Price { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "The stock must be greater than zero")]
    public int Stock { get; set; }

    [Display(Name = "Image URL")]
    public string Image { get; set; }

    [Display(Name = "Category")]
    [Required(ErrorMessage = "Category is required")]
    public int CategoryId { get; set; }
    public CategoryDto Category { get; set; }
}
