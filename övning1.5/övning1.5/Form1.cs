using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning1._5
{
    public partial class Form1 : Form
    {
        private List<Car> cars = new List<Car>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Car.VehicleType type;

            if (comboBoxDrop.Text.Equals("Bil"))
            {
                type = Car.VehicleType.Car;
            }
            else
            {
                type = Car.VehicleType.Motorcycle;
            }

            if (Car.CheckPlate(tbxReg.Text))
            {
                Car nyCAR = new Car(tbxReg.Text, tbxMark.Text, tbxModel.Text, type);
                cars.Add(nyCAR);

                UpdateList();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void UpdateList()
        {
            lbxReg.Items.Clear();

            if (rbxAll.Checked)
            {
                foreach (Car c in cars)
                {
                    lbxReg.Items.Add(c);
                }
            }
            else if (rbxCar.Checked)
            {
                foreach (Car c in cars)
                {
                    if(c.Type == Car.VehicleType.Car)
                    {
                        lbxReg.Items.Add(c);
                    }         
                }
            }
            else if (rbxMC.Checked)
            {
                foreach (Car c in cars)
                {
                    if (c.Type == Car.VehicleType.Motorcycle)
                    {
                        lbxReg.Items.Add(c);
                    }
                }
            }

        }

        private void RbxAll_CheckedChanged(object sender, EventArgs e)
        {
            UpdateList();
        }
    }
}
