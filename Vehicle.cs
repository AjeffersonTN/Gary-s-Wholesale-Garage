using System;
using System.Collections.Generic;


namespace GarysWholesaleGarage
{

    public class Vehicle
    {
        public string MainColor { get; set; }
        public int NumberOfPassangers { get; set; }
        public string VehicleName { get; set; }

        public virtual void Drive (){
            Console.WriteLine("Vrooommm!");
        }
        public virtual void Stop(){
            Console.WriteLine("Stop");
        }
        public virtual void Turn(){
            Console.WriteLine("Right");
        }
    }

}