using CompanyCarSharing;

namespace testing
{
    public class UnitTest1
    {
        [Fact]
        public void AssignValuesToCar_SetsPropertiesCorrectly()
        {
            // Arrange
            ICar car = new Car();

            // Act
            car.AssignValuesToCar("Brand", "Model", 100000, 5000, "ABC123", 5000);

            // Assert
            Assert.Equal("Brand", car.Brand);
            Assert.Equal("Model", car.Model);
            Assert.Equal(100000, car.EndOfLifeMilage);
            Assert.Equal(5000, car.CurrentMilage);
            Assert.Equal("ABC123", car.LicencePlate);
            Assert.Equal(5000, car.MaintenanceInterval);
        }

        [Fact]
        public void AddMilage_IncrementsCurrentMilage()
        {
            // Arrange
            ICar car = new Car();
            car.AssignValuesToCar("Brand", "Model", 100000, 5000, "ABC123", 5000);

            // Act
            car.AddMilage(100);

            // Assert
            Assert.Equal(5100, car.CurrentMilage);
        }

        [Fact]
        public void ToString_ReturnsFormattedString()
        {
            // Arrange
            ICar car = new Car();
            car.AssignValuesToCar("Brand", "Model", 100000, 5000, "ABC123", 5000);

            // Act
            string result = car.ToString();

            // Assert
            Assert.Equal("Brand Model ABC123 5000KM driven", result);
        }

        // Add more unit tests for other methods and properties of ICar interface
    }

    public class EmployeeTests
    {
        [Fact]
        public void AssignValuesToNewEmployee_SetsPropertiesCorrectly()
        {
            // Arrange
            IEmployee employee = new Employee();

            // Act
            employee.AssignValuesToNewEmployee("John", "Doe", "john.doe@example.com");

            // Assert
            Assert.Equal("John", employee.FirstName);
            Assert.Equal("Doe", employee.LastName);
            Assert.Equal("john.doe@example.com", employee.Email);
        }

        [Fact]
        public void ToString_ReturnsFormattedString()
        {
            // Arrange
            IEmployee employee = new Employee();
            employee.AssignValuesToNewEmployee("John", "Doe", "john.doe@example.com");

            // Act
            string result = employee.ToString();

            // Assert
            Assert.Equal("John Doe john.doe@example.com", result);
        }
    }
}