using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS
{
    class Employee
    {
        private string eid, name, designation, email, username, password;

        public Employee(string EmpID, string Name, string Designation, string Email, string Username, string Password)
        {
            eid = EmpID;
            name = Name;
            designation = Designation;
            email = Email;
            username = Username;
            password = Password;
        }

        public Employee(string Username, string Password) //method overloading
        {
            Username = username;
            Password = password;
        }

        public string EmpID
        {
            get { return eid; }
            set { eid = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
