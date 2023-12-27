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
    public partial class Home : Form
    {
        Form2 Reg = new Form2();
        Form3 Log = new Form3();
        
        public Home()
        {
            InitializeComponent();
        }

       

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Log == null || Log.IsDisposed)
            {
                Log = new Form3();

            }
            Log.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Reg == null || Reg.IsDisposed)
            {
                Reg = new Form2();

            }
            Reg.Show();
            this.Hide();
        }
    }
}
