using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopApp.Models;

public class Product
{
    public int Id { get; set; }

    [Required]
    [StringLength(150)]
    public string Name { get; set; } = string.Empty;

    [StringLength(1000)]
    public string? Description { get; set; }

    [Required]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    [Range(0.01, 1_000_000, ErrorMessage = "Price must be between 0.01 and 1,000,000.")]
    public decimal Price { get; set; }

    [Required]
    [StringLength(100)]
    [Display(Name = "Category")]
    public string Category { get; set; } = string.Empty;

    [Range(0, int.MaxValue, ErrorMessage = "Stock quantity cannot be negative.")]
    [Display(Name = "Stock Quantity")]
    public int StockQuantity { get; set; }

    [StringLength(500)]
    [Display(Name = "Image URL")]
    public string? ImageUrl { get; set; }

    [Display(Name = "Created")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [Display(Name = "Last Updated")]
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
