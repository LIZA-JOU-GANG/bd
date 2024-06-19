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
    public partial class AddContract : Form
    {
        public AddContract()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void DNKontractov_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpisokKontractov main = this.Owner as SpisokKontractov;
            if (main != null)
            {
                DataRow nRow = main.agenstvo_nedvijemostiDataSet6.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[2] = textBox1.Text;
                nRow[3] = textBox2.Text;
                nRow[1] = textBox3.Text;
                main.agenstvo_nedvijemostiDataSet6.Tables[0].Rows.Add(nRow);
                main.contractTableAdapter.Update(main.agenstvo_nedvijemostiDataSet6.Contract);
                main.agenstvo_nedvijemostiDataSet6.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }
    }
}
