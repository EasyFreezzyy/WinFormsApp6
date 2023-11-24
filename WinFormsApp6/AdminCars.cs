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
    public partial class AdminCars : Form
    {
        public AdminCars()
        {
            InitializeComponent();
            using DataContext dataContext = new DataContext();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(dataContext.cars.ToArray());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            car car = new car();
            car.Marka = textBox1.Text;
            car.CarName = textBox2.Text;
            car.Year = int.Parse(textBox3.Text);
            car.Price = decimal.Parse(textBox4.Text);


            using DataContext dataContext = new DataContext();
            dataContext.Update(car);
            dataContext.SaveChanges();
            MessageBox.Show("Вы ввели автомобиль");
            listBox1.Items.Clear();
            listBox1.Items.AddRange(dataContext.cars.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var car = listBox1.SelectedItem as car;
                using DataContext dataContext = new DataContext();
                dataContext.cars.Remove(car);
                dataContext.SaveChanges();
                listBox1.Items.Remove(car);
            }
            catch { MessageBox.Show("Ошибка"); }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Panel form = new Admin_Panel();
            form.Show();
            this.Hide();
        }
    }
}
