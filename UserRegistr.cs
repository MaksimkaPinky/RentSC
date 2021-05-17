using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentSC
{
    public partial class UserRegistr : Form
    {
        Model1 db = new Model1();
        public UserRegistr()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" ||
    textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Нужно задать все данные!");
                return;
            }
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Значения паролей не совпадают!");
                return;
            }
            if ((textBox4.Text != "Администратор") && (textBox4.Text != "Менеджер А")  && (textBox4.Text != "Менеджер С"))
            {
                MessageBox.Show("Задана неверная роль!");
                return;
            }

            Сотрудники usr = db.Сотрудники.Find(textBox1.Text);
            if (usr != null)
            {
                MessageBox.Show("Пользователь с таким логином уже есть!");
                return;
            }
            usr = new Сотрудники();
            usr.Логин = textBox2.Text;
            usr.Пароль = textBox3.Text;
            usr.Роль = textBox4.Text;
            usr.ФИО = textBox1.Text;
            usr.Пол = textBox5.Text;
            usr.Номер_телефона = textBox6.Text;
            db.Сотрудники.Add(usr);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Пользователь " + usr.Логин + "зарегистрирован!");
            Form1.FORMA.Show();
            this.Close();
            return;

        }
    }
}
