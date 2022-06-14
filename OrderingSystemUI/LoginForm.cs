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
            txtPassword.PasswordChar = '*';

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginService loginService = new LoginService();

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter Username and Password");
            }

            employee = loginService.GetUser(txtUsername.Text);

            if (employee.EmployeeUsername == txtUsername.Text && employee.EmployeePassword == int.Parse(txtPassword.Text))
            {

                if (employee.EmployeePosition == "waiter" || employee.EmployeePosition == "manager")
                {
                    WaiterUI waiter = new WaiterUI(employee);
                    waiter.Show();
                    Hide();
                }

                //added form for each employee to display the orders for bar and kitchen

                else if (employee.EmployeePosition == "bartender") 
                {
                    BarmanUI barman = new BarmanUI(employee);
                    barman.Show();
                    Hide();
                }
                else 
                {
                    ChefUI chef = new ChefUI(employee);
                    chef.Show();
                    Hide();
                }
               
            }

            else
            {
                MessageBox.Show("Username or password is not correct please try again!");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact to the manager.");
        }
    }
}
