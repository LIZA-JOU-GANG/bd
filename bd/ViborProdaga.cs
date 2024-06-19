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
    public partial class Form12 : Form
    {
        string[] a = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        public Form12()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(a);
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddObyav form11 = new AddObyav();
            this.Hide();
            form11.ShowDialog();
            this.Close();
        }
    }
}
