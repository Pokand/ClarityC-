using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClarityC_.TaimerUI
{
    public partial class TaimerUI : UserControl
    {
        public TaimerUI()
        {
            InitializeComponent();
            taimerStartBtn1.Click += taimerStartBtn1_Click;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle rec = new Rectangle(0, 0, Width - 1, Height - 1);
            g.DrawRectangle(new Pen(Color.FromArgb(30, Color.Blue)), rec);

        }

        private  void taimerStartBtn1_Click(object sender, EventArgs e)
        {
            
            int hours = textTaimer1.Text[0];
            int mints = textTaimer1.Text[3];
            int sec = textTaimer1.Text[6];
            forWihle( hours,  mints,  sec);

        }

        private void forWihle(int hours, int mints, int sec)
        {
            
            textTaimer1.Text = hours.ToString() + ":" + mints.ToString() + ":" + sec.ToString();
            textTaimer1.Invalidate();
              
        

            SoundPlayer sp = new SoundPlayer("C:\\Windows\\Media\\Alarm06.wav");
            sp.Play();
            taimerStartBtn1.Enabled=true;
        }

        private void TaimerUI_Load(object sender, EventArgs e)
        {

        }
    }
}
