using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolStationSimulation
{
    public partial class PumInfo : Form
    {
        int pumpPosition;
        public PumInfo(int pos)
        {
            InitializeComponent();
            pumpPosition = pos;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(pumpPosition == Pump.Pumps[i,j].Position)
                    {
                        position.Text = pumpPosition.ToString();
                        vehicles.Text = Pump.Pumps[i, j].ServVehicles.ToString();
                        fuel.Text = Pump.Pumps[i, j].DispensedFuelPerPump.ToString() + "L";
                        lpgType.Text = Pump.Pumps[i, j].DispensedLPG.ToString() + "L";
                        dieselType.Text = Pump.Pumps[i, j].DispensedDiesel.ToString() + "L";
                        unleadedType.Text = Pump.Pumps[i, j].DispensedUnleaded.ToString() + "L";
                        comission.Text = ((Pump.Pumps[i, j].Commission / 100) + 2.49 * 8).ToString() + "£";
                    }         
                }
            }
        }
    }
}
