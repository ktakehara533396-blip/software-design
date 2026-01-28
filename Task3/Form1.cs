using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public int RecursiveFibonacci(int n)
        {
            if (n <= 1) return n;
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        private void btnFibonacciSeq_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtFibonacciSeqInput.Text);

            int result = RecursiveFibonacci(number);
            lblFibonacciSeqResult.Text = $"Recursive Fibonacci Sequence: {result}";
        }


        

    }
}
