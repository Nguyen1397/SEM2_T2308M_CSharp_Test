using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class ExchangedAccount : IAccount
    {
        private double balance;

        public double Balance { get => balance; set => balance = value; }

        public void CheckBalance()
        {
            Console.WriteLine($"Your balancer: {Balance * 25000} đ");
        }

        public bool IsEnough(double amount)
        {
            if (Balance <= amount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Transfer(double amount)
        {
            bool canTransfer = IsEnough(amount);
            if (canTransfer)
            {
                Balance -= amount;
            }
            Console.WriteLine($"Your transferred: {amount * 25000} $, your balancer: {Balance * 25000} đ");
        }
    }
}
