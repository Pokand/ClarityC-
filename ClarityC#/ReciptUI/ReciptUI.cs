using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClarityC_.ReciptUI
{
    public partial class ReciptUI : UserControl
    {
        string _day, date, weekday;
        Color backcolor;
        public ReciptUI(string day)
        {
            InitializeComponent();
            _day = day;
            label1.Text = day;
            checkBox1.Hide();
            day = ReciptPanel._monts + "/" + _day + "/" + ReciptPanel._yyears;
            backcolor = this.backcolor;
        }
        public void sunday()
        {
            try
            {
                DateTime day = DateTime.Parse(date);
                weekday = day.ToString("ddd");
                if (weekday == "Sun")
                {
                    label1.ForeColor = Color.FromArgb(255, 128, 128);

                }
                else
                {
                    label1.ForeColor = Color.FromArgb(64, 64, 64);
                }
            }
            catch (Exception) { }
        }

        
        private void panel1_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
                this.BackColor = Color.FromArgb(255, 150, 170);


            }
            else
            {
                checkBox1.Checked = false;
                this.BackColor = backcolor;
            }
        }

        private void ReciptUI_Load(object sender, EventArgs e)
        {
            sunday();
        }
    }
}
