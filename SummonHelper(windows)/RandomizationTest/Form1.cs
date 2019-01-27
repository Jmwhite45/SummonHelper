using SummonHelper_windows_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomizationTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void run(int d)
        {
            switch (d)
            {
                case 4:
                    d4output.Text = Test(d) + Environment.NewLine + d4output.Text;
                    break;
                case 6:
                    d6output.Text = Test(d) + Environment.NewLine + d6output.Text;
                    break;
                case 8:
                    d8output.Text = Test(d) + Environment.NewLine + d8output.Text;
                    break;
                case 10:
                    d10output.Text = Test(d) + Environment.NewLine + d10output.Text;
                    break;
                case 12:
                    d12output.Text = Test(d) + Environment.NewLine + d12output.Text;
                    break;
                case 20:
                    d20output.Text = Test(d) + Environment.NewLine + d20output.Text;
                    break;
                case 100:
                    d100output.Text = Test(d) + Environment.NewLine + d100output.Text;
                    break;
            }
        }

        public decimal Test(int num)
        {
            Atk a = new Atk(0, 0,0,0);
            Random rnd = new Random();
            int rounds = (int)Rounds.Value;
            int[] results = new int[rounds];


            for(int i = 0; i<rounds; i++)
            {
                a.rollDam(rnd);
                results[i] = a.damTotal;
                a.damTotal = 0;
            }

            return average(results);
        }
       
        private decimal average(int[] nums)
        {
            int total = 0;
            int count = 0;
            foreach(int i in nums)
            {
                total += i;
                count++;
            }

            return total / count;
        }

        private void btnd4_Click(object sender, EventArgs e)
        {
            run(4);
        }

        private void btnd6_Click(object sender, EventArgs e)
        {
            run(6);
        }

        private void btnd8_Click(object sender, EventArgs e)
        {
            run(8);
        }

        private void btnd10_Click(object sender, EventArgs e)
        {
            run(10);
        }

        private void btnd12_Click(object sender, EventArgs e)
        {
            run(12);
        }

        private void btnd20_Click(object sender, EventArgs e)
        {
            run(20);
        }

        private void btnd100_Click(object sender, EventArgs e)
        {
            run(100);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            run(4);
            run(6);
            run(8);
            run(10);
            run(12);
            run(20);
            run(100);
        }
        /*
private decimal[] FPS(int[] nums)
{
decimal[] result = new decimal[5];

int? min = null;
int? Max = null;
int count = 0;
foreach(int i in nums)
{
if((min == null)||(i<min))
{
min = i;
}

if ((Max == null) || (i > Max))
{
Max = i;
}

count++;
}
result[0] = (decimal)min;
result[4] = (decimal)Max;

if(count%2 == 0)
{
nums[count/2]
}
else
{
nums[]
}
}*/
    }
}
