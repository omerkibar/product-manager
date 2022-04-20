using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        UserDal userDal = new UserDal();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string database = userDal.Login(new User
            {
                Username = tbxUsername.Text,
                Password = tbxPassword.Text
            });
            if (database=="MySQL")
            {
                Form1 form1 = new Form1(database);
                Hide();
                form1.ShowDialog();
                Close();
            }
            else if (database == "MSSQL")
            {
                Form1 form1 = new Form1(database);
                Hide();
                form1.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!!!");
            }
        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            Hide();
            registerForm.ShowDialog();
            ShowDialog();
        }
    }
}
