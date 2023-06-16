using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.CodeDom.Compiler;
using System.Reflection.Metadata;
using System.Data;

namespace CompanyCarSharing
{
    public class Database
    {
        private readonly string connectionString = "Server=DESKTOP-V9AVE4C\\SQLEXPRESS;Database=IndividualFinalProjectSemester1;Integrated Security=True;";

        public void InsertCar(ICar car)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Cars (Brand, Model,EndOfLifeMilage,CurrentMilage,LicencePlate,MaintenanceInterval) " +
                                   "VALUES (@Brand, @Model, @EndOfLifeMilage,@CurrentMilage,@LicencePlate, @MaintenanceInterval)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Brand", car.Brand);
                        command.Parameters.AddWithValue("@Model", car.Model);
                        command.Parameters.AddWithValue("@EndOfLifeMilage", car.EndOfLifeMilage);
                        command.Parameters.AddWithValue("@CurrentMilage", car.CurrentMilage);
                        command.Parameters.AddWithValue("@LicencePlate", car.LicencePlate);
                        command.Parameters.AddWithValue("@MaintenanceInterval", car.MaintenanceInterval);


                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void UpdateMilage(ICar car, int EndMilage)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Cars SET CurrentMilage = @Milage WHERE Car_id = @ID"; 
                                   

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Milage", EndMilage);
                        command.Parameters.AddWithValue("@ID", car.ID);


                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public List<ICar> GetAllCars()
        {
            List<ICar> cars = new List<ICar>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "Select * from Cars where Retired = 0";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int Car_id = Convert.ToInt32(reader["Car_id"]);
                                string Brand = Convert.ToString(reader["Brand"]);
                                string Model = Convert.ToString(reader["Model"]);
                                int EndOfLife = Convert.ToInt32(reader["EndOfLifeMilage"]);
                                int CurrentLife = Convert.ToInt32(reader["CurrentMilage"]);
                                string LicencePlate = Convert.ToString(reader["LicencePlate"]);
                                int Maintenance = Convert.ToInt32(reader["MaintenanceInterval"]);

                                Car car = new Car();
                                car.AssignValuesToCarFromDatabase(Car_id, Brand, Model , EndOfLife, CurrentLife, LicencePlate, Maintenance);
                                cars.Add(car);
                            }
                        }
                    }
                    connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return cars;
        }
        public void DeleteCar(ICar car)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "Update Cars set Retired = 1 WHERE Car_id = @CarId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CarId", car.ID);
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void InsertEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Employees (FirstName, LastName,Email) " +
                                   "VALUES (@FirstName, @LastName, @Email)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                        command.Parameters.AddWithValue("@LastName", employee.LastName);
                        command.Parameters.AddWithValue("@Email", employee.Email);


                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "Select * from Employees";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int Employee_id = Convert.ToInt32(reader["Employee_id"]);
                                string FirstName = Convert.ToString(reader["FirstName"]);
                                string LastName = Convert.ToString(reader["LastName"]);
                                string Email = Convert.ToString(reader["Email"]);

                                Employee Employee = new Employee();
                                Employee.AssignValuesToEmployeeFromDatabase(Employee_id, FirstName, LastName, Email);
                                employees.Add(Employee);
                            }
                        }
                    }
                    connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return employees;
        }
        public void DeleteEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Employees WHERE Employee_ID = @empID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@empID", employee.EmployeeNumber);
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void InsertTrip(Trip trip)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Trips (Employee_ID, Car_ID,StartMilage, EndMilage,PrivateTrip) " +
                                   "VALUES (@Employee_ID, @Car_ID, @StartMilage, @EndMilage, @PrivateTrip)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Employee_ID", trip.Employee.EmployeeNumber);
                        command.Parameters.AddWithValue("@Car_ID", trip.CarUsed.ID);
                        command.Parameters.AddWithValue("@StartMilage", trip.StartMilage);
                        command.Parameters.AddWithValue("@EndMilage", trip.EndMilage);
                        command.Parameters.AddWithValue("@PrivateTrip", trip.PrivateTrip == true ? 1 : 0);


                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        // Returns a tuple with a Datatable for all the trips, The 2nd one is the summary that shows how much they have used a certain car, And the int is for the private kilometers
        public Tuple<DataTable, DataTable, int> GetAllEmployeeTrips(int id)
        {
            DataTable tripSummary = new DataTable();
            DataTable allTrips = new DataTable();
            int totalPrivateKilometers = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query for trip summary
                    string tripSummaryQuery = @"SELECT t.Employee_ID, SUM(EndMilage - StartMilage) AS total, (c.Brand + ' ' + c.Model) AS Car
                                        FROM trips t
                                        INNER JOIN Cars C ON C.Car_id = t.Car_ID
                                        WHERE t.Employee_ID = @ID
                                        GROUP BY t.Employee_ID, (c.Brand + ' ' + c.Model)
                                        ORDER BY t.Employee_ID, total DESC;";

                    using (SqlCommand summaryCommand = new SqlCommand(tripSummaryQuery, connection))
                    {
                        summaryCommand.Parameters.AddWithValue("@ID", id);
                        SqlDataAdapter summaryAdapter = new SqlDataAdapter(summaryCommand);
                        summaryAdapter.Fill(tripSummary);
                    }

                    // Query for all trips per employee
                    string allTripsQuery = @"SELECT E.Employee_ID, E.FirstName, C.Brand + ' ' + C.Model + ' ' + C.LicencePlate as Car, T.StartMilage, T.EndMilage, T.PrivateTrip
                                    FROM Trips T
                                    INNER JOIN Cars C ON C.Car_id = T.Car_ID
                                    INNER JOIN Employees E ON E.Employee_ID = T.Employee_ID
                                    WHERE T.Employee_ID = @ID
                                    ORDER BY E.Employee_ID, Car;";

                    using (SqlCommand allTripsCommand = new SqlCommand(allTripsQuery, connection))
                    {
                        allTripsCommand.Parameters.AddWithValue("@ID", id);
                        SqlDataAdapter allTripsAdapter = new SqlDataAdapter(allTripsCommand);
                        allTripsAdapter.Fill(allTrips);
                    }

                    // Query for getting total private kilometers
                    string privateKilometersQuery = @"SELECT SUM(EndMilage - StartMilage) AS private 
                                               FROM trips
                                               WHERE Employee_ID = @ID AND PrivateTrip = 1";

                    using (SqlCommand privateKilometersCommand = new SqlCommand(privateKilometersQuery, connection))
                    {
                        privateKilometersCommand.Parameters.AddWithValue("@ID", id);

                        totalPrivateKilometers = privateKilometersCommand.ExecuteScalar() != DBNull.Value ? Convert.ToInt32(privateKilometersCommand.ExecuteScalar()) : 0;
                    }

                    connection.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return new Tuple<DataTable, DataTable, int>(tripSummary, allTrips, totalPrivateKilometers);
        }

    }
}
