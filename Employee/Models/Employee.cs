﻿namespace Employee.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public bool Active { get; set; }
    public int CompanyId { get; set; }

    public Company Company { get; set; }
}
