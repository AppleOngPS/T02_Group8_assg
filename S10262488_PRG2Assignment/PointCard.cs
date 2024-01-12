using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10262488_PRG2Assignment
{
    internal class PointCard
    {
        public int Points { get; set; }
        public int PunchCard { get; set; }
        public string Tier { get; set; }
        public PointCard() { }
        public PointCard(int points, int punchCard)
        {
            Points = points;
            PunchCard = punchCard;
        }
        //addpoints(int)
        void  AddPoint(int points) 
        { 
            Points += points;
        }
        //redeem points
        void RedeemPoints(int pointsToRedeem)
        {
            Points -= pointsToRedeem;
        }
        //punch()
        void punch() { PunchCard = 0; }

        public override string ToString()
        {
            return "Points: "+Points+"Punch Card"+PunchCard+"Tier "+Tier;
        }
    }
}
