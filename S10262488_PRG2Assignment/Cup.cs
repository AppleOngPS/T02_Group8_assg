﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10262488_PRG2Assignment
{
    internal class Cup:IceCream
    {
        public Cup () { }
        public Cup(string option, int scoops, List<Flavour> flavours, List<Topping> toppings) : base(option, scoops, flavours, toppings)
        {
            
        }
        public double CalculatePrice()
        {
            double price = 0.00;
           
            {
                if (Scoops == 1)
                {
                    price = 4.00;
                }
                else if (Scoops == 2)
                {
                    price = 5.50;
                }
                else if (Scoops == 3)
                {
                    price = 6.50;
                }
            }
            foreach (Flavour flavour in Flavours)
            {
                if (flavour.Premium)
                {
                    price += 2.00;
                }
            }
            foreach (Topping topping in Toppings)
            {
                price += 1.00;
            }

            

            return price;
        }
        public override string ToString()
        {
            return base.ToString(); 
        }
    }
}
