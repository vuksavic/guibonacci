using System;
using System.Windows.Forms;

namespace fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static long Fibonacci(long n)
        {
            long a = 0;
            long b = 1;
            
            for(long i = 0; i < n; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (long i = 0; i < Convert.ToInt64(textBox1.Text); i++)
                listBox1.Items.Add(Fibonacci(i));
        }
    }
}
