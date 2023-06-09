using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCarSharing
{
    public class Car
    {
        private List<Trip> _trips = new List<Trip>();
        private int _id;

        public int ID
        {
            get { return _id; }
        }

        private string _brand;

        public string Brand
        {
            get { return _brand; }
        }
        private string _model;

        public string Model
        {
            get { return _model; }
        }
        private int _endOfLifeMilage;

        public int EndOfLifeMilage
        {
            get { return _endOfLifeMilage; }
        }
        private int _currentMilage;

        public int CurrentMilage
        {
            get { return _currentMilage; }
        }
        private string _licencePlate;

        public string LicencePlate
        {
            get { return _licencePlate; }
        }
        private int _maintenanceInterval;

        public int MaintenanceInterval
        {
            get { return _maintenanceInterval; }

        }



        public Car()
        {

        }

        public void AssignValuesToCar(string brand, string model,int endoflife, int currentkm,string licenceplate, int maintenanceIntervalKM)
        {
            this._brand = brand;
            this._model = model;
            this._endOfLifeMilage = endoflife;
            this._currentMilage = currentkm;
            this._licencePlate = licenceplate;
            this._maintenanceInterval = maintenanceIntervalKM;
        }
        public void AssignValuesToCarFromDatabase(int ID,string brand, string model, int endoflife, int currentkm, string licenceplate, int maintenanceIntervalKM)
        {
            this._id = ID;
            this._brand = brand;
            this._model = model;
            this._endOfLifeMilage = endoflife;
            this._currentMilage = currentkm;
            this._licencePlate = licenceplate;
            this._maintenanceInterval = maintenanceIntervalKM;
        }
        public void AddMilage(int Kilometers)
        {
            _currentMilage += Kilometers;
        }

        public override string ToString()
        {
            return $"{Brand} {Model} {LicencePlate} {CurrentMilage}KM driven";
        }

        public void AddTrip(Trip trip)
        {
            _trips.Add(trip);
            AddMilage(trip.Kilometers);
        }
    }
}
