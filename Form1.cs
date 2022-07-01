using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B0226497_段昱如_PDPR_week13_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblRESULT_Click(object sender, EventArgs e)
        {

        }
        String str = "";
        Random rnd = new Random();
        private void btnOK_Click(object sender, EventArgs e)
        {
            List<RACINGBIKE> listgRACINGBIKE = new List<RACINGBIKE>();
            for (int i = 0; i < 10; i++)
            {
                RACINGBIKE racingbike = new RACINGBIKE($"{i}",$"A_{i+1}","BLACK",rnd.Next(5,10),rnd.Next(500,1000),rnd.Next(5,10));
                str += racingbike.printRACINGBIKE();
            }
            lblRESULT.Text = str;
        }
    }
}
