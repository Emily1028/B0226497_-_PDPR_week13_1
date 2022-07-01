using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR_week13_1
{
    class BICYCLE
    {
        protected string type { set; get; }
        protected string color { set; get; }
        protected float price { set; get; }
        protected float kg { set; get; }
        protected float distance { set; get; }
        public string getTYPE()
        {
            return type;
        }
        public string getCOLOR()
        {
            return color;
        }
        public float getPRICE()
        {
            return price;
        }
        public float getKG()
        {
            return kg;
        }
        public float getDISTANCE()
        {
            return distance;
        }
    }
}