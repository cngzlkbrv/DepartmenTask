using DepartmentTask.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentTask.Models
{
    internal class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        Employee [] employees = new Employee[0];
        public Department(string name,int employeeLimit)
        {
            Name = name;
            EmployeeLimit = employeeLimit;
            
        }

        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref employees, employees.Length+1);
            if (employees.Length < EmployeeLimit ) {
                employees[employees.Length-1] = employee;
            }
            else
            {
                throw new  CapacityLimitException("Kapasiteni kecdiz");
            }

        }
    }
}
