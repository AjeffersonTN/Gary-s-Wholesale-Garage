using System;
using System.Collections.Generic;


namespace GarysWholesaleGarage
{
    public class Aircraft : Vehicle, IFuelVehicleDetails
    {

        public string TypeName { get; set; }
        public int Wheels { get; set; }
        public int AirSpeed { get; set; }
        public string FuelType { get;  set; }
        public string MovementType { get;  set; }

         public void FuelPump(){
            Console.WriteLine("I am at the fuel station***");
         }

         public override void Drive(){
             Console.WriteLine($"The {MainColor} {VehicleName} with {NumberOfPassangers} passangers Whheeeww by you!");
         }



        //defined ToString in ordeer to display when loop over in program.cs
        // public override string ToString()
        // {
        //     return "I am a car that requires fuel.";
        // }
    }
}