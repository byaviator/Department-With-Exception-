using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_With_Exception_;

class Department
{
    public string Name { get; private set; }
    public int EmployeeLimit { get; private set; }
    private Employee[] employees;
    private int count;

    public Department(string name, int employeeLimit)
    {
        Name = name;
        EmployeeLimit = employeeLimit;
        employees = new Employee[employeeLimit];
        count = 0;
    }

    public void AddEmployee(Employee employee)
    {
        if (count >= EmployeeLimit)
        {
            throw new CapacityLimitException("Employee limit exceeded!");
        }
        employees[count++] = employee;
    }

    public Employee this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            return employees[index];
        }
        set
        {
            if (index < 0 || index >= EmployeeLimit)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            employees[index] = value;
        }
    }
}

