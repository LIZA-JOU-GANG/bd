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
    public partial class Registration : Form
    {
        Class1 dataBase = new Class1();
        public Registration()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBox2.Text;
            var password = textBox4.Text;
            var telephone = textBox5.Text;
            string querystring = $"insert into [client](FIO, Password, [contact information]) values('{name}','{password}','{telephone}')";
            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());
            dataBase.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!");
                Vrarization frm = new Vrarization(); this.Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }
            dataBase.closeConnection();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu form1= new Menu();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
