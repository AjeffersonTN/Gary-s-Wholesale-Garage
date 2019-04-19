using System;
using System.Collections.Generic;


namespace GarysWholesaleGarage
{
    public class Scooter : Vehicle, IElectricVehicleDetails
    {
        public string TypeName {get; set;}
        public int Wheels { get; set; }
        public int Speed { get; set; }
        public string MovementType { get;  set; }
        public double BatteryKWh { get;  set; }

        public override void Drive(){
             Console.WriteLine($"The {MainColor} {VehicleName} with {NumberOfPassangers} passangers Zoomm by you!");
         }

          public void ChargeBattery(){
            Console.WriteLine($"The {TypeName} is at the charging station!!!!!");
        }



        //defined ToString in ordeer to display when loop over in program.cs
        // public override string ToString()
        // {
        //     return "I am a battery powered car.";
        // }
    }
}