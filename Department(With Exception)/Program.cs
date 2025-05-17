namespace Department_With_Exception_;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            Department department = new Department("IT Department", 2);

            Employee emp1 = new Employee("Vilayat",24, 90000);
            Employee emp2 = new Employee("Abu",20, 60000);
            Employee emp3 = new Employee("Anar",25, 90000); 

            department.AddEmployee(emp1);
            department.AddEmployee(emp2);
            Console.WriteLine(department[0]); 
            Console.WriteLine(department[1]);

            department.AddEmployee(emp3);
        }
        catch (CapacityLimitException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

    }
}
