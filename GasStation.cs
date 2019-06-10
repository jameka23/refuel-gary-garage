using System;
using System.Collections.Generic;

namespace refueling{
    public class GasStation : IStations<GasPowered>{
        public int Capacity { get; set; }
        public void Refuel(List<GasPowered> vehicles){
            foreach(GasPowered car in vehicles){
                Console.WriteLine($"The {car.Model} has been refueled with gasoline!");
            }
        }
    }    
}