using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Supply_Chain_Management
{
    public partial class Form5 : Form
    {
        Form4 det1 = null;
        Form6 final = null;
        
        private Random rnd = new Random();
        ErrorProvider errStock = new ErrorProvider();
        public Form5()
        {
            InitializeComponent();
            this.Load += Form5_Load; 

        }
        public Form5(Form4 det)
        {
            InitializeComponent();
            det1 = det;
            textBoxPID.Text = det1.getPID();
        }

        public Boolean ValidateStock()
        {
            if(!Regex.IsMatch(textBoxPName.Text, @"^[A-Za-z\s]+$")){
                errStock.SetError(textBoxPName, "Invalid name");
                return false;
            }
            if(!Regex.IsMatch(textBoxPDetails.Text, @"^[A-Za-z\s]+$"))
            {
                errStock.SetError(textBoxPDetails, "Invalid input");
                return false;
            }
            if (!Regex.IsMatch(textBoxPDetails.Text, @"^[A-Za-z\s]+$"))
            {
                errStock.SetError(textBoxPDetails, "Invalid input");
                return false;
            }
            if(!Regex.IsMatch(textBoxQuantityDel.Text, "^\\d+$"))
            {
                errStock.SetError(textBoxQuantityDel, "Invalid input");
                return false;
            }
            return true;
        }
        private void textBoxOrderID_TextChanged(object sender, EventArgs e)
        {
            

            
        }

        private void textBoxPID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < 1; j++)
            {
                textBoxOrderID.AppendText("ORD"+rnd.Next(0,10000).ToString() + Environment.NewLine);

            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonSubmit_Click_1(object sender, EventArgs e)
        {
            
            if (final == null || final.IsDisposed)
            {
                final = new Form6();
            }
            final.Show();
        }
        public string getAddressFinal()
        {
            return textBoxAddress.Text;
        }
        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
