using System;
using System.Collections.Generic;


namespace GarysWholesaleGarage
{
    public class RV : Vehicle, IFuelVehicleDetails
    {
        public string TypeName { get; set; }

        public int Doors { get; set; }

        public int WeightCapacity { get; set; }
        public string MovementType { get;  set; }
        public string FuelType { get;  set; }
         public override void Drive(){
             Console.WriteLine($"The {MainColor} {VehicleName} with {NumberOfPassangers} passangers Dooonnn by you!");
         }

         public void FuelPump(){
            Console.WriteLine("I am at the fuel station***");
        }
           public override void Stop(){
             Console.WriteLine("The vehicle comes to a sliding stop.");
         }
         public override void Turn(){
             Console.WriteLine("The vehicle turns down.");
         }

        //defined ToString in ordeer to display when loop over in program.cs
        // public override string ToString()
        // {
        //     return "I am a car that requires fuel.";
        // }
    }
}