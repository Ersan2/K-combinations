namespace HomeworkComb
{
    public partial class Form1 : Form
    {
        Input inputValue = new Input();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
      
        private void button1_Click(object sender, EventArgs e)
        {

            string valueOfN = textBox1.Text;
            
            if (int.Parse(valueOfN)<=1) {
                
                textBox2.AppendText($"Value of n is <1, please renter number that 1<");
                textBox2.AppendText(Environment.NewLine);
                return;
            }
            inputValue.N = int.Parse(valueOfN);
        
            textBox2.AppendText($"value of n is {valueOfN}");
            textBox2.AppendText(Environment.NewLine);


        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            inputValue.InputData(textBox2);

        }
  
        private void button2_Click(object sender, EventArgs e)
        {
           

                string valueOfK = textBox1.Text;
            
            if (int.Parse(valueOfK) <= 1|| int.Parse(valueOfK) > inputValue.N)
            {
                textBox2.AppendText($"Value of k is <1 or k is >n, please renter number that 1< or n<=");
                return;
            }
                inputValue.K = int.Parse(valueOfK);
          
            textBox2.AppendText($"value of k is {valueOfK}");


        }
    }
}
