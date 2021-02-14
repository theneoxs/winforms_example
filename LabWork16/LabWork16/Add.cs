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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод добавления данных в базу
        /// </summary>
        /// <param name="sender">Объект</param>
        /// <param name="e">Эвент</param>
        private void addButton_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = MainForm.ConnectToDb();
            MySqlCommand command = new MySqlCommand();
            //Проверка на корректность введенных данных
            try
            {
                //проверка на пустую строку
                if (nameTextBox.Text == "" || breedTextBox.Text == "" || ageTextBox.Text == "")
                {
                    throw new ConstraintException();
                }
                //проверка на число
                Convert.ToInt32(ageTextBox.Text);
                command.CommandText = $"insert into pet (name, breed, age) values ('{nameTextBox.Text}', '{breedTextBox.Text}', '{ageTextBox.Text}')";
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }
            catch (ConstraintException)
            {
                //если строка пустая - вывести предупреждение
                DialogResult error = MessageBox.Show("Вы оставили строку пустой", "Ошибка строки", MessageBoxButtons.OK);
            }
            catch
            {
                //если введено не число - вывести предупреждение
                DialogResult error = MessageBox.Show("Вы ввели некорректный возраст", "Ошибка числа", MessageBoxButtons.OK);
            }
            
            
        }
    }
}
