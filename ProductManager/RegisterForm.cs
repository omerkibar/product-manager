using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        UserDal userDal = new UserDal();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbxRegisterPassword.Text!=""&&tbxRegisterPassword.Text==tbxRegisterCPassword.Text && tbxRegisterUsername.Text!="")
            {
                if (rbtnMySQL.Checked)
                {
                    userDal.Register(new User
                    {
                        Username = tbxRegisterUsername.Text,
                        Password = tbxRegisterPassword.Text,
                        DatabaseType = "MySQL"
                        
                    });
                    this.Close();
                    
                }
                else if (rbtnMSSQL.Checked)
                {
                    userDal.Register(new User
                    {
                        Username = tbxRegisterUsername.Text,
                        Password = tbxRegisterPassword.Text,
                        DatabaseType = "MSSQL"
                    });
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please choose database type for your new account!");
                }
            }
            else
            {
                MessageBox.Show("Make sure your password and confirm password same and both Username and Password isn't empty!");
            }          
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
