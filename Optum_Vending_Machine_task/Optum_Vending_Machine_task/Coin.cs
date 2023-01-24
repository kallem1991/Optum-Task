using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optum_Vending_Machine_task
{
    class Coin
    {
        public int cID { get; set; }
        public string cName { get; set; }
        public double value { get; set; }

        public List<Coin> GetCoins()
        {
           List<Coin> cList = new List<Coin>()
           {
                 new Coin() {cID= 1001,cName= "Nickels",value= 0.05 },
                 new Coin() {cID= 1002,cName= "Dimes",value= 0.1 },
                 new Coin() {cID= 1003,cName= "quarter",value= 0.25 },
                 new Coin() {cID= 1004,cName= "Penny",value= 0.01 }
           };
            return cList;
        }
}
}


