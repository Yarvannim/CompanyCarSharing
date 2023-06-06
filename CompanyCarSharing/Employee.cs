using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCarSharing
{
    public class Employee
    {
        private List<Trip> _trips = new List<Trip>();
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
        //remove the employeenumber once you have a functioning database
        public void AssignValuesToNewEmployee(int employeeNumber, string firstname, string lastname, string email)
        {
            this._employeeNumber = employeeNumber;
            this._firstName = firstname;
            this._lastName = lastname;
            this._email = email;
        }

        public override string ToString()
        {
            return $"{EmployeeNumber} {FirstName} {LastName}";
        }

        public void AddTrip(Trip trip)
        {
            _trips.Add(trip);
        }
    }
}
