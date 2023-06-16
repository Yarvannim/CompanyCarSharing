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

    // Function to fill both lists on startup
    private void Boot()
    {
        LogicHandler.FillList(lbCars, lbTripsCars, lbEmployees, lbTripsEmployees, _carpool.GetCars(), _employees.GetAllEmployees());
    }
    #region Cars
    // Function for adding a car to the carpool
    private void btnAddCar_Click(object sender, EventArgs e)
    {
        if (LogicHandler.AreAllTextboxesFilledIn(gpCars.Controls))
        {
            _carpool.AddCarToPool(tbCarBrand.Text, tbCarModel.Text, Convert.ToInt32(nmrEndOfLife.Value), Convert.ToInt32(nmrCurrentMilage.Value), tbLicencePlate.Text, Convert.ToInt32(nmrMaintenanceInterval.Value));
            FillCarsList(_carpool.GetCars(), "All");
        }
    }
    // Based on location parameter it fills the list 
    private void FillCarsList(List<ICar> Cars, string location)
    {
        switch (location)
        {
            case "Cars":
                LogicHandler.FillList(lbCars, Cars);
                break;
            case "All":
                LogicHandler.FillList(lbCars, lbTripsCars, Cars);
                break;
            default:
                LogicHandler.FillList(lbTripsCars, Cars);
                break;
        }
    }

    // Delete a car
    private void btnDeleteCar_Click(object sender, EventArgs e)
    {
        Car car = LogicHandler.GetSelectedCar(lbCars);
        if (car != null)
        {
            _carpool.RemoveCarFromPool(car);
            FillCarsList(_carpool.GetCars(), "All");
        }
    }

    // Filter cars based on if the tag is Cars or not. Function names explain what happens
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

    // Function that checks if the filter textbox is empty or not and fills it with everything if its empty and else filters it
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

    // Filter the car list in the trips tab
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

    // If the all the textboxes are filled in it creates a new employee
    private void btnNewEmployee_Click(object sender, EventArgs e)
    {
        if (LogicHandler.AreAllTextboxesFilledIn(gpEmployees.Controls))
        {
            _employees.RegisterEmployee(tbFirstName.Text, tbLastName.Text, tbEmail.Text);
            FillEmployeesList();
        }
    }
    // Fills the employee list in the employee tab and trips tab
    private void FillEmployeesList()
    {
        LogicHandler.FillList(lbEmployees, lbTripsEmployees, _employees.GetAllEmployees());
    }
    // Deletes the selected employee
    private void btnDeleteEmployee_Click(object sender, EventArgs e)
    {
        Employee emp = LogicHandler.GetSelectedEmployee(lbEmployees);
        if (emp != null)
        {
            _employees.RemoveEmployee(emp);
            FillEmployeesList();
            LogicHandler.ClearTripEmployeeInformation(tbTripsEmployeeEmail, tbTripsEmployeeNumber, tbTripsFullName);
        }
    }

    // Function that filters the employee if the filter text is more than 3 characters
    private void tbSearchEmployees_KeyUp(object sender, KeyEventArgs e)
    {
        if (tbSearchEmployees.Text.Length >= 3 && !string.IsNullOrWhiteSpace(tbSearchEmployees.Text))
        {
            FillEmployeesListOnTripsPage(_employees.GetFilteredEmployees(tbSearchEmployees.Text));
        }
        else if (string.IsNullOrWhiteSpace(tbSearchEmployees.Text))
        {
            FillEmployeesListOnTripsPage(_employees.GetAllEmployees());
        }
    }
    // Function to fill the employees list on the trips page
    private void FillEmployeesListOnTripsPage(List<IEmployee> employees)
    {
        LogicHandler.FillList(lbEmployees, employees);
    }

    // Function that changes the text based on which employee has been selected
    private void lbTripsEmployees_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (LogicHandler.GetSelectedEmployee(lbTripsEmployees) != null)
        {
            Employee selectedEmployee = LogicHandler.GetSelectedEmployee(lbTripsEmployees);
            LogicHandler.SetSelectedEmployeeInfo(selectedEmployee, tbTripsEmployeeNumber, tbTripsFullName, tbTripsEmployeeEmail);
        }
        else
        {
            MessageBox.Show("No employee selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Function that sets all the values in the trips tab for the car information
    private void lbTripsCars_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (LogicHandler.GetSelectedCar(lbTripsCars) != null)
        {
            Car selectedCar = LogicHandler.GetSelectedCar(lbTripsCars);
            LogicHandler.SetSelectedCarInfo(selectedCar, tbTripsCarNameAndModel, tbTripsStartMilage, nmrTripsEndMilage);
        }
    }

    // Function that triggers every time the end milage is changed
    private void nmrTripsEndMilage_ValueChanged(object sender, EventArgs e)
    {
        updateTotalKilometers();
    }

    // Function for registering a new trip
    private void btnRegisterTrip_Click(object sender, EventArgs e)
    {
        // if a car and employee have been selected
        if (LogicHandler.GetSelectedCar(lbTripsCars) != null && LogicHandler.GetSelectedEmployee(lbTripsEmployees) != null)
        {
            Trip newTrip = new Trip();
            if (Convert.ToInt32(nmrTripsEndMilage.Value) > nmrTripsEndMilage.Minimum)
            {
                // Set the trip information
                newTrip.CreateNewTrip(LogicHandler.GetSelectedEmployee(lbTripsEmployees), LogicHandler.GetSelectedCar(lbTripsCars), Convert.ToInt32(tbTripsStartMilage.Text), Convert.ToInt32(nmrTripsEndMilage.Value), cbPrivate.Checked);
                // Refresh the car information so the milage gets updated
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
        // Function that actually updates the kilometers textbox
        tbTripsTotalKilometersDriven.Text =
            (Convert.ToInt32(nmrTripsEndMilage.Value) - Convert.ToInt32(tbTripsStartMilage.Text)).ToString();
    }

    private void nmrTripsEndMilage_KeyUp(object sender, KeyEventArgs e)
    {
        // Function that triggers everytime a keypress has happened on the end milage textbox
        updateTotalKilometers();
    }
    // Function that shows all the trips of an employee when you double click on the employee
    private void lbEmployees_DoubleClick(object sender, EventArgs e)
    {
        if (LogicHandler.GetSelectedEmployee(lbEmployees) != null)
        {
            Employee selectedEmployee = LogicHandler.GetSelectedEmployee(lbEmployees);
            EmployeeTrips et = new EmployeeTrips(selectedEmployee);
            et.ShowDialog();
        }
    }
}