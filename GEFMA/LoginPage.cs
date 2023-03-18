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
        public LoginPage()
        {
            InitializeComponent();
        }
        private void LoginPage_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            if (File.Exists("loginInfo.bin"))
            {

           
                StreamReader sr = new StreamReader("loginInfo.bin");
                if (sr.ReadLine() == null)
                {
                    lblTitle.Text = "Register as an admin";
                    btnLogin.Text = "Register";
                }
                sr.Close();
            }
            else
            {
                StreamWriter w = new StreamWriter("loginInfo.bin");
                w.Close();
                lblTitle.Text = "Register as an admin";
                btnLogin.Text = "Register";
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(btnLogin.Text == "Register")
            {
                LoginInfo loginInfo = new LoginInfo(txtUsername.Text, txtPassword.Text, false);
                StreamWriter writer = new StreamWriter("loginInfo.bin");
                writer.WriteLine(string.Join("", loginInfo.Username));
                writer.WriteLine(string.Join("", loginInfo.Password));
                writer.Close();
            }
            else
            {
                StreamReader sr = new StreamReader("loginInfo.bin");
                string Username = sr.ReadLine();
                string Password = sr.ReadLine();
                LoginInfo login = new LoginInfo(Username, Password, true);
                if (login.CheckPasswordAndUsername(txtPassword.Text,txtUsername.Text))
                {
                    MessageBox.Show("Login successful!");
                   // implement edit page
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
            }
        }   
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
