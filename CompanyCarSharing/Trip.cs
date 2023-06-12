using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCarSharing
{
    public class Trip
    {
        Database db = new Database();
        private Employee _employee;

        public Employee Employee
        {
            get { return _employee; }
        }
        private Car _carUsed;

        public Car CarUsed
        {
            get { return _carUsed; }
            set { _carUsed = value; }
        }

        private int _startMilage;

        public int StartMilage
        {
            get { return _startMilage; }
            set { _startMilage = value; }
        }
        private int _endMilage;

        public int EndMilage
        {
            get { return _endMilage; }
            set { _endMilage = value; }
        }
        private int _kilometers;

        public int Kilometers
        {
            get { return _kilometers; }
            set { _kilometers = value; }
        }
        private bool _privateTrip;

        public bool PrivateTrip
        {
            get { return _privateTrip; }
            set { _privateTrip = value; }
        }
        public Trip()
        {

        }
        // Function to set the trip values
        public void CreateNewTrip(Employee employee, Car carThatWasUsed, int startMilage, int endMilage, bool privateTrip)
        {
            this._employee = employee;
            this._carUsed = carThatWasUsed;
            this._startMilage = startMilage;
            this._endMilage = endMilage;
            this.Kilometers = endMilage - startMilage;
            this.PrivateTrip = privateTrip;
            db.InsertTrip(this);
            db.UpdateMilage(carThatWasUsed, endMilage);
        }
        public Tuple<DataTable, DataTable, int> GetEmployeeInfo(int id)
        {
            return db.GetAllEmployeeTrips(id);
        }

    }
}
