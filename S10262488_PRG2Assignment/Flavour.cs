using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10262488_PRG2Assignment
{
    internal class Flavour
    {
        public int Type { get; set; }
        public bool Premium { get; set; }
        public int Quantity { get; set; }

        //constructor
        public Flavour() { }
        public Flavour(int t,bool p ,int q)
        {
            Type = t;
            Premium = p;
            Quantity = q;
        }

        public override string ToString()
        {
            return base.ToString() + "Type: "+Type+ "\tPremium: "+ Premium +"\tQuantity: "+ Quantity;
        }
    }
}
