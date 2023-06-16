using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class ICarTests
    {
        [TestMethod]
        public void AssignValuesToCar_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            Mock<ICar> carMock = new Mock<ICar>();
            carMock.SetupProperty(c => c.Brand);
            carMock.SetupProperty(c => c.Model);
            carMock.SetupProperty(c => c.EndOfLifeMilage);
            carMock.SetupProperty(c => c.CurrentMilage);
            carMock.SetupProperty(c => c.LicencePlate);
            carMock.SetupProperty(c => c.MaintenanceInterval);

            ICar car = carMock.Object;

            // Act
            car.AssignValuesToCar("Brand", "Model", 100000, 50000, "ABC123", 5000);

            // Assert
            Assert.AreEqual("Brand", car.Brand);
            Assert.AreEqual("Model", car.Model);
            Assert.AreEqual(100000, car.EndOfLifeMilage);
            Assert.AreEqual(50000, car.CurrentMilage);
            Assert.AreEqual("ABC123", car.LicencePlate);
            Assert.AreEqual(5000, car.MaintenanceInterval);
        }

        [TestMethod]
        public void AddMilage_ShouldIncreaseCurrentMilage()
        {
            // Arrange
            Mock<ICar> carMock = new Mock<ICar>();
            carMock.SetupProperty(c => c.CurrentMilage, 50000);

            ICar car = carMock.Object;

            // Act
            car.AddMilage(100);

            // Assert
            Assert.AreEqual(50100, car.CurrentMilage);
        }
    }
}
