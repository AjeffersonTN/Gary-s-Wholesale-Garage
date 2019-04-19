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

            Aircraft Boeing = new Aircraft();
            Boeing.NumberOfPassangers = 7;
            Boeing.MainColor = "White";
            Boeing.VehicleName = "Boeing";
            Boeing.Drive();


            Boat SeaBass = new Boat();
            SeaBass.NumberOfPassangers = 12;
            SeaBass.MainColor = "Tan";
            SeaBass.VehicleName = "Seabass";
            SeaBass.Drive();

            ElectricCar Spark = new ElectricCar();
            Spark.NumberOfPassangers = 4;
            Spark.MainColor = "Green";
            Spark.VehicleName = "Spark";
            Spark.Drive();

            Jetski SeaDoo = new Jetski();
            SeaDoo.NumberOfPassangers = 2;
            SeaDoo.MainColor = "Blue";
            SeaDoo.VehicleName = "SeaDoo";
            SeaDoo.Drive();

            Motorcycle Ninja = new Motorcycle();
            Ninja.NumberOfPassangers = 2;
            Ninja.MainColor = "Red";
            Ninja.VehicleName = "Ninja";
            Ninja.Drive();

            NonElectricCar Civic = new NonElectricCar();
            Civic.NumberOfPassangers = 5;
            Civic.MainColor = "Gray";
            Civic.VehicleName = "Civic";
            Civic.Drive();

            RV RoadMaster = new RV();
            RoadMaster.NumberOfPassangers = 9;
            RoadMaster.MainColor = "Brown";
            RoadMaster.VehicleName = "RoadMaster";
            RoadMaster.Drive();

            Scooter Honda = new Scooter();
            Honda.NumberOfPassangers = 1;
            Honda.MainColor = "Pink";
            Honda.VehicleName = "Honda";
            Honda.Drive();

            GarysGarage.ElectricCarList()
            .ForEach(car => car.ChargeBattery());
            GarysGarage.FuelCarList()
            .ForEach(car => car.FuelPump());

        }
    }
}
