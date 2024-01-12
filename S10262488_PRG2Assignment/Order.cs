using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10262488_PRG2Assignment
{
    internal class Order
    {
        public int Id { get; set; }

        public DateTime TimeReceived { get; set; }

        public DateTime? TimeFulfilled { get; set; }

        public List<IceCream> IceCreamList { get; set; } = new List<IceCream>();

        public Order() { }

        public Order(int id, DateTime timeReceived)
        {
            Id = id;
            TimeReceived = timeReceived;
        }

        public void ModifyIceCream(int id)
        {
            Id = id;
        }

        public void AddIceCream(IceCream iceCream)
        {
            IceCreamList.Add(iceCream);
        }

        public void DeleteIceCream(int id)
        {
            Id = id;
        }

        public double CalculateTotal()
        {
            return 0;
        }

        public override string ToString()
        {
            return base.ToString() + "\tID: " + Id + "\tTime Received: " + TimeReceived
                + "\tTime Fulfilled: " + TimeFulfilled;
        }
    }

}
