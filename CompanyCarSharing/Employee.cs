using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCarSharing
{
    public class Employee : IEmployee
    {
        private int _employeeNumber;

        public int EmployeeNumber
        {
            get { return _employeeNumber; }
        }
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
        }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
        }

        public Employee()
        {

        }
        // Assign values to the New employee
        public void AssignValuesToNewEmployee(string firstname, string lastname, string email)
        {
            this._firstName = firstname;
            this._lastName = lastname;
            this._email = email;
        }

        // Function to use to create new employee objects from the database
        public void AssignValuesToEmployeeFromDatabase(int id,string firstname, string lastname, string email)
        {
            this._employeeNumber = id;
            this._firstName = firstname;
            this._lastName = lastname;
            this._email = email;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Email}";
        }
    }
}
