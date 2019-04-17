using System;

namespace GarysWholesaleGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            //create Garage
            Garage GarysGarage = new Garage();
            //invoke methods from garage.cs to create list of electric cars and nonelectric cars and loop through
            GarysGarage.ElectricCarList()
            .ForEach(car => car.ChargeBattery());
            GarysGarage.FuelCarList()
            .ForEach(car => car.FuelPump());

        }
    }
}
