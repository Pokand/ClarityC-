using ClarityC_.ReciptUI;
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
            ReceiptButn.Click += ReceiptButn_Click;
        }

        
        private void Clockbtn_Click(object? sender, EventArgs e)
        {
            clockbClass1.Visible = !clockbClass1.Visible;
            clockbClass1.BringToFront();
            reciptPanel1.Enabled = !reciptPanel1.Enabled;
        }

        private void ReceiptButn_Click(object? sender, EventArgs e)
        {
            reciptPanel1.Visible = !reciptPanel1.Visible;

        }

        private void MusikButn_Click(object sender, EventArgs e)
        {
            musikClass1.Visible = !musikClass1.Visible; 
        }
    }
}
