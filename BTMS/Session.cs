using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS
{
    public static class Session
    {
        public static string Username;
        // this variable stores the username from login Form & can be retrieved from other Forms

        public static string UserType; 
        // this variable stores the usertype from login Form & can be retrieved from other Forms

        public static int Account;
        // this variable stores the account number in MainWindow Form to print the mandate
    }
}
