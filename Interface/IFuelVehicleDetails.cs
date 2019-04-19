//type and name goes in interface only..interfaces allow you to creat list of different types
namespace GarysWholesaleGarage

{
    public interface IFuelVehicleDetails
    {
      string FuelType { get; set; }
      string MovementType { get; set; }


      void FuelPump();

    }
}