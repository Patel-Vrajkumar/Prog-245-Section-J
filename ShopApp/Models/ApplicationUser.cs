using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ShopApp.Models;

public class ApplicationUser : IdentityUser
{
    [Display(Name = "First Name")]
    [StringLength(50)]
    public string? FirstName { get; set; }

    [Display(Name = "Last Name")]
    [StringLength(50)]
    public string? LastName { get; set; }

    [Display(Name = "Street Address")]
    [StringLength(200)]
    public string? Address { get; set; }

    [Display(Name = "City")]
    [StringLength(100)]
    public string? City { get; set; }

    [Display(Name = "State / Province")]
    [StringLength(50)]
    public string? State { get; set; }

    [Display(Name = "Zip / Postal Code")]
    [StringLength(20)]
    public string? ZipCode { get; set; }

    [Display(Name = "Country")]
    [StringLength(60)]
    public string? Country { get; set; }
}
