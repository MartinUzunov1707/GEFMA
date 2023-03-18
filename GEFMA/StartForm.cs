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
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            TextBox tb = new TextBox();
            this.Controls.Add(tb);
            tb.KeyPress += new KeyPressEventHandler(KeyPressed);
        }
        private void KeyPressed(object sender, KeyPressEventArgs e)
        {         
            OrderForm orderForm = new OrderForm();
            this.Hide();
            orderForm.Show();                    
        }      
    }
}
