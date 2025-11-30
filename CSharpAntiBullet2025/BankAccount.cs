using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAntiBullet2025
{
    internal class BankAccount
    {
        private int BankID;
        private string AccountBalance=0;

        public void Balance()
        {
            AccountBalance = value;
        }
        public string Deposit(string Value)
        {
            AccountBalance = Value;
            Console.WriteLine($"you added {Value} to your balance successfully!");
            return AccountBalance;
        }

        public string Withdraw (string value)
        {
            AccountBalance - value= AccountBalance;
            Console.WriteLine($"you withdraw {value} from your balance successfully!");
            return AccountBalance;
        }
    }
}
