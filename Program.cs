using System;
using System.Collections.Generic;

namespace refueling
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating the cars
            BatteryPowered Tesla = new BatteryPowered();
            BatteryPowered Zero = new BatteryPowered();

            GasPowered Ram = new GasPowered();
            GasPowered Cessna = new GasPowered();


            // make an instance of the stations
            BatteryStation BattStations = new BatteryStation();
            GasStation GasStations = new GasStation();


            // creating a list of Battery Vehicles
            List<BatteryPowered> BatteryVehicles = new List<BatteryPowered>();

            // creating a list of Gas Vehicles
            List<GasPowered> GasVehicles = new List<GasPowered>();

            // Call the refuel on all of the cars
            BattStations.Refuel(BatteryVehicles);
            GasStations.Refuel(GasVehicles);
        }
    }
}
