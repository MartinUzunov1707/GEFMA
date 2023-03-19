using Business;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GEFMA
{
    public partial class OrderPlacedForm : Form
    {
        RestaurantBusiness RestaurantBusiness = new RestaurantBusiness();
        public OrderPlacedForm(float OrderETA, decimal OrderPrice)
        {
            InitializeComponent();
            lblTotalETA.Text = $"Total ETA: {OrderETA:f2}";
            lblTotalPrice.Text = $"Total price: {OrderPrice:f2}";
        }
        private void OrderPlacedForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
        private void OrderPlacedForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Dish firstDish = RestaurantBusiness.GetAll().FirstOrDefault();
            if (firstDish != null)
            {
                OrderForm orderForm = new OrderForm();
                orderForm.Show();
                Hide();
            }
            else
            {
                LoginForm Login = new LoginForm();
                Login.Show();
                Hide();
            }
        }
    }
}
