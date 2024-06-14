using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal interface IAccount
    {
        void CheckBalance();
        bool IsEnough(double amount);
        void Transfer(double amount);
    }
}
