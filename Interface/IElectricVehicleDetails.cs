//type and name goes in interface only..interfaces allow you to creat list of different types
namespace GarysWholesaleGarage

{
    public interface IElectricVehicleDetails
    {
      double BatteryKWh { get; set; }
      string MovementType { get; set; }
      int NumberOfPassangers { get; set; }
      //method to charge chargebattery
      void ChargeBattery();


    }
}