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
    public partial class Kvartiri : Form
    {
        public Kvartiri()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void список_доступных_квартир__по_городам__Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agenstvo_nedvijemostiDataSet5.the_real_estate_object". При необходимости она может быть перемещена или удалена.
            this.the_real_estate_objectTableAdapter.Fill(this.agenstvo_nedvijemostiDataSet5.the_real_estate_object);

        }
    }
}
