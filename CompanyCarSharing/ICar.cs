using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCarSharing
{
    public interface ICar
    {
        List<Trip> Trips { get; }
        int ID { get; }
        string Brand { get; }
        string Model { get; }
        int EndOfLifeMilage { get; }
        int CurrentMilage { get; }
        string LicencePlate { get; }
        int MaintenanceInterval { get; }

        void AssignValuesToCar(string brand, string model, int endOfLife, int currentKm, string licencePlate, int maintenanceIntervalKm);
        void AddMilage(int kilometers);
        string ToString();
        void AddTrip(Trip trip);
    }
}
