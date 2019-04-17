using System;
using System.Collections.Generic;


namespace GarysWholesaleGarage
{
    public class Aircraft : IFuelVehicleDetails
    {

        public string TypeName { get; set; }
        public int Wheels { get; set; }
        public int AirSpeed { get; set; }
        public string FuelType { get;  set; }
        public int NumberOfPassangers { get;  set; }
        public string MovementType { get;  set; }

         public void FuelPump(){
            Console.WriteLine("I am at the fuel station***");
        }

        //defined ToString in ordeer to display when loop over in program.cs
        // public override string ToString()
        // {
        //     return "I am a car that requires fuel.";
        // }
    }
}