namespace GALCERAN_S_CALCULATOR
{
    public partial class Form1 : Form
    {

        string currentInput = "";
        double rtesult = 0;
        string operation = "";
        bool operationPending = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput = button.Text;
            textBox.Text = currentInput;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput = button.Text;
            textBox.Text = currentInput;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput = button.Text;
            textBox.Text = currentInput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput = button.Text;
            textBox.Text = currentInput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput = button.Text;
            textBox.Text = currentInput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput = button.Text;
            textBox.Text = currentInput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput = button.Text;
            textBox.Text = currentInput;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput = button.Text;
            textBox.Text = currentInput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput = button.Text;
            textBox.Text = currentInput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput = button.Text;
            textBox.Text = currentInput;
        }


    }
}
