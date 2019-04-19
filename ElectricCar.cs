using System;
using System.Collections.Generic;


namespace GarysWholesaleGarage
{
    public class ElectricCar : Vehicle, IElectricVehicleDetails
    {
        public string TypeName { get; set; }
        public int Doors { get; set; }
        public int Speed { get; set; }
        public double BatteryKWh { get; set; }
        public string MovementType { get; set; }
        public override void Drive(){
             Console.WriteLine($"The {MainColor} {VehicleName} with {NumberOfPassangers} passangers Silence by you!");
         }


        public void ChargeBattery()
        {
            Console.WriteLine("I am at the charging station!!!!!");
        }


        //defined ToString in order to display when loop over in program.cs
        // public override string ToString()
        // {
        //     return "I am a battery powered car.";
        // }
    }
}