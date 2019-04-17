using System;
using System.Collections.Generic;


namespace GarysWholesaleGarage
{
    public class Garage
    {
      public string GarageName{get; set;}
      public string OpeningTime {get; set;}
      public string ClosingTime {get; set;}

      public List<Aircraft> Aircrafts {get; set;} = new List <Aircraft>();
      public List<ElectricCar> ElectricCars {get; set;} = new List <ElectricCar>();
      public List<Jetski> Jetskis {get; set;} = new List <Jetski>();
      public List<Motorcycle> Motorcycles {get; set;} = new List <Motorcycle>();
      public List<RV> RVs {get; set;} = new List <RV>();
      public List<Scooter> Scooters {get; set;} = new List <Scooter>();
      public List<NonElectricCar> NonElectricCars {get; set;} = new List <NonElectricCar>();


         //Method below
      public List<IElectricVehicleDetails> ElectricCarList() {
          //created interface to bring tuplips and roses togther thy both share IMothersDay interface
        List<IElectricVehicleDetails> electricCarListAll = new List <IElectricVehicleDetails>(){
              new Scooter(){
                NumberOfPassangers = 2, MovementType = "Land", BatteryKWh = 456.59, Speed = 45, Wheels = 2, TypeName = "Honda"},
              new ElectricCar(){
                NumberOfPassangers = 5, MovementType = "Land", BatteryKWh = 4536.53, Speed = 145, TypeName = "Tesla"}

          };
          return electricCarListAll;
        }
      public List<IFuelVehicleDetails> FuelCarList() {
          //created interface to bring tuplips and roses togther thy both share IMothersDay interface
        List<IFuelVehicleDetails> FuelCarListAll = new List <IFuelVehicleDetails>(){
              new Aircraft(){
                NumberOfPassangers = 112, MovementType = "Air", FuelType = "Jet Fuel", AirSpeed = 450, Wheels = 16, TypeName = "Boeing 747"},

              new Boat(){
                NumberOfPassangers = 8, MovementType = "Water", FuelType = "Gasoline", WaterSpeed = 65, TypeName = "Big As Boat"},
              new Jetski(){
                NumberOfPassangers = 2, MovementType = "Water", FuelType = "Mogas", WaterSpeed = 38, TypeName = "Water Surfer"},
              new Motorcycle(){
                NumberOfPassangers = 3, MovementType = "Land", FuelType = "Gasoline", Speed = 189, TypeName = "Ninja", Wheels = 2},
              new NonElectricCar(){
                NumberOfPassangers = 6, MovementType = "Land", FuelType = "Diesel", Speed = 122, TypeName = "Ram 3500", Doors = 4},
              new RV(){
                NumberOfPassangers = 5, MovementType = "Land", FuelType = "Diesel", TypeName = "Roadmaster", Doors = 3, WeightCapacity = 4200}


          };
          return FuelCarListAll;
        }

    }
}