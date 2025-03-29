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

namespace ClarityC_.MusikUI
{
    public partial class MusikClass : UserControl
    {
        SoundPlayer sp = new SoundPlayer();
        public MusikClass()
        {
            InitializeComponent();
            
            menuStrip1.BackColor = Color.FromArgb(20,Color.White);
            textBox1.Text = Properties.Settings.Default.musikFile;
        }

        private void classButton2_Click(object sender, EventArgs e)
        {
            sp.SoundLocation = Properties.Settings.Default.musikFile;
            sp.Play();
        }

        private void classButton3_Click(object sender, EventArgs e)
        {
            sp.Stop();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "WAV|*.wav";
            ofd.Multiselect = true;
            ofd.ValidateNames = true;
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
               Properties.Settings.Default.musikFile = textBox1.Text = ofd.FileName;
               Properties.Settings.Default.Save();
            }
        }
    }
}
