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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Varianti form9 = new Varianti();
            this.Hide();
            form9.ShowDialog();
            
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agenstvo_nedvijemostiDataSet4.Otzivi". При необходимости она может быть перемещена или удалена.
            this.otziviTableAdapter3.Fill(this.agenstvo_nedvijemostiDataSet4.Otzivi);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            AddOtzivi form9 = new AddOtzivi();
            
            form9.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("УДАЛИТЬ ЗАПИСЬ???", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2); if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
