namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] ProceduralSort(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4 };
            int[] sortedNumbers = ProceduralSort(numbers);
            listBoxResults.DataSource = sortedNumbers;
        }
        
        // Add this method to your Form1 class to fix CS0103
        private void listBoxResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You can add your logic here if needed, or leave it empty if not used
        }
    }
}
