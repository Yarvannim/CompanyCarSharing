using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCarSharing
{
    public interface IEmployee
    {
        int EmployeeNumber { get; }
        string FirstName { get; }
        string LastName { get; }
        string Email { get; }

        void AssignValuesToNewEmployee(string firstname, string lastname, string email);
        void AssignValuesToEmployeeFromDatabase(int id, string firstname, string lastname, string email);
        string ToString();
    }
}
