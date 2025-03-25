using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClarityC_.TaimerUI
{
    public partial class NewTaimerForm : Form
    {
        public NewTaimerForm()
        {
            InitializeComponent();
            buttonRet1.Click += buttonRet1_Click;
            buttonReverse1.Click += buttonReverse1_Click;
            classButton1.Click += classButton1_Click; 
        }



        private void buttonRet1_Click(object sender, EventArgs e)
        {
            if (retText1.Text[0] == '0')
            {
                retText1.Text = "0" + (retText1.Text[1] + 1).ToString();
            }
            else if (retText1.Text[1] == '9')
            {
                retText1.Text = (retText1.Text[0] + 1).ToString() + "0";
            }
        }

        private void buttonReverse1_Click(object sender, EventArgs e)
        {
            if (retText1.Text[1] == '0')
            {
                retText1.Text = (retText1.Text[0] - 1).ToString() + "9";
            }
            else retText1.Text = retText1.Text[0].ToString() + (retText1.Text[1] - 1).ToString();
        }

        private void classButton1_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
    }
}
