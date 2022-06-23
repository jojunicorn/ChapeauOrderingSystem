using OrderingSystemDAL;
using OrderingSystemModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSystemLogic
{
    public class LoginService
    {

        private LoginDAO loginDB;

        public LoginService()
        {
            loginDB = new LoginDAO();
        }

        public Employee GetUser(string username)
        {
            try
            {
                Employee employee = loginDB.GetUser(username);
                return employee;
            }
            catch (Exception)
            {
                throw new Exception("Something went wrong while loading the user.");
            }

        }

        public List<Employee> GetAllUsers()
        {
            try
            {
                return loginDB.GetAllUsers();
            }
            catch (Exception)
            {
                throw new Exception("Something went wrong while loading the users.");
            }
        }
    }
}
