using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_With_Exception_;

class Employee
{
    private static int nextId = 1; 
    public int Id { get; }
    public string Name { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, int age, decimal salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
        Id = nextId++;
    }

    public string ShowInfo()
    {
        return $"Employee ID: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}";
    }

    public override string ToString()
    {
        return ShowInfo();
    }
}

