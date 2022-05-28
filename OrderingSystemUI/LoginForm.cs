using OrderingSystemLogic;
using OrderingSystemModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrderingSystemUI
{
    public partial class LoginForm : Form
    {
        Employee employee;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginService loginService = new LoginService();

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter Username and Password");
            }

            employee = loginService.GetUser(txtUsername.Text);

            if (employee.EmployeeUsername == txtUsername.Text && employee.EmployeePassword == txtPassword.Text)
            {

                if (employee.EmployeePosition == "waiter")
                {
                    WaiterUI waiter = new WaiterUI();
                    waiter.Show();
                }
                else if (employee.EmployeePosition == "chef" )
                {
                    //KitchenUI kitchen = new KitchenUI();
                    // kitchen.Show();
                }
                else if (employee.EmployeePosition == "bartender" )
                {
                    //BarUI kitchen = new BarUI();
                   // bar.Show();
                }
            }

            else
            {
                MessageBox.Show("Username or password is not correct please try again!");
            }
        }
    }
}
