using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCarSharing
{
    public class Carpool
    {
        //List for saving every car in the carpool
        private List<Car> _cars = new List<Car>();
        Database db = new Database();
        public Carpool()
        {

        }

        public void AddCarToPool(string brand, string model, int endoflife, int currentkm, string licenceplate, int maintenanceIntervalKM)
        {
            // looks if the licence plate exists in the list of cars
            // if the car does not exist then it will create the new car and add it to the list
            if (!_cars.Any(c => c.LicencePlate == licenceplate))
            {
                Car newCar = new Car();
                newCar.AssignValuesToCar(brand,model, endoflife, currentkm, licenceplate, maintenanceIntervalKM);
                _cars.Add(newCar);
                db.InsertCar(newCar);
            }
            else
            {
                MessageBox.Show("A car with this licence plate has already been registered", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Car> GetFilteredCars(string searchQuery)
        {
            //returns a list of results if the search query matches either the licence plate, brand or the model
            return _cars.Where(c => c.LicencePlate.Contains(searchQuery) || c.Brand.Contains(searchQuery) || c.Model.Contains(searchQuery)).ToList();
        }

        public void RemoveCarFromPool(Car car)
        {
            _cars.Remove(car);
            db.DeleteCar(car);
        }
        public List<Car> GetCars()
        {
            return db.GetAllCars();
        }
    }
}
