﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCarSharing
{
    public class Employees
    {
        private List<Employee> _employees = new List<Employee>();
        private Database db = new Database();
        public Employees()
        {

        }

        public void RegisterEmployee(string firstname, string lastname, string email)
        {
            Employee employee = new Employee();
            employee.AssignValuesToNewEmployee(firstname, lastname,email);
            _employees.Add(employee);
            db.InsertEmployee(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            db.DeleteEmployee(employee);
        }

        public List<Employee> GetAllEmployees()
        {
            //returns a list of all employees
            return db.GetAllEmployees();
        }
        public List<Employee> GetFilteredEmployees(string searchQuery)
        {
            //returns a list of results if the search query matches either the licence plate, brand or the model
            return _employees.Where(e => e.FirstName.Contains(searchQuery) || e.LastName.Contains(searchQuery) || e.Email.Contains(searchQuery)).ToList();
        }
    }
}
