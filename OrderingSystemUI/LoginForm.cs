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
        LoginService loginService = new LoginService();
        List<Employee> employees;
        SaltedPasswordService passwordService = new SaltedPasswordService();
        public LoginForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            employees = loginService.GetAllUsers();
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter Username and Password");
            }

            employee = loginService.GetUser(txtUsername.Text);
            if (employees.Contains(employee))
            {
                if (passwordService.VerifyPassword(txtPassword.Text, employee.EmployeePassword, employee.Salt))
                {
                    try
                    {

                        if (employee.EmployeePosition == "waiter" || employee.EmployeePosition == "manager")
                        {
                            WaiterUI waiter = new WaiterUI(employee);
                            waiter.Show();
                            Hide();
                        }

                        else if (employee.EmployeePosition == "bartender" || employee.EmployeePosition == "chef")
                        {
                            BartenderAndChefUI bartenderAndChef = new BartenderAndChefUI(employee);
                            bartenderAndChef.Show();
                            Hide();
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Something wrong with the employee position");
                    }

                }
                else
                {
                    MessageBox.Show("Password is not correct please try again!");
                }
            }
            else
            {
                MessageBox.Show("There is no user with this username.");
            }


        }


        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact to the manager.");
        }
    }
}
