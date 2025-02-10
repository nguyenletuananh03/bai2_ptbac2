using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2_ptbac2
{
    public partial class btntinh : Form
    {
        public btntinh()
        {
            InitializeComponent();
        }

        private void bnttinh_Click(object sender, EventArgs e)
        {
            int intA, intB;
            double dbekq;
            Console.WriteLine("------------- CHƯƠNG TRÌNH GIẢI PHƯƠNG TRÌNH BẬC 1------------");
            Console.WriteLine("---------------------------ax + b = 0 ------------------------");
            Console.Write("nhập a:");
            intA = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhập b:");
            intB = Convert.ToInt32(Console.ReadLine());
            if (intA == 0 && intB == 0)
            {
                Console.WriteLine(" Phương trình có vô số nghiệm");

            }
            else if (intA == 0 && intB != 0)
            {
                Console.WriteLine("phương trình vô số nghiệm");
            }
            else
            {
                dbekq = (double)-intB / intA;
                Console.WriteLine("phương trình có 1 nghiệm duy nhất x = {0}", dbekq);
            }
        }

    }
}

