using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            int a = int.Parse(textBox1.Text);
            if (a % 2 == 0)
            {
                label1.Text = a+"Çift";
            }
            else
            {
                label1.Text = a + "tek";


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int b= x * x;
            label1.Text = x+ "sayısını karesi" + b;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int y = int.Parse(textBox1.Text);
            string durum = "asal";
            for(int i = 2; i < y; i++)
            {
                if (y % i == 0)
                {
                    durum = "asal değil";
                    break;
                }
            }
            label1.Text = y + "sayısı" + durum;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = 1;
            for (int i = 1; i <= a; i++)
            {
                b *= i;
            }
            label1.Text = "faktoriyeli" + b;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int z= int.Parse(textBox1.Text);
            int t = 0;
            for(int i = 1; i <z; i++)
            {
                if (z % i == 0)
                {
                    t = t + i;
                }
            }
            if (z == t)
            {
                label1.Text = z + "sayısı muk";
            }
            else
            {
                label1.Text = z + "sayısı muk degil";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random rs = new Random();
            label1.Text = rs.Next(1, 100) + " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
