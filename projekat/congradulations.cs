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
    public partial class congradulations : Form
    {
        public congradulations()
        {
            InitializeComponent();
        }

        private void congradulations_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\a.wav");
            player.Play();
        }
    }
}
