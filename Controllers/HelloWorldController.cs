using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using completed_project.Models;

public class HelloWorldController : Controller
{
    #region  Day1

    public IActionResult Index()
    => View("index", "Hello World");

    #endregion  Day1
}