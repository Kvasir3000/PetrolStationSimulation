using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PetrolStationSimulation 
{ 
    class Vans : Vehicle
    {
        /// <summary>
        /// Constructor to create an instance of the Vans class with all its properties, like:
        /// maxAmountOfFuel = 80
        /// Available type of fuel: Diesel, LPG
        /// Vehicle image
        /// Inherits from the constructor of the Vehicle class
        /// </summary>
        public Vans() : base()
        {
            imageOFVehicle = Image.FromFile("VAN.png");
            BusyPump = "VanBusy.png";
            int num = RandomNumber(1, 3); 
            TypeOfFuel(num);
            maxAmountOfFuel = 80;
            float quaterOfTank = maxAmountOfFuel / 4;
            fuelInTheTank = RandomNumber(1, (int)quaterOfTank);
            requiredFuel = (maxAmountOfFuel - fuelInTheTank);
            fuelTime = ((maxAmountOfFuel - fuelInTheTank) / Counters.LiterPerSecond) * 1000;
            type = "Vans";
        }
    }
}
