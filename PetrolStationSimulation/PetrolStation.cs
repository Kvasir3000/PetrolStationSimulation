using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PetrolStationSimulation
{
    public partial class PetrolStation : Form
    {
        public static List<PictureBox> VehicleLine = new List<PictureBox>();

        private PictureBox[,] Pumps = new PictureBox[3,3];

        private List<TextBox> ID = new List<TextBox>();

        private List<TextBox> FuelTime = new List<TextBox>();

        private List<TextBox> FuelType = new List<TextBox>();

        private List<TextBox> RequiredFuel = new List<TextBox>();

        public PetrolStation()
        {
            InitializeComponent();
            
        
            VehicleLine.Add(vehicle1);
            VehicleLine.Add(vehicle2);
            VehicleLine.Add(vehicle3);
            VehicleLine.Add(vehicle4);
            VehicleLine.Add(vehicle5);

            Pumps[0, 0] = pump3;
            Pumps[0, 1] = pump2;
            Pumps[0, 2] = pump1;
            Pumps[1, 0] = pump6;
            Pumps[1, 1] = pump5;
            Pumps[1, 2] = pump4;
            Pumps[2, 0] = pump9;
            Pumps[2, 1] = pump8;
            Pumps[2, 2] = pump7;

            ID.Add(id1);
            ID.Add(id2);
            ID.Add(id3);
            ID.Add(id4);
            ID.Add(id5);
            ID.Add(id6);
            ID.Add(id7);
            ID.Add(id8);
            ID.Add(id9);

            FuelTime.Add(fuelType1);
            FuelTime.Add(fuelType2);
            FuelTime.Add(fuelType3);
            FuelTime.Add(fuelType4);
            FuelTime.Add(fuelType5);
            FuelTime.Add(fuelType6);
            FuelTime.Add(fuelType7);
            FuelTime.Add(fuelType8);  
            FuelTime.Add(fuel9);

            FuelType.Add(type1);
            FuelType.Add(type2);
            FuelType.Add(type3);
            FuelType.Add(type4);
            FuelType.Add(type5);
            FuelType.Add(type6);
            FuelType.Add(type7);
            FuelType.Add(type8);
            FuelType.Add(timeToFuel9);


            RequiredFuel.Add(reqFuel1);
            RequiredFuel.Add(reqFuel2);
            RequiredFuel.Add(reqFuel3);
            RequiredFuel.Add(reqFuel4);
            RequiredFuel.Add(reqFuel5);
            RequiredFuel.Add(reqFuel6);
            RequiredFuel.Add(reqFuel7);
            RequiredFuel.Add(reqFuel8);
            RequiredFuel.Add(reqFuel9); 
        }


        /// <summary>
        /// Starts all the timers, which are needed to run the simulation, called when the Start button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startProgram(object sender, EventArgs e)
        {
            Vehicle.InitializeVehicle();
            Pump.GeneratePumpLanes();
            timer1.Enabled = true;
            timer1.Start();
            startToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = true;

        }


        /// <summary>
        /// Timer to update the interface every 400ms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateInterface();
        }


        /// <summary>
        /// Called, when the timer1 is ticked;
        /// Calls method from Pump class to serve the vehicles;
        /// Calls various methods to update different parts of the interface;
        /// </summary>
        private void UpdateInterface()
        {
            Pump.ServeVehicle(Pump.Pumps, Vehicle.Vehicles);
            UpdateVehiclesInterface();
            DisplayPumpsCounters();
            DisplayPetrolStationCounters();
        }

        private void UpdateVehiclesInterface()
        {
            for (int i = 0; i < Vehicle.Vehicles.Count - 1; i++)
            {
                VehicleLine[i].Visible = true;
                VehicleLine[i].Image = Vehicle.Vehicles[i].imageOFVehicle;
            }

            for (int i = Vehicle.Vehicles.Count; i < VehicleLine.Count; i++)
            {
                VehicleLine[i].Visible = false;
                VehicleLine[i].Image = null;
            }
        }
        
        private void DisplayPumpsCounters()
        {
            if (Pump.Pumps != null && Vehicle.Vehicles != null)
            {
                int index = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Pumps[i, j].Image = Pump.Pumps[i, j].PumpImage;
                        if (Pump.Pumps[i, j].Busy == true)
                        {
                            ID[index].Text = Pump.Pumps[i, j].CurVeh.CurrentVechicalD.ToString();
                            FuelType[index].Text = (Pump.Pumps[i, j].CurVeh.FuelTime / 1000).ToString() + "s";
                            FuelTime[index].Text = Pump.Pumps[i, j].CurVeh.fuelType;
                            RequiredFuel[index].Text = Pump.Pumps[i, j].CurVeh.requiredFuel.ToString() + "L";
                        }
                        if (Pump.Pumps[i, j].Busy == false)
                        {
                            ID[index].Text = "Empty";
                            FuelTime[index].Text = "Empty";
                            FuelType[index].Text = "Empty";
                            RequiredFuel[index].Text = "Empty";
                        }
                        index++;
                    }
                }
            }
        }

        private void DisplayPetrolStationCounters()
        {
            label32.Text = "LPG: " + Counters.SumPerLiterLPG.ToString() + "£";
            unleadedPrice.Text = "Unleaded: " + Counters.SumPerLiterUnleaded.ToString() + "£";
            dieselPrice.Text = "Diesel: " + Counters.SumPerLiterDiesel.ToString() + "£";
            totalMoney.Text = Counters.EarnedMoney.ToString() + "£";
            dispensedFuel.Text = Counters.DispensedFuel.ToString() + "L";
            lpgType.Text = Counters.DispensedLPG.ToString() + "L";
            dieselType.Text = Counters.DispensedDiesel.ToString() + "L";
            unleadedType.Text = Counters.DispensedUnleaded.ToString() + "L";
            leftVehicles.Text = Counters.LeftVehicles.Count.ToString();
            servedVehicles.Text = Counters.transactionServedVehicles.Count.ToString();
            Counters.UpdateDispensedFuel();
            comission.Text = Counters.Comission.ToString() + "£";
        }
 

        /// <summary>
        /// Methods below allow the user to click on any vehicle in the line and view information about it 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vehicle1_Click(object sender, EventArgs e)
        {
            if (VehicleLine[0].Visible == true)
            {
                VehicleCharacteristics form2 = new VehicleCharacteristics(0);
                form2.Show();
            }
        }

        private void vehicle2_Click(object sender, EventArgs e)
        {
            if (VehicleLine[1].Visible == true)
            {
                VehicleCharacteristics form2 = new VehicleCharacteristics(1);
                form2.Show();
            }
        }

        private void vehicle3_Click(object sender, EventArgs e)
        {
            if (VehicleLine[2].Visible == true)
            {
                VehicleCharacteristics form2 = new VehicleCharacteristics(2);
                form2.Show();
            }
        }

        private void vehicle4_Click(object sender, EventArgs e)
        {
            if (VehicleLine[3].Visible == true)
            {
                VehicleCharacteristics form2 = new VehicleCharacteristics(3);
                form2.Show();
            }
        }

        private void vehicle5_Click(object sender, EventArgs e)
        {
            if (VehicleLine[3].Visible == true)
            {
                VehicleCharacteristics form2 = new VehicleCharacteristics(4);
                form2.Show();
            }
        }

        private void pump3_Click(object sender, EventArgs e)
        {
            if (startToolStripMenuItem.Enabled == false)
            {
                PumInfo form5 = new PumInfo(3);
                form5.Show();
            }
        }

        /// <summary>
        /// Methods below allow the user to click on any pump and view information about it 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pump1_Click(object sender, EventArgs e)
        {
            if (startToolStripMenuItem.Enabled == false)
            {
                PumInfo form5 = new PumInfo(1);
                form5.Show();
            }
        }

        private void pump2_Click(object sender, EventArgs e)
        {
            if (startToolStripMenuItem.Enabled == false)
            {
                PumInfo form5 = new PumInfo(2);
                form5.Show();
            }
        }
        private void pump4_Click(object sender, EventArgs e)
        {
            if (startToolStripMenuItem.Enabled == false)
            {
                PumInfo form5 = new PumInfo(4);
                form5.Show();
            }
        }
        private void pump5_Click(object sender, EventArgs e)
        {
            if (startToolStripMenuItem.Enabled == false)
            {
                PumInfo form5 = new PumInfo(5);
                form5.Show();
            }
        }

        private void pump6_Click(object sender, EventArgs e)
        {
            if (startToolStripMenuItem.Enabled == false)
            {
                PumInfo form5 = new PumInfo(6);
                form5.Show();
            }
        }

        private void pump7_Click(object sender, EventArgs e)
        {
            if (startToolStripMenuItem.Enabled == false)
            {
                PumInfo form5 = new PumInfo(7);
                form5.Show();
            }
        }
        private void pump8_Click(object sender, EventArgs e)
        {
            if (startToolStripMenuItem.Enabled == false)
            {
                PumInfo form5 = new PumInfo(8);
                form5.Show();
            }
        }
        private void pump9_Click(object sender, EventArgs e)
        {
            if (startToolStripMenuItem.Enabled == false)
            {
                PumInfo form5 = new PumInfo(9);
                form5.Show();
            }
        }
    
        /// <summary>
        /// Saves the statitistic about the simulation in a .csv file, when the Save button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveTransactions = new SaveFileDialog();
            saveTransactions.RestoreDirectory = true;
            saveTransactions.FileName = "*.csv";
            saveTransactions.DefaultExt = "csv";
            if (saveTransactions.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = saveTransactions.OpenFile();
                StreamWriter sw = new StreamWriter(fileStream);
                sw.Write("Pump position, VehicleID, Fuel type, Required fuel, Fuel time");
                for(int i=0; i< Counters.transactionServedVehicles.Count;i++)
                {
                    sw.WriteLine();
                    sw.Write("#" + Counters.transactionServedVehicles[i].ServingPumpPosition + ",   ");
                    sw.Write(Counters.transactionServedVehicles[i].CurrentVechicalD+ ",   ");
                    sw.Write(Counters.transactionServedVehicles[i].fuelType + ",   ");
                    sw.Write(Counters.transactionServedVehicles[i].requiredFuel + "L,   ");
                    sw.Write(Counters.transactionServedVehicles[i].FuelTime + "s,   ");
                    
                }
                sw.Close();
                fileStream.Close();
            }          
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }
    }
}
