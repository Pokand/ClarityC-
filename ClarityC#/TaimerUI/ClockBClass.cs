using ClarityC_.TaimerUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClarityC_
{
    public partial class ClockBClass : UserControl
    {

        public ClockBClass()
        {
            InitializeComponent();

        }

        private void buttonRet1_MouseDown(object sender, MouseEventArgs e)
        {

            int x = Convert.ToInt32(retText1.Text, 10);
            if (x < 24)
            {
                if (x < 9)
                {
                    retText1.Text = "0" + (x + 1).ToString();
                    retText1.Invalidate();
                }
                else
                {
                    retText1.Text = (x + 1).ToString();
                    retText1.Invalidate();
                }
            }
        }

        private void buttonRet2_MouseDown(object sender, MouseEventArgs e)
        {
            int x = Convert.ToInt32(retText2.Text, 10);
            if (x < 60)
            {
                if (x < 9)
                {
                    retText2.Text = "0" + (x + 1).ToString();
                    retText2.Invalidate();
                }
                else
                {
                    retText2.Text = (x + 1).ToString();
                    retText2.Invalidate();
                }
            }
        }

        private void buttonRet3_MouseDown(object sender, MouseEventArgs e)
        {
            int x = Convert.ToInt32(retText3.Text, 10);
            if (x < 60)
            {
                if (x < 9)
                {
                    retText3.Text = "0" + (x + 1).ToString();
                    retText3.Invalidate();
                }
                else
                {
                    retText3.Text = (x + 1).ToString();
                    retText3.Invalidate();
                }

            }
        }

        private void buttonReverse1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = Convert.ToInt32(retText1.Text, 10);
            if (x > 0)
            {
                if (x <= 10)
                {
                    retText1.Text = "0" + (x - 1).ToString();
                    retText1.Invalidate();
                }
                else
                {
                    retText1.Text = (x - 1).ToString();
                    retText1.Invalidate();
                }
            }
        }

        private void buttonReverse2_MouseDown(object sender, MouseEventArgs e)
        {
            int x = Convert.ToInt32(retText2.Text, 10);
            if (x > 0)
            {
                if (x <= 10)
                {
                    retText2.Text = "0" + (x - 1).ToString();
                    retText2.Invalidate();
                }
                else
                {
                    retText2.Text = (x - 1).ToString();
                    retText2.Invalidate();
                }
            }
        }

        private void buttonReverse3_MouseDown(object sender, MouseEventArgs e)
        {
            int x = Convert.ToInt32(retText3.Text, 10);
            if (x > 0)
            {
                if (x <= 10)
                {
                    retText3.Text = "0" + (x - 1).ToString();
                    retText3.Invalidate();
                }
                else
                {
                    retText3.Text = (x - 1).ToString();
                    retText3.Invalidate();
                }

            }
        }

        
        private async Task forWhile(int hours, int minuts, int sec)
        {
            int taim = hours * 60 + minuts * 60 + sec;
            for(int i = 0; i < taim;i++)
            {

                await Task.Delay(1000);

                sec--;
                if (sec < 0)
                {
                    minuts--;
                    sec = 59;
                }
                if (minuts < 0)
                {
                    hours--;
                    minuts = 59;
                }
                if (sec < 10)
                {
                    retText3.Text = "0" + sec.ToString();
                }
                else
                {
                    retText3.Text = sec.ToString();
                }
                if (minuts < 10)
                {
                    retText2.Text = "0" + minuts.ToString();
                }
                else
                {
                    retText2.Text = minuts.ToString();
                }
                if (hours < 10)
                {
                    retText1.Text = "0" + hours.ToString();
                }
                else
                {
                    retText1.Text = hours.ToString();
                }

                retText3.Invalidate();
                retText1.Invalidate();
                retText2.Invalidate();
              
            }
            SoundPlayer sp = new SoundPlayer("C:\\Windows\\Media\\Alarm06.wav");
            sp.Play();
        }

        private async void classButton1_MouseDown(object sender, MouseEventArgs e)
        {
            int hours = Convert.ToInt32(retText1.Text, 10);
            int minuts = Convert.ToInt32(retText2.Text, 10);
            int sec = Convert.ToInt32(retText3.Text, 10);
            await forWhile(hours, minuts, sec);
        }
    }
}
