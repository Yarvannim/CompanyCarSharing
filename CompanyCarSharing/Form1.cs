namespace CompanyCarSharing;

public partial class TheGreenMile : Form
{
    public Carpool _carpool = new Carpool();
    public Employees _employees = new Employees();
    public TheGreenMile()
    {
        InitializeComponent();
        Boot();
    }

    private void Boot()
    {
        foreach (Car car in _carpool.GetCars())
        {
            lbCars.Items.Add(car);
            lbTripsCars.Items.Add(car);
        }
        foreach (Employee employee in _employees.GetAllEmployees())
        {
            lbEmployees.Items.Add(employee);
            lbTripsEmployees.Items.Add(employee);
        }
    }
    #region Cars
    private void btnAddCar_Click(object sender, EventArgs e)
    {
        if (CheckCarsTextboxes())
        {
            _carpool.AddCarToPool(tbCarBrand.Text, tbCarModel.Text, Convert.ToInt32(nmrEndOfLife.Value), Convert.ToInt32(nmrCurrentMilage.Value), tbLicencePlate.Text, Convert.ToInt32(nmrMaintenanceInterval.Value));
            FillCarsList(_carpool.GetCars(), "All");
        }
    }

    private bool CheckCarsTextboxes()
    {
        bool AllFilledIn = true;
        foreach (Control control in gpCars.Controls)
        {
            if (AllFilledIn)
            {
                if (control is TextBox)
                {
                    AllFilledIn = !string.IsNullOrWhiteSpace(control.Text);
                }
            }
        }
        return AllFilledIn;
    }

    private void FillCarsList(List<Car> Cars, string location)
    {
        if (location == "Cars")
        {
            lbCars.Items.Clear();
            foreach (Car car in Cars)
            {
                lbCars.Items.Add(car);
            }
        }
        else if (location == "All")
        {
            lbCars.Items.Clear();
            lbTripsCars.Items.Clear();
            foreach (Car car in Cars)
            {
                lbCars.Items.Add(car);
                lbTripsCars.Items.Add(car);
            }
        }
        else
        {
            lbTripsCars.Items.Clear();
            foreach (Car car in Cars)
            {
                lbTripsCars.Items.Add(car);
            }
        }
    }

