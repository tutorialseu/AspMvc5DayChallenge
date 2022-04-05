using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using completed_project.Models;

namespace completed_project.Controllers;

public class ContactNamesController : Controller
{
    #region Day 2

    readonly static List<string> conteactNames = new List<string>{
        "Jannick", "Mohsen"
    };

    public IActionResult List()
    => View(conteactNames);

    #endregion Day 2

    #region Day 3

    [HttpGet]
    public IActionResult Add()
    => View();


    [HttpPost]
    public IActionResult Add(string newContact)
    {
        conteactNames.Add(newContact);
        return RedirectToAction("List");
    }

    #endregion Day 3

    #region Day 4

    public IActionResult Details(string contact)
    => View("details", contact);


    [HttpPost]
    public IActionResult Delete(string contact)
    {
        conteactNames.Remove(contact);
        return RedirectToAction("list");
    }

    #endregion Day 4

}