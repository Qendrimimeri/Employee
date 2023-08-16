using Employee.Data;
using Employee.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Employee.Controllers;

public class EmployeeController : Controller
{
    private readonly AppDbContext _context;

    public EmployeeController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var employees = await _context.Employees.ToListAsync();
        return View(employees);
    }



    [HttpGet]
    public async Task<IActionResult> Details(int id)
    {
        var employee = await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);
        return View(employee);
    }

    #region Add Employee

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(EmployeeVM model)
    {
        if (ModelState.IsValid)
        {
            var employee = new Models.Employee()
            {
                Name = model.Name,
                Active = model.Active,
                Age = model.Age,
                CompanyId = 1
            };

            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
        }
        return RedirectToAction("Index");
    }


    #endregion



    #region Edit Employee

    [HttpGet]
    public IActionResult Edit()
    {
        return View();
    }

    [HttpPut]
    public IActionResult Edit(EmployeeVM model)
    {
        return View();
    }


    #endregion
                
    public async Task<IActionResult> Delete(int id)
    {
        var employee = await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);

         _context.Employees.Remove(employee);
        await _context.SaveChangesAsync();
        return RedirectToAction("Index");
    }
}
