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
    public partial class Authorization : Form
    {
        //Экспресс-сообщение
        DialogResult result;
        //найден ли аккаунт в системе
        bool findAcc;
        /// <summary>
        /// Конструктор авторизации
        /// </summary>
        public Authorization()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Кнопка входа в систему
        /// </summary>
        /// <param name="sender">Объект</param>
        /// <param name="e">Эвент</param>
        private void auth_Click(object sender, EventArgs e)
        {
            //Коннект к бд
            MySqlConnection connection = MainForm.ConnectToDb();
            //создание команды и запись в неё непосредственно команды и бд в которой требуется её выполнить
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = $"select * from users where login = '{logBox.Text}' and password = '{passBox.Text}'";
            connection.Open();
            //проверка наличия данного логина и пароля
            findAcc = command.ExecuteReader().HasRows;
            connection.Close();
            //если акк надейден - открыть основную форму и спрятать эту
            if (findAcc)
            {
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.Show();
                //триггер на закрытие основного файла для закрытия программы
                mainForm.FormClosed += Close;
            }
            else
            {
                //иначе если не найден - показать это
                result = MessageBox.Show("Ошибка логин/пароль. Попобуйте ещё раз.", "Ошибка входа!", MessageBoxButtons.OK);
            }
        }
        /// <summary>
        /// Кнопка регистрации
        /// </summary>
        /// <param name="sender">Объект</param>
        /// <param name="e">Эвент</param>
        private void registration_Click(object sender, EventArgs e)
        {
            //спрятать окно авторизации
            this.Hide();
            //открыть окно регистрации
            Registration reg = new Registration();
            reg.Show();
            //триггер на закрытие формы регистрации
            reg.FormClosed += delegate { this.Show(); };
        }
        /// <summary>
        /// Метод для триггера на закрытие окна
        /// </summary>
        /// <param name="sender">Объект</param>
        /// <param name="e">Эвент</param>
        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
