using DSAL01E_Lesson2_Activity_Bautista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3_Exercises
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            password_Txtbox.UseSystemPasswordChar = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            username_Txtbox.Focus();
        }

        private void login_Btn_Click(object sender, EventArgs e)
        {
            string username, password;
            username = "elaiza";
            password = "elaiza12345";

            if (username_Txtbox.Text == username && password_Txtbox.Text == password)
            {
                MainForm adminform = new MainForm();
                MessageBox.Show("You are succesfully accessing accessing your home page!!!");
                adminform.Show();
                this.Hide();
            }
            else if (username_Txtbox.Text == "cashier" && password_Txtbox.Text == "cashier12345")
            {
                Example2 cashierform = new Example2();
                MessageBox.Show("Welcome to Cashier!!!");
                cashierform.Show();
                this.Hide();
            }
            else if (username_Txtbox.Text == "cashier1" && password_Txtbox.Text == "cashier22222")
            {
                Example4 cashierform = new Example4();
                MessageBox.Show("Welcome to Cashier1!!!");
                cashierform.Show();
                this.Hide();
            }
            else if (username_Txtbox.Text == "payrol" && password_Txtbox.Text == "payrol12345")
            {
                Lesson5_Activity payrollform = new Lesson5_Activity();
                MessageBox.Show("Welcome to Payrol Page!!!");
                payrollform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid user account. Please contact your administrator!!!");
                username_Txtbox.Clear();
                password_Txtbox.Clear();
                username_Txtbox.Focus();
            }
        }

        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
