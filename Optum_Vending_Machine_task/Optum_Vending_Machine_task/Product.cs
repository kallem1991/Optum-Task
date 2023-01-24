using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optum_Vending_Machine_task
{
    class Product
    {
        public int pID { get; set; }
        public string pName { get; set; }
        public double price { get; set; }

        public List<Product> GetProducts()
        {
           List<Product> pList = new List<Product>()
           {
                 new Product() {pID= 101,pName= "cola",price= 1.00 },
                 new Product() {pID= 102,pName= "chips",price= 0.50 },
                 new Product() {pID= 103,pName= "candy",price= 0.65 },
                 new Product() {pID= 104,pName= "coke",price= 1.50 }
           };
            return pList;
        }
}
}


