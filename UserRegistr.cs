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
    textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Нужно задать все данные!");
                return;
            }
            if (textBox3.Text != textBox7.Text)
            {
                MessageBox.Show("Значения паролей не совпадают!");
                return;
            }
            if ((textBox4.Text != "Администратор") && (textBox4.Text != "Менеджер А")  && (textBox4.Text != "Менеджер С"))
            {
                MessageBox.Show("Задана неверная роль!");
                return;
            }
            foreach (Сотрудники usr in db.Сотрудники)
            {
                //Сотрудники usr = db.Сотрудники.Find(textBox2.Text);
                //if (usr != null)
                //{
                //    MessageBox.Show("Пользователь с таким логином уже есть!");
                //    return;
                //}
                //usr = new Сотрудники();
                usr.Логин = textBox2.Text;
                usr.Пароль = textBox3.Text;
                usr.Роль = textBox4.Text;
                usr.ФИО = textBox1.Text;
                usr.Пол = comboBox1.Text;
                usr.Номер_телефона = textBox6.Text;
                ImageConverter conv = new ImageConverter();
                byte[] bImg = (byte[])conv.ConvertTo(pictureBox1.Image, typeof(byte[]));
                usr.Фото = bImg;
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
            db.SaveChanges();
        }

        private void UserRegistr_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выберите фото сотрудника";
            ofd.InitialDirectory = @"C:\Users\315\Desktop\10 - Аренда ТЦ (задание квал отбор 2019)\Ресурсы\Image Сотрудники";
            ofd.Filter = "Файлы JPG, GIF, PNG|*.jpg;*.gif;*.png|Все файлы (*.*)|*.*";
            DialogResult rc = ofd.ShowDialog();
            if (rc == DialogResult.OK)
            {

                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }

        }
    }
}
