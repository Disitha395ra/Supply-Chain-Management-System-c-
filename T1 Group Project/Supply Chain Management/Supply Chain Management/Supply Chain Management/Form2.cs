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
    public partial class Form2 : Form
    {
        public static string email;
        public static string password;
        Form3 Log = null;
        ErrorProvider errBox = new ErrorProvider();
        public Form2()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if(Log == null || Log.IsDisposed)
            {
                Log = new Form3();
            }
            Log.Show();
            this.Hide();
        }
        public Boolean Validate()
        {
            errBox.Clear();
            if(!Regex.IsMatch(textBoxRegCompany.Text, @"^[A-Za-z\s]+$"))
            {
                errBox.SetError(textBoxRegCompany, "Invalid input");
                return false;
            }
            if(!Regex.IsMatch(textBoxEmail.Text, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")){
                errBox.SetError(textBoxEmail, "Invalid input");
                return false;
            }
            if(!Regex.IsMatch(textBoxName.Text, @"^[A-Za-z\s]+$"))
            {
                errBox.SetError(textBoxName, "Invalid input");
                return false;
            }
            if (!Regex.IsMatch(textBoxNumber.Text, "^\\d+$"))
            {
                errBox.SetError(textBoxNumber, "Invalid input");
                return false;
            }
            if (!Regex.IsMatch(textBoxAddress.Text, @"^[A-Za-z\s]+$"))
            {
                errBox.SetError(textBoxAddress, "Invalid input");
                return false;
            }
            if (!Regex.IsMatch(textBoxAddress.Text, @"^[A-Za-z\s]+$"))
            {
                errBox.SetError(textBoxAddress, "Invalid input");
                return false;
            }
            if (!Regex.IsMatch(textBoxPassword.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
            {
                errBox.SetError(textBoxPassword, "Invalid input");
                return false;
            }
            if (!Regex.IsMatch(textBoxCPassword.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
            {
                errBox.SetError(textBoxCPassword, "Invalid input");
                return false;
            }
           
            return true;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click_1(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != textBoxCPassword.Text)
            {
                errBox.SetError(textBoxCPassword, "not matching password and confirm password");
            }
            else
            {
                if (Validate())
                {
                    MessageBox.Show("OK", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    email = textBoxEmail.Text;
                    password = textBoxPassword.Text;
                    Form3 Log1 = new Form3(this);
                    Log1.Show();
                    // this.Hide();
                }
            }
        }
    }
}
