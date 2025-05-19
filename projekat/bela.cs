using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekat
{
    public partial class bela : Form
    {
        public bela()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            play cs = new play();
            cs.Visible = true;
            cs.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            reno.Location = new Point(498, 278);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\vroom.wav");
            player.Play();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            reno.Location = new Point(175, 215);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\vroom.wav");
            player.Play();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            reno.Location = new Point(428, 100);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\vroom.wav");
            player.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            reno.Location = new Point(145, 45);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\vroom.wav");
            player.Play();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            reno.Location = new Point(450,-87);

            congradulations cn = new congradulations();
            cn.Visible = true;
            cn.Show();
            this.Hide();
        }
    }
}
