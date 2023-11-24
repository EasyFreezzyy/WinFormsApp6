using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp6.Data;

namespace WinFormsApp6
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            using (var context = new DataContext())
            {
                // Проверяем, существует ли пользователь с таким именем
                var existingUser = context.User.FirstOrDefault(u => u.Username == username);
                if (existingUser != null)
                {
                    MessageBox.Show("Пользователь с таким именем уже существует!");
                    return;
                }

                // Создаем нового пользователя
                var newUser = new User
                {
                    Username = username,
                    Password = password,
                    IsAdmin = false
                };

                // Добавляем пользователя в базу данных
                context.User.Add(newUser);
                context.SaveChanges();

                MessageBox.Show("Вы успешно зарегистрированы!");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
