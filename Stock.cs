using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoCrud
{
    public class Stock
    {
        public int index;
        public string itemName;
        public double itemPrice;

        public Stock(int idx ,string itn , double itp)
        {
            this.index = idx;
            this.itemName = itn;
            this.itemPrice = itp;
        }

    }
}
