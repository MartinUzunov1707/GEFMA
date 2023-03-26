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
    /// <summary>
    /// This form is being initialized when the user wants to edit the databases.
    /// </summary>
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Upon initialization, the form checks if the admin has registered.
        /// If the admin has not registered, the program creates a bin file with their credentials and changes 
        /// the labels to "register" instead of "login".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                lblTitle.Text = "Register as an admin";
                btnLogin.Text = "Register";
            }
        }
        /// <summary>
        /// This function checks if the form is in register mode or in login mode.
        /// If the user has not registered, their inputs will be encrypted and saved in a bin file, and they
        /// will be redirected to the admin form.
        /// If the user has registered before, the program checks if the input credentials match with those in
        /// the bin file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(btnLogin.Text == "Register")
            {
                if (txtUsername.Text.Length != 0 && txtPassword.Text.Length != 0)
                {

                    LoginInfo loginInfo = new LoginInfo(txtUsername.Text, txtPassword.Text, false);
                    StreamWriter writer = new StreamWriter("loginInfo.bin");
                    writer.WriteLine(string.Join("", loginInfo.Username));
                    writer.WriteLine(string.Join("", loginInfo.Password));
                    writer.Close();
                    MessageBox.Show("Register successful!");
                    CRUDForm AdminForm = new CRUDForm();
                    AdminForm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("The login credentials cannot be empty!");
                }
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
                    CRUDForm AdminForm = new CRUDForm();
                    AdminForm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
            }
        }   
        /// <summary>
        /// Upon pressing the quit button the program closes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
