using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Drawing;
using System.Threading.Tasks;

namespace PetrolStationSimulation
{
    /// <summary>
    /// Responsible for the creation of pumps and calculations connected with them 
    /// </summary>
    class Pump
    {
        /// <summary>
        /// Stores the information about the amount of served vehicles per pump, incremented after the vehicle is served
        /// </summary>
        private int servedVehicles = 0;

        /// <summary>
        /// Stores the image of the pump, depends on the state and the type of the current vehicle
        /// </summary>
        private Image pumpImage;

        /// <summary>
        /// Pump's state in the station
        /// true => pump is busy; false => pump is free 
        /// </summary>
        private bool busy;

        /// <summary>
        /// Pump position in the petrol station.
        /// </summary>
        private int position;

        /// <summary>
        /// Sores the vehicle, which is being served by pump at the moment
        /// This variable lets the program to set timer.Interval to fill up the vehicle, 
        /// change the image of the pump and save the vehicle to served Vehicle list in the Counters class affter it is filled up
        /// </summary>
        private Vehicle curVeh;

        /// <summary>
        /// Saves the total amount of dispensed fuel by pump, measured in litres
        /// </summary>
        private double dispensedFuelPerPump;

        /// <summary>
        /// Variables below store the dispensed fuel by pump of each type
        /// </summary>
        private double dispensedLPG = 0;
        private double dispensedUnleaded = 0;
        private double dispensedDiesel = 0;

        /// <summary>
        /// Stores the commision for one pump 
        /// </summary>
        private double commission;

       /// <summary>
       /// This timer is used to release the vehicle, when it is filled up
       /// </summary>
       private Timer timer;

         /// <summary>
        /// Constructor for Pump class
        /// </summary>
        /// <param name="pos">Postion of the pump in the petrol station</param>
        private Pump(int pos)
        {
            position = pos;
            busy = false;
            pumpImage = Image.FromFile("Pump.png");
            commission = (dispensedFuelPerPump / 100) +2.49 * 8;
        }

        /// <summary>
        /// Two-dimensional array with pumps in the petrol station 
        /// </summary>
        private static Pump[,] pumps = new Pump[3, 3];

        /// <summary>
        /// Creates 3 pumps in 3 different lines when the program is started, each pump gets it's position value 
        /// </summary>
        static public void GeneratePumpLanes()
        { 
            int position = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    position++;
                    pumps[i, j] = new Pump(position);
                }
            } 
        }

        /// <summary>
        /// This method is called if there is any available pump at the station, 
        /// Method takes the first vehicle in the line and sends it to that free pump
        /// First the inforamtion about the served vehicle should be saved to curveh variable
        /// After that the vehicle is deleted from the line of vehicles and the timer to release vehicle is started 
        /// Finally, pump gets it's new image from curVeh variable by calling ChangeState() method
        /// </summary>
        /// <param name="v">Line of vehicles, used to take the serve the first vehicle in the line and delete it from the line</param>
        public void FillUpTheVehicle(List<Vehicle> v)
        {
            curVeh = v[0];
            curVeh.ServingPumpPosition = position;
            v.RemoveAt(0);
            ReleaseVehicle();
            ChangeState();
        }

        /// <summary>
        /// This method looks for free pump at the station. If there is an available pump, FillUpTheVehicle() method is called 
        /// Algorithm to find the free pump
        /// 1.If the  firts pump is free, method checks state of the neighbor pump to the right 
        /// 2.If the first pump is free AND  the second pump is busy, vehicle is served with the first pump in the lane
        /// 3.If the first pump is free  AND the second pump is free, method takes a look at the state of the neigbour pump to the right   
        /// 4.If the second pump is free AND the third pump is busy, vehicle is served with the second pump in the lane
        /// 5.If the second pump is  free AND the third pump is free, the car is served with the third pump in the lane 
        /// 6.If the first pump is busy, method goes to the lower lane and repeats steps from 2 to 5. 
        /// </summary>
        /// <param name="pumps"></param>
        /// <param name="v"></param>
        public static void ServeVehicle(Pump[,] pumps, List<Vehicle> v)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++) {

                    if (pumps[i, j].busy == true && Vehicle.Vehicles.Count != 0)
                    {
                        break;
                    }
                    else if (j < 2)
                    {
                        if (pumps[i, j].busy == false && pumps[i, j + 1].busy == true && Vehicle.Vehicles.Count != 0)
                        {
                            pumps[i, j].FillUpTheVehicle(v);
                            i = 2;
                            j = 2;
                        }
                    }
                    else if (pumps[i, j].busy == false && Vehicle.Vehicles.Count!=0)
                    {
                        pumps[i, j].FillUpTheVehicle(v);
                        i = 2;
                        j = 2;
                    }
                }
            }  
        }
        
        /// <summary>
        /// Set the timer.Interval to curVeh fuel time, starts the timer and when the Interval is reached calls RV() method.
        /// The timer is not repeated
        /// </summary>
        public void ReleaseVehicle()
        {
            timer = new Timer();
            timer.Interval = curVeh.FuelTime;
            timer.AutoReset = false;
            timer.Elapsed += RV;
            timer.Start();
        }

        /// <summary>
        /// Pump's dispensed fuel and commision are updated 
        /// curVeh is added to the list of served vehicles in the Counters class
        /// The state of the pump is changed and now it take new vehicle to fill
        /// </summary>
        /// <param name="sender">contains the sender of the event, in this case timer</param>
        /// <param name="e">contains information about sender</param>
        public void RV(object sender, ElapsedEventArgs e)
        {
            dispensedFuelPerPump += curVeh.requiredFuel;
            commission = (dispensedFuelPerPump / 100) + 2.49 * 8;
            Counters.UpdateServedVehicles(curVeh);
            switch (curVeh.fuelType)
            {
                case "LPG":
                    dispensedLPG += curVeh.requiredFuel;
                    break;

                case "Diesel":
                    dispensedDiesel += curVeh.requiredFuel;
                    break;

                case "Unleaded":
                    dispensedUnleaded += curVeh.requiredFuel;
                    break;
            }
            servedVehicles++;
            ChangeState();
        }
       
        /// <summary>
        /// This method changes the state of the pump, depending on the current state.
        /// Thus : Busy => Free and Free => Busy
        /// </summary>
        /// <param name="pump"> The pump, whose state will be changed </param>
         public void ChangeState()
         {
            if (busy == false)
            {
                busy = true;
                pumpImage = Image.FromFile(curVeh.BusyPump);
            }
            else
            {
               busy = false;
               pumpImage = Image.FromFile("Pump.png");
            }
         } 

        public Vehicle CurVeh { get => curVeh; }
        public int ServVehicles { get => servedVehicles; }
        public Image PumpImage { get => pumpImage; }
        public bool Busy { get => busy; }
        public int Position { get => position;}
        public double DispensedFuelPerPump { get => dispensedFuelPerPump; }
        public double DispensedLPG { get => dispensedLPG;  }
        public double DispensedUnleaded { get => dispensedUnleaded;  }
        public double DispensedDiesel { get => dispensedDiesel; }
        public double Commission { get => commission; }
        internal static Pump[,] Pumps { get => pumps;}
    }
}
