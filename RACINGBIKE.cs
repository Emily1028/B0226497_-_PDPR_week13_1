using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR_week13_1
{
    class RACINGBIKE:BICYCLE
    {
        private string speeds { set; get; }
        
        public RACINGBIKE(string s,string t,string c,float d,float p,float k)
        {
            speeds = s;
            type = t;
            color = c;
            distance = d;
            price = p;
            kg = k;
        }
        public string printRACINGBIKE()
        {
            return $"\n色彩:{getCOLOR()}，車重:{getKG()}，輪距:{getDISTANCE()}，車型:{getTYPE()}，車價:{getPRICE()}，車速:{speeds}";
        }
    }
}
