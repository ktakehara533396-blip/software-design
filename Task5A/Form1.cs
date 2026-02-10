using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//NOTE: RIGHT CLICK THE PROJECT "Task5A", THEN CLICK "Set as Startup Project" TO RUN THE CODE SUCCESSFULLY

namespace Task5A
{
    public partial class Form1 : Form
    {
        int[] numbers = { 3, 4, 1, 2, 5 };
        public Form1()
        {
            InitializeComponent();
            DisplayArray();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            BubbleSort(numbers);
            DisplayArray();
        }

        void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++) 
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        void DisplayArray()
        {
            listBoxResults.Items.Clear();

            foreach(int num in numbers)
            {
                listBoxResults.Items.Add(num);
            }
        }
  
   }

}
