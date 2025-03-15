namespace ClarityC_
{
    public partial class Form1 : Form
    {
        Point movestart;
        public Form1()
        {
            InitializeComponent();

            ReceiptButn.Click += button1_Click;
            SettingButn.Click += button2_Click;
            MusikButn.Click += btn3_Click;
            groupBox1.BackColor = Color.Transparent;
        }
        private void button2_Click(object? sender, EventArgs e)
        {
            MusikButn.Visible = !MusikButn.Visible;
        }
        private void btn3_Click(object? sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        private void button1_Click(object? sender, EventArgs e)
        {
            groupBox1.Visible = !groupBox1.Visible;
        }

       

        

        
    }
}
