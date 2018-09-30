using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS
{
    class Account
    {
        private string customerName, status;
        private int number, balance, customerID;
        private DateTime dateOpened;


        public Account(int Number, string CustomerName, int Balance, int CustomerID, DateTime DateOpened, string Status)
        {
            number = Number;
            customerName = CustomerName;
            balance = Balance;
            customerID = CustomerID;
            dateOpened = DateOpened;
            status = Status;
        }

        public Account(string CustomerName, int CustomerID, DateTime DateOpened, string Status)
        {
            customerName = CustomerName;
            customerID = CustomerID;
            dateOpened = DateOpened;
            status = Status;
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public DateTime DateOpened
        {
            get { return dateOpened; }
            set { dateOpened = value; }
        }


        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
