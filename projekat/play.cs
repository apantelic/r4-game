﻿using System;
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
    public partial class play : Form
    {
        public play()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lena r4 = new lena();
            r4.Visible = true;
            r4.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            zuta zy = new zuta();
            zy.Visible = true;
            zy.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            bela wb = new bela();
            wb.Visible = true;
            wb.Show();
            this.Hide();
        }
    }
}
