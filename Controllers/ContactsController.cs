using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using completed_project.Models;
using System.ComponentModel.DataAnnotations;
using completed_project.Models;

namespace completed_project.Controllers;

public class ContactsController : Controller
{
    #region Day 5

    readonly static List<Contact> contectNames = new List<Contact>
    {
        new Contact { Name = "Jannick" },
        new Contact{ Name = "Mohsen",Email="Mohsen.Bazmi@gmail.com",PhoneNumber="+989220480224",Website="https://ScenarioHunting.com" }
    };

    public IActionResult List()
    => View(contectNames);

    [HttpGet]
    public IActionResult Add()
    => View();


    [HttpPost]
    public IActionResult Add(Contact newContact)
    {
        contectNames.Add(newContact);
        return RedirectToAction(nameof(List));
    }

    [HttpGet]
    public IActionResult Details(string contactName)
    {
        //Challenge: 
        //1-The name should be passed only
        //2-The route needs to be changed {id?} ==> {contactName?}
        return View(contectNames.Single(c => c.Name == contactName));
    }

    [HttpPost]
    public IActionResult Delete(string name)//Challenge: The name should be passed only
    {
        contectNames.Remove(contectNames.Single(c => c.Name == name));
        return RedirectToAction(nameof(List));
    }

    #endregion Day 5
}

public class Contact
{
    [Display(Name = "Name")] public string Name { get; set; }

    [Display(Name = "Phone Number")] public string PhoneNumber { get; set; }

    [Display(Name = "Email")] public string Email { get; set; }

    [Display(Name = "Website")] public string Website { get; set; }
}