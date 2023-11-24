using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text;
            string password = textBox2.Text;

            try
            {
                using (var context = new DataContext())
                {
                    var users = context.User.Where(u => u.Username == username && u.Password == password);

                    if (users.Any())
                    {
                        var user = users.First(); // Получаем первого пользователя, так как мы уверены, что он существует
                        if (user.IsAdmin)
                        {
                            this.Hide();
                            Admin_Panel admin_Panel = new Admin_Panel();
                            admin_Panel.Show();
                            MessageBox.Show("Вы вошли как администратор");
                            // Добавьте код для перехода на интерфейс администратора
                        }
                        else
                        {
                            this.Hide();
                            User_Panel User_Panel = new User_Panel(user);
                            User_Panel.Show();
                 
                            MessageBox.Show("Вы вошли как обычный пользователь");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неправильный логин или пароль");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка входа: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            registration registration = new registration();
            registration.Show();
        }
    }
}


