using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCarSharing
{
    public class Employees
    {
        private List<Employee> _employees = new List<Employee>();
        public Employees()
        {

        }

        public void RegisterEmployee(int EmployeeID, string firstname, string lastname, string email)
        {
            Employee employee = new Employee();
            employee.AssignValuesToNewEmployee(EmployeeID, firstname, lastname,email);
            _employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            Employee employeeToRemove = _employees.First(e => e.EmployeeNumber == employee.EmployeeNumber);
            _employees.Remove(employeeToRemove);
        }

        public List<Employee> GetAllEmployees()
        {
            return _employees;
        }
        public List<Employee> GetFilteredEmployees(string searchQuery)
        {
            //returns a list of results if the search query matches either the licence plate, brand or the model
            return _employees.Where(e => e.FirstName.Contains(searchQuery) || e.LastName.Contains(searchQuery) || e.Email.Contains(searchQuery)).ToList();
        }
    }
}
