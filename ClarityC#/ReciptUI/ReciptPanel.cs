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
    public partial class ReciptPanel : UserControl
    {
        public static int _yyears, _monts;
        public ReciptPanel()
        {
            InitializeComponent();
        }

        private void ReciptPanel_Load(object sender, EventArgs e)
        {
            Showdays(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void Showdays(int monts, int years)
        {
            
            flowLayoutPanel1.Controls.Clear();
            _yyears = years;
            _monts = monts;

            string monthName = new DateTimeFormatInfo().GetMonthName(monts);
            label8.Text = monthName.ToUpper() + " " + years;
            DateTime starofMonths = new DateTime(years, monts, 1);
            int day = DateTime.DaysInMonth(years, monts);
            int week = Convert.ToInt32(starofMonths.DayOfWeek.ToString("d"));
            for (int i = 1; i < week; i++)
            {
                ReciptUI rui = new ReciptUI("");
                flowLayoutPanel1.Controls.Add(rui);
            }
            for (int i = 1; i < day; i++)
            {
                ReciptUI rui = new ReciptUI(i + "");
                flowLayoutPanel1.Controls.Add(rui);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            _monts--;
            if (_monts < 1)
            {
                _monts = 12;
                _yyears--;
            }
            Showdays(_monts, _yyears);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _monts += 1;
            if(_monts > 12)
            {
                _monts = 1;
                _yyears++;
            }
            Showdays(_monts, _yyears);    
        }
    }
}
