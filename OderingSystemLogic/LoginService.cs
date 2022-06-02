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

                throw new Exception("The system couldn't connect to the database");
            }

        }
    }
}
