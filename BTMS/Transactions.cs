using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS
{
    class Transactions
    {
        private string description, teller;
        private int tid, account, amount;
        private DateTime date;


        public Transactions(int Account, int Amount, string Description, DateTime Date, string Teller)
        {
            account = Account;
            amount = Amount;
            description = Description;
            date = Date;
            teller = Teller;
        }

        public int TransactionID
        {
            get { return tid; }
            set { tid = value; }
        }

        public int Account
        {
            get { return account; }
            set { account = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Teller
        {
            get { return teller; }
            set { teller = value; }
        }
    }
}
