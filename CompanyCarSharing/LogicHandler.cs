using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCarSharing
{
    public class LogicHandler
    {
        public static void SetSelectedCarInfo(Car selectedCar, TextBox carNameAndModelTextBox, TextBox startMilageTextBox, NumericUpDown endMilageNumericUpDown)
        {
            carNameAndModelTextBox.Text = $"{selectedCar.Brand} {selectedCar.Model}";
            startMilageTextBox.Text = selectedCar.CurrentMilage.ToString();
            endMilageNumericUpDown.Enabled = true;
            endMilageNumericUpDown.Minimum = selectedCar.CurrentMilage;
            endMilageNumericUpDown.Value = selectedCar.CurrentMilage;
        }
        public static void SetSelectedEmployeeInfo(Employee selectedEmployee, TextBox employeeNumberTextBox, TextBox fullNameTextBox, TextBox emailTextBox)
        {
            employeeNumberTextBox.Text = selectedEmployee.EmployeeNumber.ToString();
            fullNameTextBox.Text = $"{selectedEmployee.FirstName} {selectedEmployee.LastName}";
            emailTextBox.Text = selectedEmployee.Email;
        }
        public static void ClearTripEmployeeInformation(TextBox tbTripsEmployeeEmail, TextBox tbTripsEmployeeNumber, TextBox tbTripsFullName) 
        {
            tbTripsEmployeeEmail.Text = String.Empty;
            tbTripsEmployeeNumber.Text = String.Empty;
            tbTripsFullName.Text = String.Empty;
        }
        public static bool AreAllTextboxesFilledIn(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Please fill in all the necessary fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        public static Car GetSelectedCar(ListBox listBox)
        {
            Car selectedCar = listBox.SelectedItem as Car;
            if (selectedCar == null)
            {
                MessageBox.Show("Please select a car in the list", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return selectedCar;
        }

        public static Employee GetSelectedEmployee(ListBox listBox)
        {
            Employee selectedEmployee = listBox.SelectedItem as Employee;
            if (selectedEmployee == null)
            {
                MessageBox.Show("Please select an employee in the list", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return selectedEmployee;
        }

        public static void FillList(ListBox listbox, IEnumerable<object> objectlist)
        {
            listbox.Items.Clear();
            listbox.Items.AddRange(objectlist.ToArray());
        }
        public static void FillList(ListBox listbox, ListBox listbox2, IEnumerable<object> objectlist)
        {
            listbox.Items.Clear();
            listbox2.Items.Clear();
            listbox.Items.AddRange(objectlist.ToArray());
            listbox2.Items.AddRange(objectlist.ToArray());
        }
        public static void FillList(ListBox listbox, ListBox listbox2, ListBox listbox3, ListBox listbox4, IEnumerable<object> objectlist, IEnumerable<object> objectlist2)
        {
            listbox.Items.AddRange(objectlist.ToArray());
            listbox2.Items.AddRange(objectlist.ToArray());
            listbox3.Items.AddRange(objectlist2.ToArray());
            listbox4.Items.AddRange(objectlist2.ToArray());
        }
    }
}
