using Microsoft.EntityFrameworkCore;
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
    public partial class User_Panel : Form
    {
        User User { get; set; }
        public User_Panel(User user)
        {
            InitializeComponent();
            this.User = user;
            using DataContext dataContext = new DataContext();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(dataContext.cars.ToArray());
            listBox2.Items.Clear();
            listBox2.Items.AddRange(dataContext.corzinas.Include(i => i.car).Where(i => i.UserId == User.Id).Select(i => i.car).ToArray());



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using DataContext datacontext = new DataContext();
                car car = listBox1.SelectedItem as car;

                Corzina corzina = new Corzina();
                corzina.CarId = car.Id;
                corzina.UserId = User.Id;

                if (!datacontext.corzinas.Any(i => i.UserId == corzina.UserId && i.CarId == corzina.CarId))
                {
                    datacontext.Update(corzina);
                    datacontext.SaveChanges();
                }

                listBox2.Items.Clear();
                listBox2.Items.AddRange(datacontext.corzinas.Include(i => i.car).Where(i => i.UserId == User.Id).Select(i => i.car).ToArray());
            }
            catch
            {
                MessageBox.Show("error");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using DataContext datacontext = new DataContext();
                if (listBox2.SelectedIndex != -1)
                {
                    car car = listBox2.SelectedItem as car;

                    Corzina corzina = datacontext.corzinas.Where(i => i.UserId == User.Id && i.CarId == car.Id).First();

                    datacontext.corzinas.Remove(corzina);
                    datacontext.SaveChanges();

                    listBox2.Items.Clear();
                    listBox2.Items.AddRange(datacontext.corzinas.Include(i => i.car).Where(i => i.UserId == User.Id).Select(i => i.car).ToArray());
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
