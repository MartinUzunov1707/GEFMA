using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Windows.Forms;

namespace GEFMA
{
    public partial class StartForm : Form
    {
        RestaurantBusiness restaurantBusiness = new RestaurantBusiness(); 
        public StartForm()
        {
            InitializeComponent();
        }
        private void StartForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;      
        }
        private void StartForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Dish firstDish = restaurantBusiness.GetAll().First();
            if(firstDish != null)
            {
                OrderForm orderForm = new OrderForm(firstDish);
                orderForm.Show();
                Hide();
            }
            else
            {
                LoginPage Login = new LoginPage();
                Login.Show();
                Hide();
            }
        }
    }
}
