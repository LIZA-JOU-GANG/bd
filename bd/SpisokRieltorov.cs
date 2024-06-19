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
    public partial class Rieltori : Form
    {
        public Rieltori()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void список_доступных_риелторов_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agenstvo_nedvijemostiDataSet8.realtor". При необходимости она может быть перемещена или удалена.
            this.realtorTableAdapter.Fill(this.agenstvo_nedvijemostiDataSet8.realtor);

        }
    }
}
