using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10262488_PRG2Assignment
{
    internal class Customer
    {
        public string Name { get; set; }
        public int MemberId { get; set; }
        public DateTime Dob { get; set; }
        public List<Order> orderHistory { get; set; } = new List<Order>();
        //reward: point card need to do pointcard
        public int RewardPoints { get; set; } = 0; 

        //constructor
        public Customer() { }
        public Customer(string name, int memberId, DateTime dob)
        {
            Name = name;
            MemberId = memberId;
            Dob = dob;
        }
        //makeorder: order not sure how
        public void MakeOrder(Order order)
        {
           
        }

        
        public bool IsBirthday()
        {
            DateTime currentDate = DateTime.Now;
            return Dob.Month == currentDate.Month && Dob.Day == currentDate.Day;
        }

        //tostring
        public override string ToString()
        {
            return "Customer Name"+Name+ "Member ID"+ "MemberId"+ "Date of Birth"+ Dob+ "Reward Points" + RewardPoints;
        }



    }
}
