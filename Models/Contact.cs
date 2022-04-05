namespace completed_project.Models;

using System.ComponentModel.DataAnnotations;

public class Contact
{
    [Display(Name = "Name")] public string Name { get; set; }

    [Display(Name = "Phone Number")] public string PhoneNumber { get; set; }

    [Display(Name = "Email")] public string Email { get; set; }

    [Display(Name = "Website")] public string Website { get; set; }
}