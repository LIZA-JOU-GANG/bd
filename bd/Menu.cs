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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vrarization form2 = new Vrarization();
            this.Hide();
            form2.ShowDialog();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration form3 = new Registration();
            this.Hide();
            form3.ShowDialog();
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminForm form1 = new AdminForm();
            this.Hide();
            form1.ShowDialog();
           
        }
    }
}
