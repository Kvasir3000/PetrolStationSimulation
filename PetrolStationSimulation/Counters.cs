using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;

namespace PetrolStationSimulation
{
    /// <summary>
    /// This class keeps the detailed information about everything that has happened during the simulation
    /// </summary>
    class Counters 
    {

        private static double dispensedLPG = 0;

        private static double dispensedDiesel = 0;

        private static double dispensedUnleaded = 0;

        private static double dispensedFuel = 0;

        private static float sumPerLiterDiesel = 2.5f;

        private static float sumPerLiterLPG = 3f;

        private static float sumPerLiterUnleaded = 1.25f;

        private static double earnedMoney = 0f;

        private static double earnedMoneyDiesel = 0f;

        private static double earnedMoneyLPG = 0f;

        private static double earnedMoneyUnleaded = 0f;

        private static double comission;

        static public List<Vehicle> transactionServedVehicles = new List<Vehicle>();

        static public List<Vehicle> LeftVehicles = new List<Vehicle>();

        private static float literPerSecond = 1.5f;


        /// <summary>
        /// This method updates the statistics about the dispensed fuel 
        /// </summary>
        static public void UpdateDispensedFuel()
        {
          double tempDispensedDiesel = 0;
          double tempDispensedLPG = 0;
          double tempDispensedUnleaded = 0;
          double temp = 0;
            foreach (Pump pump in Pump.Pumps)
            {
                tempDispensedDiesel += pump.DispensedDiesel;
                tempDispensedLPG += pump.DispensedLPG;
                tempDispensedUnleaded += pump.DispensedUnleaded;
                temp += pump.Commission;
            }
            dispensedUnleaded = tempDispensedUnleaded;
            dispensedLPG = tempDispensedLPG;
            dispensedDiesel = tempDispensedDiesel;
            dispensedFuel = dispensedLPG + dispensedUnleaded + dispensedDiesel;
            earnedMoneyDiesel = dispensedDiesel * sumPerLiterDiesel;
            earnedMoneyLPG = dispensedLPG * sumPerLiterLPG;
            earnedMoneyUnleaded = dispensedUnleaded * sumPerLiterUnleaded;
            earnedMoney = earnedMoneyDiesel + earnedMoneyLPG + earnedMoneyUnleaded;
            comission = temp;
        }

       static public void UpdateServedVehicles(Vehicle servedVehicle)
       {
            transactionServedVehicles.Add(servedVehicle);
       }

        static public void UpdateLeftVehicles(Vehicle vehicle)
        {
            LeftVehicles.Add(vehicle);
        }

        public static double DispensedLPG { get => dispensedLPG; }
        public static double DispensedDiesel { get => dispensedDiesel; }
        public static double DispensedFuel { get => dispensedFuel; }
        public static double DispensedUnleaded { get => dispensedUnleaded;  }
        public static float SumPerLiterDiesel { get => sumPerLiterDiesel;}
        public static float SumPerLiterLPG { get => sumPerLiterLPG; }
        public static float SumPerLiterUnleaded { get => sumPerLiterUnleaded; }
        public static double EarnedMoney { get => earnedMoney; }
        public static double EarnedMoneyDiesel { get => earnedMoneyDiesel; }
        public static double EarnedMoneyLPG { get => earnedMoneyLPG; }
        public static double EarnedMoneyUnleaded { get => earnedMoneyUnleaded;}
        public static double Comission { get => comission;}
        public static float LiterPerSecond { get => literPerSecond; }
    }

}

