using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
