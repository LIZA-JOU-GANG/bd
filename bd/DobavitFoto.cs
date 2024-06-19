using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd
{
    public partial class AddObyav : Form
    {
        public AddObyav()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Varianti form9 = new Varianti();
            this.Hide();
            form9.ShowDialog();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form12 form12 = new Form12();
            this.Hide();
            form12.ShowDialog();
            this.Close();
        }

        private void AddObyav_Load(object sender, EventArgs e)
        {

        }
    }
}
