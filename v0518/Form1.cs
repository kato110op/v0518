namespace v0518
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Left = 0;
            button1.Left = button1.Left - 10;
            button1.Top = button1.Top - 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Left = button2.Left + 120;
            button2.Top = button2.Top + 110;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Left = button4.Left - 400;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            button1.Left = button1.Left - 10;
            button1.Top = button1.Top - 10;
            button2.Left = button2.Left + 120;
            button2.Top = button2.Top + 110;
            button4.Left = button4.Left - 400;
            button3.Left = button3.Left - 90;
            button3.Left = button3.Left + 100;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Left = button3.Left - 90;
            button3.Left = button3.Left + 100;
            //button3.Top = button3.Top + 110;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}