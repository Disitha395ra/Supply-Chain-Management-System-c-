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
    public partial class Form3 : Form
    {
        Form2 Reg = null;
        Form4 product = null;
        ErrorProvider errBoxLog = new ErrorProvider();
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Form2 regDetails)
        {
            InitializeComponent();
            Reg = regDetails;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if(Reg==null || Reg.IsDisposed)
            {
                Reg = new Form2();
            }
            Reg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((Form2.email == textBoxEmailLog.Text && Form2.password == textBoxPasswordLog.Text) || (textBoxEmailLog.Text == "Admin" && textBoxPasswordLog.Text == "Admin123@#$"))
            {

                if (product == null || product.IsDisposed)
                {
                    product = new Form4();
                }
                product.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid password or email", "OK", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                textBoxEmailLog.Clear();
                textBoxPasswordLog.Clear();
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if ((Form2.email == textBoxEmailLog.Text && Form2.password == textBoxPasswordLog.Text) || (textBoxEmailLog.Text == "Admin" && textBoxPasswordLog.Text == "Admin123@#$"))
            {

                if (product == null || product.IsDisposed)
                {
                    product = new Form4();
                }
                product.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid password or email", "OK", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                textBoxEmailLog.Clear();
                textBoxPasswordLog.Clear();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
