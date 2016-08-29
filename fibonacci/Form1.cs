using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            
            for(int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
                listBox1.Items.Add(Fibonacci(i));
        }
    }
}
