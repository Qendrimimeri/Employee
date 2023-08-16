using Employee.Models;
using Employee.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Employee.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();
}