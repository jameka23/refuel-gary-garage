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
            Tesla.BatteryKWh = 200;
            Tesla.Model = "Tesla modelS";
            Zero.BatteryKWh = 300;
            Zero.Model = "Zero fxs";


            GasPowered Ram = new GasPowered();
            GasPowered Cessna = new GasPowered();
            Ram.FuelCapacity = 30;
            Ram.Model = "Ram 1500";
            Cessna.FuelCapacity = 29;
            Cessna.Model = "Cessna cart1";

            // make an instance of the stations
            BatteryStation BattStations = new BatteryStation();
            GasStation GasStations = new GasStation();


            // creating a list of Battery Vehicles
            List<BatteryPowered> BatteryVehicles = new List<BatteryPowered>(){
                Tesla, Zero
            };

            // creating a list of Gas Vehicles
            List<GasPowered> GasVehicles = new List<GasPowered>(){
                Ram, Cessna
            };

            // Call the refuel on all of the cars
            BattStations.Refuel(BatteryVehicles);
            GasStations.Refuel(GasVehicles);
        }
    }
}
