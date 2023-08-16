﻿namespace Employee.Models;

public class Company
{
    public Company()
    {
        Employees = new HashSet<Employee>();
    }

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;


    public ICollection<Employee> Employees { get; set; }
}
