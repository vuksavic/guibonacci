using System;
using System.Numerics;
using System.Windows.Forms;

namespace fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static BigInteger Fibonacci(long n)
        {
            BigInteger a = 0;
            BigInteger b = 1;
            
            for(long i = 0; i < n; i++)
            {
                BigInteger temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < Convert.ToInt64(textBox1.Text); i++)
                listBox1.Items.Add(Fibonacci(i));
        }
    }
}
