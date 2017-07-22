using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Windows.Forms;

namespace fibonacci
{
    public partial class Form1 : Form
    {
        private Stopwatch sw = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        // old calculation code left to be admired

        //public static BigInteger Fibonacci(long n)
        //{
        //    BigInteger a = 0;
        //    BigInteger b = 1;
        //
        //    for (long i = 0; i < n; i++)
        //    {
        //        BigInteger temp = a;
        //        a = b;
        //        b = temp + b;
        //    }
        //
        //    return a;
        //}

        public static List<BigInteger> FibonacciList(int n)
        {
            List<BigInteger> list = new List<BigInteger>((int)n);

            BigInteger a = 0;
            if (n >= 0)
                list.Add(a);

            BigInteger b = 1;
            if (n >= 1)
                list.Add(b);

            for (int i = 0; i < n; i++)
            {
                BigInteger temp = a;
                a = b;
                b = temp + b;

                list.Add(b);
            }

            return list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sw.Reset();
            label1.Text = "";

            try
            {
                listBox1.Items.Clear();
                int uLimit = int.Parse(textBox1.Text);
                sw.Start();

                List<BigInteger> list = FibonacciList(uLimit);
                sw.Stop();

                foreach (BigInteger f in list) listBox1.Items.Add(f);
                label1.Text = "calculation time: " + sw.Elapsed.TotalMilliseconds + "ms";
            }

            catch
            {
                label1.Text = "error";
                MessageBox.Show("error", "please enter how many fibonacci numbers you want to be calculated");
            }
        }
    }
}
