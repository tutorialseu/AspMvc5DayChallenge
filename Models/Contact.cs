namespace completed_project.Models;

using System.ComponentModel.DataAnnotations;

public record Contact(string Name)
{
    [Display(Name = "Phone Number")] public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string? Website { get; set; }
}