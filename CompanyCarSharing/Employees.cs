using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCarSharing
{
    public class Employees
    {
        private List<IEmployee> _employees = new List<IEmployee>();
        private Database db = new Database();
        public Employees()
        {

        }

        public void RegisterEmployee(string firstname, string lastname, string email)
        {
            IEmployee employee = new Employee();
            employee.AssignValuesToNewEmployee(firstname, lastname,email);
            _employees.Add(employee);
            db.InsertEmployee(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            db.DeleteEmployee(employee);
        }

        public List<IEmployee> GetAllEmployees()
        {
            //returns a list of all employees
            List<IEmployee> e = db.GetAllEmployees();
            _employees = e;
            return e;
        }
        public List<IEmployee> GetFilteredEmployees(string searchQuery)
        {
            //returns a list of results if the search query matches either the licence plate, brand or the model
            return _employees.Where(e => e.FirstName.ToLower().Contains(searchQuery.ToLower()) || e.LastName.ToLower().Contains(searchQuery.ToLower()) || e.Email.ToLower().Contains(searchQuery.ToLower())).ToList();
        }
    }
}
