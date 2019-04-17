using System;
using System.Collections.Generic;


namespace GarysWholesaleGarage
{
    public class Scooter : IElectricVehicleDetails
    {
        public string TypeName {get; set;}
        public int Wheels { get; set; }
        public int Speed { get; set; }
        public int NumberOfPassangers { get;  set; }
        public string MovementType { get;  set; }
        public double BatteryKWh { get;  set; }

          public void ChargeBattery(){
            Console.WriteLine("I am at the charging station!!!!!");
        }



        //defined ToString in ordeer to display when loop over in program.cs
        // public override string ToString()
        // {
        //     return "I am a battery powered car.";
        // }
    }
}