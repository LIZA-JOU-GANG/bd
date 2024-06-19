using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bd
{
    public partial class AddOtzivi : Form
    {
        Class1 dataBase = new Class1();
        public AddOtzivi()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 main = this.Owner as Form10; if (main != null)
            {
                DataRow nRow = main.agenstvo_nedvijemostiDataSet4.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1; nRow[0] = rc;
                nRow[2] = textBox2.Text; 
                nRow[1] = textBox1.Text;
                // Получаем выбранное значение из группы радио-кнопок
                int selectedRating = 0; if (radioButton1.Checked) selectedRating = 1;
                else if (radioButton2.Checked) selectedRating = 2;
                else if (radioButton3.Checked) selectedRating = 3;
                else if (radioButton4.Checked) selectedRating = 4; else if (radioButton5.Checked) selectedRating = 5;
                nRow[3] = selectedRating; // Добавляем выбранную оценку
                main.agenstvo_nedvijemostiDataSet4.Tables[0].Rows.Add(nRow);
                main.otziviTableAdapter3.Update(main.agenstvo_nedvijemostiDataSet4.Otzivi); main.agenstvo_nedvijemostiDataSet4.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh(); textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddOtzivi_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
