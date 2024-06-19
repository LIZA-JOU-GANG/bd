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
    public partial class Varianti : Form
    {
        
        public Varianti()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViborArenda form7 = new ViborArenda();
            this.Hide();
            form7.ShowDialog();
            this.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            this.Hide();
            form10.ShowDialog();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            this.Hide();
            form10.ShowDialog();
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            this.Hide();
            form10.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Izbrannoe form13 = new Izbrannoe();
            this.Hide();
            form13.ShowDialog();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Izbrannoe form13 = new Izbrannoe();
            this.Hide();
            form13.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            this.Hide();
            form10.ShowDialog();
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            this.Hide();
            form10.ShowDialog();
            this.Close();
        }
    }
}
