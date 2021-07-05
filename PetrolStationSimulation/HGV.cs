using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PetrolStationSimulation
{
    class HGV : Vehicle
    {
        /// <summary>
        /// Constructor to create an instance of the HGV class with all its properties, like:
        /// maxAmountOfFuel = 40
        /// Available type of fuel: Diesel
        /// HGV image
        /// Inherits from the constructor of the Vehicle class
        /// </summary>
        public HGV() : base() 
        {
            imageOFVehicle = Image.FromFile("HGV.png");
            BusyPump = "HGVBusy.png";
            TypeOfFuel(1);
            maxAmountOfFuel = 150;
            float quaterOfTank = maxAmountOfFuel / 4;
            fuelInTheTank = RandomNumber(1, (int)quaterOfTank);
            requiredFuel = (maxAmountOfFuel - fuelInTheTank);
            fuelTime = ((maxAmountOfFuel - fuelInTheTank) / Counters.LiterPerSecond) * 1000;
            type = "HGV";
        }
    }
}
