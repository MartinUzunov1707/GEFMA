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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        private void StartForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TextBox tb = new TextBox();
            Controls.Add(tb);
            tb.KeyPress += new KeyPressEventHandler(KeyPressed);
        }
        private void KeyPressed(object sender, KeyPressEventArgs e)
        {         
            OrderForm orderForm = new OrderForm();
            Hide();
            orderForm.Show();                    
        }      
    }
}
