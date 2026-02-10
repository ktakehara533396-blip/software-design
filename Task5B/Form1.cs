using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//NOTE: RIGHT CLICK THE PROJECT "Task5B", THEN CLICK "Set as Startup Project" TO RUN THE CODE SUCCESSFULLY


namespace Task5B
{
    public partial class Form1 : Form
    {
        int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

        public Form1()
        {
            InitializeComponent();
            DisplayArray(numbers);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            DescendingSorter sorter = new DescendingSorter();
            sorter.Sort(numbers);

            DisplayArray(numbers);
        }

        void DisplayArray(int[] arr)
        {
            listBoxResults.Items.Clear();
            foreach (int num in arr)
            {
                listBoxResults.Items.Add(num);
            }
        }
    }

    public class DescendingSorter
    {
        public void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

          }
        }
    }
