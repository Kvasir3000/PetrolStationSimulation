using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Diagnostics;
using System.Drawing;


namespace PetrolStationSimulation
{
    /// <summary>
    /// Parent class for all the vehicles, has three child classes: Car, Van, HGV
    /// Responsible for the creation of new vehicle and calculations connected with them 
    /// </summary>
     abstract class Vehicle
     {
        /// <summary>
        /// Timer to create a new Vehicle object
        /// </summary>
        private static Timer timer;

        /// <summary>
        /// Random int variable to set the timer.Interval value
        /// </summary>
        private static int genericTime;

        /// <summary>
        /// Time to fill up the vehicle on the pump, used to set timer.Iterval in ReleasVehicle() Pump method   
        /// value depends on the requiredFuel
        /// </summary>
        internal float fuelTime;

        /// <summary>
        /// List of the vehicles, which are waiting in the line
        /// </summary>
        private static List<Vehicle> vehicles;

        /// <summary>
        /// This variable is used to set the CurrentVehicleID value, incremented with the creation of new vehicle 
        /// </summary>
        private static int nextVechicalID = 0;

        /// <summary>
        /// ID number for each car, gets it's value from NextVehicleID
        /// </summary>
        private int currentVechicalD;

        /// <summary>
        /// Works as time limit for vehicle to wait in the line
        /// </summary>
        private Timer awatingTime;

        /// <summary>
        /// Random int, used to set awaitingTime.Interval
        /// </summary>
        private int awaitingTimeLimit;

        /// <summary>
        /// There are three types of vehicles: Car, Van and HGV
        /// Each type has differences in their properties
        /// </summary>
        internal string type;

        /// <summary>
        /// There are three types of fuel: Disel, LPG and Unleaded
        /// Each type of Vehicle can have different fuel types
        /// Car => Disel, LPG and Unleaded
        /// Van => Disel, LPG
        /// HGV => Disel
        /// </summary>
        internal string fuelType;

        /// <summary>
        /// Maximum amount of fuel in the vehicle, measured in litres
        /// Each type of the vehicle has its own maximum amount of fuel 
        /// Car => 40L
        /// Van => 80L
        /// HGV => 150L
        /// </summary>
        internal float maxAmountOfFuel;

        /// <summary>
        /// Each vehicle already has some random amount of fuel, this variable stores it 
        /// The value of this variable can not be bigger than 1/4(maxAmountOfFuel)
        /// Measured in litres
        /// </summary>
        internal float fuelInTheTank;

        /// <summary>
        /// Required fuel to fill up the vehicle
        /// Calculated with maxAmountOfFuel-fuelInTheTank
        /// Measured in litres
        /// </summary>
        internal float requiredFuel;

        /// <summary>
        /// Stores the image of the vehicle, which is displayed to the user 
        /// Each type of vehicle has different image 
        /// </summary>
        internal Image imageOFVehicle;

        /// <summary>
        /// Stores the name of the png file, which is used to show the busy pump
        /// Depends on vehicle type used in the Pump.ChangeState() method
        /// </summary>
        internal string busyPump;

        /// <summary>
        /// Stores the pump postion, which served the vehicle 
        /// </summary>
        private int servingPumpPosition;

        /// <summary>
        /// Random integer number within the given range of numbers
        /// </summary>
        static Random random = new Random();
        
        static internal int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }

        /// <summary>
        /// Constructor which is used in the child classes 
        /// </summary>
        public Vehicle()
        {
            nextVechicalID++;
            currentVechicalD = nextVechicalID;
            // sets a time, required to create the next vehicle 
            genericTime = RandomNumber(1000, 3500);
            awaitingTimeLimit = RandomNumber(7000, 10000);
        }

