using Employee.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Employee.Controllers.Me;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private List<Models.Employee> _employees = new();
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // form 1
        _employees.Add(
            new Models.Employee
            {
                Id = 1,
                Name = "Test",
                Age = 23
            });

        _employees.Add(
            new Models.Employee
            {
                Id = 2,
                Name = "Test 2",
                Age = 25
            });


        // form 2
        var data = new List<Models.Employee>()
        {
            new Models.Employee
            {
                Id = 3,
                Name = "Test 3",
                Age = 44,
                Active = true
            },
            new Models.Employee
            {
                Id = 4,
                Name = "Tes 4",
                Age = 20,
                Active = false
            },
            new Models.Employee
            {
                Id = 5,
                Name = "Test 5",
                Age = 20,
                Active = true
            }
        };
        _employees = data;
        return View(_employees);
    }
    [HttpGet("id")]
    public IActionResult Privacy(int id)
    {
        return View();
    }


    public IActionResult AboutUs()
    {
        return View("Contacts");
    }



    public IActionResult Details(int id)
    {
        var data = new List<Models.Employee>()
        {
            new Models.Employee
            {
                Id = 3,
                Name = "Test 3",
                Age = 23
            },
            new Models.Employee
            {
                Id = 4,
                Name = "Tes 4",
                Age = 23
            },
            new Models.Employee
            {
                Id = 5,
                Name = "Test 5",
                Age = 23
            }
        };
        _employees = data;
        var employee = _employees.FirstOrDefault(x => x.Id == id);
        return View(employee);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}