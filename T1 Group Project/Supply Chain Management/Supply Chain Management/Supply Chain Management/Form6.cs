using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supply_Chain_Management
{
    public partial class Form6 : Form
    {
        Form5 ob = null;
        public Form6()
        {
            InitializeComponent();
            
            dateTimePickerArrive.ValueChanged += DateValueChanged;
            dateTimePickerPickup.ValueChanged += DateValueChanged;

            
            CalculateAndDisplayDays();
        }
        public Form6(Form5 ob2)
        {
            InitializeComponent();
            ob = ob2;
            textBox1.Text = ob.getAddressFinal();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        private void DateValueChanged(object sender, EventArgs e)
        {
            // Handle the ValueChanged event of both DateTimePickers
            CalculateAndDisplayDays();
        }

        private void CalculateAndDisplayDays()
        {
            
            DateTime pastDate = dateTimePickerPickup.Value;
            DateTime currentDate = dateTimePickerArrive.Value;

            
            int daysDifference = (int)(currentDate - pastDate).TotalDays;

            
            textBox2.Text = daysDifference.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
