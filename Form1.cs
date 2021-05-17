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
    public partial class Form1 : Form
    {
        public static Form1 FORMA { get; set; }
        public static Сотрудники USER { get; set; }
        Model1 db = new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            foreach (Сотрудники usr in db.Сотрудники)
                {
                if ((usr != null) && (usr.Пароль == textBox2.Text))
                {
                    USER = usr;
                    if (usr.Роль == "Администратор")
                    {
                        Admin frm = new Admin();
                        frm.Show();
                        this.Hide();
                    }
                    else if (usr.Роль == "Менеджер С")
                    {
                        Manager frm = new Manager();
                        frm.Show();
                        this.Hide();
                    }
                    else if (usr.Роль == "Менеджер А")
                    {
                        ManagerA frm = new ManagerA();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show($"Роли {usr.Роль} в системе нет!");
                        return;
                    }
                }

            }
        }
        
    }
}
