using System;
using System.Collections.Generic;

namespace refueling{
    public class BatteryStation : IStations<BatteryPowered>{
        public int Capacity { get; set; }
        public void Refuel(List<BatteryPowered> vehicles){
            foreach(BatteryPowered car in vehicles){
                Console.WriteLine($"The {car.Model} has been recharged!");
            }
        }
    }    
}