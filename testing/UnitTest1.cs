using CompanyCarSharing;

namespace testing
{
    public class UnitTest1
    {
        [Collection("UnitTest")]
        public class CarTests
        {
            private ICar CreateCar()
            {
                return new Car();
            }

            [Fact]
            public void AddMilage_ShouldIncreaseCurrentMilage()
            {
                // Arrange
                ICar car = CreateCar();
                car.AssignValuesToCar("Brand", "Model", 100000, 50000, "ABC123", 5000);

                // Act
                car.AddMilage(100);

                // Assert
                Assert.Equal(50100, car.CurrentMilage);
            }

        }
    }
}