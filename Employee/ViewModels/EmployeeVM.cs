using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Employee.ViewModels;

public class EmployeeVM
{
    [DataType(DataType.Text), Required(ErrorMessage = "Kjo fush esht e kerkuar")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Mosha esht e kerkuar")]
    public int Age { get; set; }

    [ValidateNever]
    public bool Active { get; set; }
}
