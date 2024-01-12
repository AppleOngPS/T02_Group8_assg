using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace S10262488_PRG2Assignment
{
    abstract class IceCream
    {
        public string Option { get; set; }
        public int Scoops { get; set; }

        public List<Flavour> Flavours { get; set; } = new List<Flavour>();
        public List<Topping> Toppings { get; set; } = new List<Topping>();

        //constructor
        public IceCream() { }   
        public IceCream(string option, int scoops, List<Flavour> flavours, List<Topping> toppings)
        {
            Option = option;
            Scoops = scoops;
            Flavours = flavours;
            Toppings = toppings;
        }
        string option;
        
        public virtual double CalculatePrice()
        {


            return 0;
            
        }

        public override string ToString()
        {
            return base.ToString()+"Option: "+ option +"\tScoops: ";
        }

    }
}
