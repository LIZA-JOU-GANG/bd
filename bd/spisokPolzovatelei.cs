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
    public partial class Polzovat : Form
    {
        public Polzovat()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void список_пользователей_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agenstvo_nedvijemostiDataSet7.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.agenstvo_nedvijemostiDataSet7.client);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
