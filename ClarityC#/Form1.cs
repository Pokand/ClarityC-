using System.Media;
using System.Reflection;

namespace ClarityC_
{
    public partial class Form1 : Form
    {
        bool ONreceipt = false;


        public Form1()
        {
            InitializeComponent();
            ClockButn.Click += Clockbtn_Click;
            SettingButn.Click += button2_Click;
            MusikButn.Click += btn3_Click;
            button1.Click += button1_Click_1;
        }
        private void button2_Click(object? sender, EventArgs e)
        {

        }
        private void btn3_Click(object? sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        private void Clockbtn_Click(object? sender, EventArgs e)
        {
            ONreceipt = !ONreceipt;
            if (ONreceipt)
            {
                button1.Visible = true;
                numericUpDown1.Visible = true;
                numericUpDown2.Visible = true;
                numericUpDown1.Text = (DateTime.Now.Hour).ToString();
                numericUpDown2.Text = (DateTime.Now.Minute).ToString();
                textBox1.Visible = true;
            }
        }

        private async void button1_Click_1(object? sender, EventArgs e)
        {
            int taimer = 0;
            taimer += (int)numericUpDown1.Value * 60;
            taimer += (int)numericUpDown2.Value;
            taimer *= 60;
            await forWihle(taimer);


        }
        private async Task forWihle(object taimer)
        {
            int taim = (int)taimer;

            while (taim > 0)
            {
                taim--;
                textBox1.Text = taim.ToString();   
                await Task.Delay(1000);
            }
            SoundPlayer sp = new SoundPlayer("C:\\Windows\\Media\\Alarm06.wav");
            sp.Play();
        }

    }
}
