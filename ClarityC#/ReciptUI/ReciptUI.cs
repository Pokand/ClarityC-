using Newtonsoft.Json;
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
        public ReciptUI(string day, Color backcolor1)
        {
            InitializeComponent();
            _day = day;
            label1.Text = day;
            checkBox1.Hide();
            day = ReciptPanel._monts + "/" + _day + "/" + ReciptPanel._yyears;
            BackColor = backcolor1;
            label1.BackColor = backcolor1;
            checkBox1.BackColor = backcolor1;
        }
        public ReciptUI()
        {
            InitializeComponent();
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
                    label1.ForeColor = Color.FromArgb(20, Color.White);
                }
            }
            catch (Exception) { }
        }

        
        private void panel1_Click(object sender, EventArgs e)
        {
            ReciptPanel cl = new ReciptPanel();
            if(label1.Text == "")
            {
                textBox1.Enabled = false;
                textBox1.Visible = false;
                return;
            }
            if (checkBox1.Checked == false)
            {
                checkBox1.Checked = true;

                DayToSet dts = new DayToSet()
                {
                    day = label1.Text,
                    monts = cl.retunMonts(),
                    year = cl.returnYears(),
                    TEXT = textBox1.Text
                };
                var json =  JsonConvert.SerializeObject(dts);
                using (var writer = new StreamWriter("daytoset.json", true))
                {
                    writer.WriteLine(json);
                }

                BackColor = Color.FromArgb(255, 128, 128);
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

    public class DayToSet {
        public string day;
        public int monts;
        public int year;
        public string TEXT;

    }

}
