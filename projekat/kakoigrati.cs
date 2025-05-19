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
    public partial class kakoigrati : Form
    {
        public kakoigrati()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            play pa = new play();
            pa.Visible = true;
            pa.Show();
            this.Hide();
        }
    }
}
