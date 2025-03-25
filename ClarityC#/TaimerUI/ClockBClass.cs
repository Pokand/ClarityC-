using ClarityC_.TaimerUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClarityC_
{
    public partial class ClockBClass : UserControl
    {
        NewTaimerForm nw= new NewTaimerForm();
        public ClockBClass()
        { 
            InitializeComponent();
            newTaimer1.Click += newTaimer1_Click;
            
        }
        
        private void taimerui2_Load(object sender, EventArgs e)
        {
            taimerui2.textTaimer1.Text = "00:05:00";
            taimerui3.textTaimer1.Text = "00:30:00";
            taimerui4.textTaimer1.Text = "01:00:00";
        }

        private void newTaimer1_Click(object sender, EventArgs e)
        {
            nw.Show();
            
        }
    }
}