    private Car selectedCar()
    {
        Car selectedCar = (Car)lbCars.SelectedItem;
        if (selectedCar != null)
        {
            return selectedCar;
        }
        else
        {
            MessageBox.Show("Please select a car that you want to delete in the list", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return null;
        }
    }

    private void btnDeleteCar_Click(object sender, EventArgs e)
    {
        if (selectedCar() != null)
        {
            _carpool.RemoveCarFromPool(selectedCar());
            FillCarsList(_carpool.GetCars(), "All");
        }
    }

    private void FilterCars_Key_Up_Event(object sender, KeyEventArgs e)
    {
        if ((sender as TextBox).Tag == "Cars")
        {
            FilterForCarsTab();
        }
        else
        {
            FilterForTripsTab();
        }
    }

    private void FilterForCarsTab()
    {
        if (!string.IsNullOrWhiteSpace(tbFilterCars.Text))
        {
            FillCarsList(_carpool.GetFilteredCars(tbFilterCars.Text), "Cars");
        }
        else
        {
            FillCarsList(_carpool.GetCars(), "Cars");
        }
    }
    #endregion

    private void FilterForTripsTab()
    {
        if (!string.IsNullOrWhiteSpace(tbSearchCars.Text))
        {
            FillCarsList(_carpool.GetFilteredCars(tbSearchCars.Text), "Trips");
        }
        else
        {
            FillCarsList(_carpool.GetCars(), "Trips");
        }
    }

    private void btnNewEmployee_Click(object sender, EventArgs e)
    {
        if (CheckEmployeesTextboxes())
        {
            _employees.RegisterEmployee(tbFirstName.Text, tbLastName.Text, tbEmail.Text);
            FillEmployeesList();
        }
        else
        {
            MessageBox.Show("Please fill in all the necessary fields", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
    private bool CheckEmployeesTextboxes()
    {
        bool AllFilledIn = true;
        foreach (Control control in gpEmployees.Controls)
        {
            if (AllFilledIn)
            {
                if (control is TextBox)
                {
                    AllFilledIn = !string.IsNullOrWhiteSpace(control.Text);
                }
            }
        }
        return AllFilledIn;
    }
    private void FillEmployeesList()
    {
        lbEmployees.Items.Clear();
        lbTripsEmployees.Items.Clear();
        foreach (Employee employee in _employees.GetAllEmployees())
        {
            lbEmployees.Items.Add(employee);
            lbTripsEmployees.Items.Add(employee);
        }
    }

    private void btnDeleteEmployee_Click(object sender, EventArgs e)
    {
        if (selectedEmployee() != null)
        {
            _employees.RemoveEmployee(selectedEmployee());
            FillEmployeesList();
            ClearTripEmployeeInformation();
        }
    }
    private Employee selectedEmployee()
    {
        Employee selectedEmployee = (Employee)lbEmployees.SelectedItem;
        if (selectedEmployee != null)
        {
            return selectedEmployee;
        }
        else
        {
            MessageBox.Show("Please select an employee that you want to delete in the list", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return null;
        }
    }

    private void tbSearchEmployees_KeyUp(object sender, KeyEventArgs e)
    {
        if (tbSearchEmployees.Text.Length >= 3)
        {
            FillEmployeesListOnTripsPage(_employees.GetFilteredEmployees(tbSearchEmployees.Text));
        }
        else if (string.IsNullOrWhiteSpace(tbSearchEmployees.Text))
        {
            FillEmployeesListOnTripsPage(_employees.GetAllEmployees());
        }
    }

    private void FillEmployeesListOnTripsPage(List<Employee> employees)
    {
        foreach (Employee employee in employees)
        {
            lbEmployees.Items.Add(employee);
        }
    }

    private void lbTripsEmployees_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lbTripsEmployees.SelectedItem != null)
        {
            Employee SelectedEmployee = lbTripsEmployees.SelectedItem as Employee;
            tbTripsEmployeeNumber.Text = SelectedEmployee.EmployeeNumber.ToString();
            tbTripsFullName.Text = $"{SelectedEmployee.FirstName} {SelectedEmployee.LastName}";
            tbTripsEmployeeEmail.Text = SelectedEmployee.Email;
        }
        else
        {
            
        }
    }

    private void ClearTripEmployeeInformation()
    {
        tbTripsEmployeeEmail.Text = String.Empty;
        tbTripsEmployeeNumber.Text = String.Empty;
        tbTripsFullName.Text = String.Empty;
    }

    private void ClearTripCarInformation()
    {

        tbTripsCarNameAndModel.Text = string.Empty;
        tbTripsStartMilage.Text = string.Empty;
        nmrTripsEndMilage.Value = nmrTripsEndMilage.Minimum;
        tbTripsTotalKilometersDriven.Text = string.Empty;
    }

    private void lbTripsCars_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lbTripsCars.SelectedItem != null)
        {
            Car selectedCar = lbTripsCars.SelectedItem as Car;
            tbTripsCarNameAndModel.Text = $"{selectedCar.Brand} {selectedCar.Model}";
            tbTripsStartMilage.Text = selectedCar.CurrentMilage.ToString();
            nmrTripsEndMilage.Enabled = true;
            nmrTripsEndMilage.Minimum = selectedCar.CurrentMilage;
            nmrTripsEndMilage.Value = selectedCar.CurrentMilage;
        }
        else
        {
            
        }
    }

    private void nmrTripsEndMilage_ValueChanged(object sender, EventArgs e)
    {
        updateTotalKilometers();
    }

    private void btnRegisterTrip_Click(object sender, EventArgs e)
    {
        if (lbTripsCars.SelectedItem != null && lbTripsEmployees.SelectedItem != null)
        {
            Employee selectedEmployee = lbTripsEmployees.SelectedItem as Employee;
            Car selectedCar = lbTripsCars.SelectedItem as Car;
            Trip newTrip = new Trip();
            if (Convert.ToInt32(nmrTripsEndMilage.Value) > nmrTripsEndMilage.Minimum)
            {
                newTrip.CreateNewTrip(selectedEmployee, selectedCar, Convert.ToInt32(tbTripsStartMilage.Text), Convert.ToInt32(nmrTripsEndMilage.Value), cbPrivate.Checked);
                selectedCar.AddTrip(newTrip);
                FillCarsList(_carpool.GetCars(), "All");
            }
        }
        else
        {
            MessageBox.Show("Please select an employee and a car", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void updateTotalKilometers()
    {
        tbTripsTotalKilometersDriven.Text =
            (Convert.ToInt32(nmrTripsEndMilage.Value) - Convert.ToInt32(tbTripsStartMilage.Text)).ToString();
    }

    private void nmrTripsEndMilage_KeyUp(object sender, KeyEventArgs e)
    {
        updateTotalKilometers();
    }

    private void lbEmployees_DoubleClick(object sender, EventArgs e)
    {
        if (lbEmployees.SelectedItem != null)
        {
            Employee selectedEmployee = lbEmployees.SelectedItem as Employee;
            EmployeeTrips et = new EmployeeTrips(selectedEmployee);
            et.ShowDialog();
        }
    }
}