using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VechicleAppPractice2
{
    //Vehicle aVehicle = new Vehicle();
    public partial class VehicleUi : Form
    {
        //public Vehicle aVehicle;
        Vehicle aVehicle = new Vehicle();
        public string bVehicle; 
        public VehicleUi()
        {
            InitializeComponent();
        }
        

        private void CreateButton_Click(object sender, EventArgs e)
        {
            aVehicle.Name = vehicleNameTextBox.Text;
            aVehicle.Reg = Convert.ToInt32(regNoTextBox.Text);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            aVehicle.Speed = Convert.ToDouble(speedTextBox.Text);
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            bVehicle= aVehicle.Speed.ToString();
            maxSpeedTextBox.Text = bVehicle.Max().ToString();
            minSpeedTextBox.Text = bVehicle.Min().ToString();
            //averageSpeedTextBox.Text = bVehicle.Average().ToString();
        }
    }
}
