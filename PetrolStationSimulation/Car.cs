   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PetrolStationSimulation
{
    class Car : Vehicle
    {
        /// <summary>
        /// Constructor to create an instance of the Car class with all its properties, like:
        /// maxAmountOfFuel = 40
        /// Available type of fuel: Diesel, LPG, Unleaded
        /// Car image
        /// Inherits from the constructor of the Vehicle class
        /// </summary>
        public Car() : base()
        {
            imageOFVehicle = Image.FromFile("Car.png");
            BusyPump = "CarBusy.png";
            int num = RandomNumber(1, 4);
            TypeOfFuel(num);
            maxAmountOfFuel = 40;
            float quaterOfTank = (maxAmountOfFuel / 4);
            fuelInTheTank = RandomNumber(1, (int)quaterOfTank);
            requiredFuel = (maxAmountOfFuel - fuelInTheTank);
            fuelTime = (requiredFuel / Counters.LiterPerSecond) * 1000;
            type = "Car";

        }
    }
}
