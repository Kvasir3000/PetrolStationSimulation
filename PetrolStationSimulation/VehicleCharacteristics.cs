using System;
using System.Windows.Forms;

namespace PetrolStationSimulation
{
    public partial class VehicleCharacteristics : Form
    {
        int carInLine;
        public VehicleCharacteristics(int i)
        {
            InitializeComponent();
            carInLine = i;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            vehicle.Image = PetrolStation.VehicleLine[carInLine].Image;
            id.Text = Vehicle.Vehicles[carInLine].CurrentVechicalD.ToString();
            type.Text = Vehicle.Vehicles[carInLine].Type;
            fuel.Text = Vehicle.Vehicles[carInLine].fuelType;
            reqFuel.Text = Vehicle.Vehicles[carInLine].requiredFuel.ToString() + "L";
            timeFuel.Text = (Vehicle.Vehicles[carInLine].FuelTime / 1000).ToString() + "s";
            awaitingTime.Text = (Vehicle.Vehicles[carInLine].AwaitingTimeLimit / 1000).ToString() + "s";

        }
    }
}
