using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Task_5
{
    public partial class Form1 : Form
    {

        int[] numbers = { 60, 35, 25, 15, 5, 10, 90 };

        //Note: Click the "Sort Button twice or more to Bubble sort the given numbers

        public Form1()
        {
            InitializeComponent();
            DisplayArray();
        }

       private void buttonSort_click2_Click(object sender, EventArgs e)
        {
            BubbleSort(numbers);
            DisplayArray();
        }

        void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for (int i=0; i <n-i-1; i++)
            {
                for (int j=0; j < n-i-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
        }

        void DisplayArray()
        {
            listBox1.Items.Clear();

            foreach (int num in numbers)
            {
                listBox1.Items.Add(num);
            }
        }

    }
}
