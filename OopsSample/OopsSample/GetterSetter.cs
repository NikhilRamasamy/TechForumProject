using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsSample
{
    class Account
    {
        //Constructor
        public Account()
        {
            Console.WriteLine("From Constructor");
        }

        //Destructor
        ~Account()
        {
            Console.WriteLine("From Destructor");
        }

        //getter and setter
        private string accountNumber { get; set; }

        //getter and setter with logic inside
        private double balance 
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        //public double getBalance()
        //{
        //    return balance;
        //}

        //public void setBalance(double _amount)
        //{
        //    balance = _amount;
        //}

    }
}
