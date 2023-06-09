using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyCarSharing
{
    public partial class EmployeeTrips : Form
    {
        Trip trip = new Trip();
        Employee emp;
        public EmployeeTrips(Employee emp)
        {
            InitializeComponent();
            this.emp = emp;
            fillTotalList();
        }
        private void fillTotalList()
        {
            Tuple<DataTable, DataTable, int> EmployeeData = trip.GetEmployeeInfo(emp.EmployeeNumber);
            lbTotalPerCar.Items.Add($"Total private kilometers {EmployeeData.Item3}");
            foreach (DataRow data in EmployeeData.Item1.Rows)
            {
                lbTotalPerCar.Items.Add($"Kilometers: {data["total"]} - Auto: {data["Car"]}");
            }
            foreach (DataRow data in EmployeeData.Item2.Rows)
            {
                lbTrips.Items.Add($"Car: {data["Car"]} | Start milage: {data["StartMilage"]} | End milage: {data["EndMilage"]} | Private: {(Convert.ToInt32(data["PrivateTrip"]) == 1 ? "Yes" : "No")}");
            }
        }
    }
}
