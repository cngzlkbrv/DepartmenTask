using DepartmentTask.Exceptions;
using DepartmentTask.Models;

Employee employee1 = new Employee("Melik", 20, 10000);
Employee employee2 = new Employee("Mamed", 20, 500);
Department department = new Department("Eliller", 1);

try
{
department.AddEmployee(employee1);
department.AddEmployee(employee2);


}
catch(CapacityLimitException ex)
{
    Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
} 