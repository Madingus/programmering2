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
            Car nyCAR = new Car(tbxReg.Text, tbxMark.Text, tbxModel.Text, comboBoxDrop.Text);
            cars.Add(nyCAR);

            lbxReg.Items.Add(nyCAR);
            

            

        }
    }
}
