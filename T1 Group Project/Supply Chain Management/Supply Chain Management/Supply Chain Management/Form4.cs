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
    public partial class Form4 : Form
    {
        Form5 stock = null;
        Form3 back = null;
        ErrorProvider productErrBox = new ErrorProvider();
        public Form4()
        {
            InitializeComponent();
        }
        public Boolean validate1()
        {
            productErrBox.Clear();
            if(!Regex.IsMatch(textBoxProductID.Text, "^\\d+$"))
            {
                productErrBox.SetError(textBoxProductID, "invalid input.Enter the numeric value only.");
                return false;
            }
            if(!Regex.IsMatch(textBoxProductName.Text, @"^[A-Za-z\s]+$"))
            {
                productErrBox.SetError(textBoxProductName, "Invalid input");
                return false;
            }
            if(!Regex.IsMatch(textBoxProductCategory.Text, @"^[A-Za-z\s]+$"))
            {
                productErrBox.SetError(textBoxProductCategory, "Invalid input");
                return false;
            }
            if (!Regex.IsMatch(textBoxProductDescription.Text, @"^[A-Za-z\s]+$"))
            {
                productErrBox.SetError(textBoxProductDescription, "Invalid input");
                return false;
            }
            if (!Regex.IsMatch(textBoxProductPrice.Text, @"^\d{0,8}(\.\d{1,4})?$"))
            {
                productErrBox.SetError(textBoxProductPrice, "Invalid input");
                return false;
            }
            if (!Regex.IsMatch(textBoxQuantity.Text, "^\\d+$"))
            {
                productErrBox.SetError(textBoxQuantity, "Invalid input");
                return false;
            }
            return true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public string getPID()
        {
            return textBoxProductID.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (validate1())
            {
                MessageBox.Show("Records are Send to the Admin", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (stock == null || stock.IsDisposed)
                {
                    stock = new Form5(this);
                }
                stock.Show();

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(back==null || back.IsDisposed)
            {
                back = new Form3();
            }
            back.Show();
            this.Hide();
        }
    }
}
