using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoCrud
{
    public class Wallet
    {
        public static double balance { get; set; }

        public Wallet(double bl = 00.00)
        {
            balance = bl;
        }

    }
}
