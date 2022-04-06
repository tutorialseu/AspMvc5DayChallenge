namespace completed_project.Models;

using System.ComponentModel.DataAnnotations;

public record Contact(string Name)
{
    [Display(Name = "Phone Number")] public string? PhoneNumber { get; set; }
    [Display(Name = "Email")] public string? Email { get; set; }
    [Display(Name = "Website")] public string? Website { get; set; }
}