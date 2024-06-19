using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd
{
    public partial class Vrarization : Form
    {
        Class1 dataBase = new Class1();
        public Vrarization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var logintUser = textBox2.Text; 
            var passUser = textBox3.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select [ID client], FIO, Password from [Client] where FIO = '{logintUser}' and Password = '{passUser}'";
            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Arenda frm1 = new Arenda();
                this.Hide(); frm1.ShowDialog();
            }
            else
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu form1 = new Menu();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void Vrarization_Load(object sender, EventArgs e)
        {

        }
    }
}
