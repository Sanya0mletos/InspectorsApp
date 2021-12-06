using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InspectorsApp.Models;
using InspectorsApp.Forms;

namespace InspectorsApp.Forms
{
    public partial class LoginForm : Form
    {
        public static Users USER { get; set; }
        database db = new database();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            // проверяем, что в текстовые поля введены данные
            if (LoginBox.Text == "" || PasswordBox.Text == "")
            {
                MessageBox.Show("Нужно задать логин и пароль!");
                return;
            }
            Users usr = db.Users.Find(LoginBox.Text);
            if ((usr != null) && (usr.Password == PasswordBox.Text))
            {
                MainForm newform = new MainForm();
                newform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Введенные данные неверны");
                return;
            }
        }
    }
}
