using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

namespace GEFMA
{
    public partial class LoginPage : Form
    {
        
        private string debugUsername = "Murata123";
        private string debugPassword = "123456789";
        public LoginPage()
        {
            InitializeComponent();
        }
        private void LoginPage_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            try
            {
                StreamReader sr = new StreamReader("loginInfo.txt");
                if (sr.ReadLine() == null)
                {
                    lblTitle.Text = "Register as an admin";
                    btnLogin.Text = "Register";
                }
                sr.Close();
            }
            catch
            {
                StreamWriter r = new StreamWriter("loginInfo.txt");
                r.Close();
                lblTitle.Text = "Register as an admin";
                btnLogin.Text = "Register";
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(btnLogin.Text == "Register")
            {
                LoginInfo loginInfo = new LoginInfo(txtUsername.Text, txtPassword.Text, false);
                StreamWriter writer = new StreamWriter("loginInfo.txt");
                writer.WriteLine(loginInfo.Username);
                writer.WriteLine(loginInfo.Password);
                writer.Close();
            }
            else
            {
                StreamReader sr = new StreamReader("loginInfo.txt");
                string Username = sr.ReadLine();
                string Password = sr.ReadLine();
                LoginInfo login = new LoginInfo(Username, Password, true);
                if (login.CheckPasswordAndUsername(txtPassword.Text,txtUsername.Text))
                {
                   // implement edit page
                }
            }


        }
    }
}
