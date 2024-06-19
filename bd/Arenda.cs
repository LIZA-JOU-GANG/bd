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
    public partial class Arenda : Form
    {
        public Arenda()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViborArenda form7 = new ViborArenda();
            this.Hide();
            form7.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViborArenda form7 = new ViborArenda();
            this.Hide();
            form7.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViborArenda form7 = new ViborArenda();
            this.Hide();
            form7.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViborArenda form7 = new ViborArenda();
            this.Hide();
            form7.ShowDialog();
            this.Close();
        }

        private void Arenda_Load(object sender, EventArgs e)
        {

        }
    }
}
