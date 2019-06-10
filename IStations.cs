using System;
using System.Collections.Generic;

namespace refueling{
    public interface IStations<T>
    {
        // The number of vehicles that they can refuel at any one time.
        int Capacity { get; set;}
        void Refuel(List<T> vehicles);
    }    
}