        /// <summary>
        /// Calls the CreateVehicle() method when the timer requires 
        /// </summary>
        public static void InitializeVehicle()
        {
            // sets the generic time for the first vehicle
            genericTime = RandomNumber(1000, 2200);

            // creates the list of the vehicles in the line
            vehicles = new List<Vehicle>();

            timer = new Timer();
            timer.Interval = Vehicle.genericTime;
            timer.AutoReset = true;
            timer.Elapsed += CreateVechicle;
            timer.Enabled = true;
            timer.Start();
        }

        /// <summary>
        /// Called by InitializedVehicle() method 
        /// Creates a new vehicle, if there are less than 6 vehicles waiting in the Line
        /// </summary>
        /// <param name="sender">contains the sender of the event, in this case timer</param>
        /// <param name="e">contains information about sender</param>
        private static void CreateVechicle(object sender, ElapsedEventArgs e)
        {
            if (vehicles.Count < 6)
            {
                Vehicle a = VehicleType();
                // adds new vehicle to the list 
                vehicles.Add(a);
                a.AwaitingTimeInLine();
                // changes the timer.Interval to new value for next vehicle creation 
                Vehicle.timer.Interval = genericTime;
            }
        }

        /// <summary>
        /// Determines the type of the new vehicle by using random number and switch
        /// switch (1) => Car type
        /// switch (2) => Van type
        /// switch (3) => HGV type 
        /// </summary>
        /// <returns>retuns new vehicle</returns>
        internal static Vehicle VehicleType()
        {
            int typeOfVehicle = RandomNumber(1, 4);
            Vehicle v = null;
            switch (typeOfVehicle)
            {
                case 1:
                    v = new Car();
                    break;

                case 2:
                    v = new Vans();
                    break;

                case 3:
                    v = new HGV();
                    break;
            }
            return v;
        }

        /// <summary>
        /// Takes random number (in case with HGV constant), and based on that sets the fuel type of the vehicle
        /// Called from Car, Van, HGV constructors
        /// </summary>
        /// <param name="fuel"> is a number different for different types:
        /// Car can have any fuel type, so fuel = 1..3
        /// Van can have Diesel and LPG fuel types, so fuel = 1..2
        /// HGV has only Diesel type, so fuel = 1
        /// </param>
        internal void TypeOfFuel(int fuel)
        {
            switch (fuel)
            {
                case 1:
                    fuelType = "Diesel";
                    break;

                case 2:
                    fuelType = "LPG";
                    break;

                case 3:
                    fuelType = "Unleaded";
                    break;
            }
        }

        /// <summary>
        /// Calls the LeaveStation method when the timer is ticked
        /// </summary>
        public void AwaitingTimeInLine()
        {
            awatingTime = new Timer(); 
            awatingTime.Interval = awaitingTimeLimit;  
            awatingTime.AutoReset = false;
            awatingTime.Elapsed += LeaveStation;
            awatingTime.Enabled = true;
            awatingTime.Start();
        }

        /// <summary>
        /// If the car stands in the line for far too long and the timeAwatingLimit is reached this method will delete the car from the line  
        /// and save all the information about the left vehicle in the Counter class. The for loop is used here to find the vehicle, which needs to
        /// be deleted from the list.
        /// </summary>
        /// <param name="sender">contains the sender of the event, in this case awaitingTime</param>
        /// <param name="e">contains information about sender</param>
        public void LeaveStation(object sender, ElapsedEventArgs e)
        {
            for (int i = 0; i < vehicles.Count; i++)
            {
                if (vehicles[i].currentVechicalD == currentVechicalD)
                {
                    Counters.UpdateLeftVehicles(vehicles[i]);
                    vehicles.RemoveAt(i);
                }
            }
        }
       
        public float FuelTime { get => fuelTime; }
        internal static List<Vehicle> Vehicles { get => vehicles; }
        public int CurrentVechicalD { get => currentVechicalD; }
        public int AwaitingTimeLimit { get => awaitingTimeLimit; }
        public string Type { get => type; }
        public string BusyPump { get => busyPump; set => busyPump = value; }
        public int ServingPumpPosition { get => servingPumpPosition; set => servingPumpPosition = value; }
     }
}
