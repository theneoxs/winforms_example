using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork16
{
    public partial class Delete : Form
    {
        public Delete(DataGridViewColumn dataGridViewColumn)
        {
            InitializeComponent();
            List<string> pas = new List<string>();
            for (int i = 0; i < dataGridViewColumn.DataGridView.RowCount - 1; i++)
            {
                pas.Add(dataGridViewColumn.DataGridView[0, i].Value.ToString());
            }

            comboBox1.DataSource = pas;
        }

        private void deleteButtom_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = MainForm.ConnectToDb();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = $"delete from pet where id={comboBox1.Text}";
            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }
    }
}
