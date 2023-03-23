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
{/// <summary>
/// This form initializes upon successfully making an order.
/// </summary>
    public partial class OrderPlacedForm : Form
    {
        RestaurantBusiness RestaurantBusiness = new RestaurantBusiness();
        /// <summary>
        /// This constructor accepts the values for the estimated time to order and the order price and sets 
        /// the text of two labels to those values.
        /// </summary>
        /// <param name="OrderETA"></param>
        /// <param name="OrderPrice"></param>
        public OrderPlacedForm(float OrderETA, decimal OrderPrice)
        {
            InitializeComponent();
            lblTotalETA.Text = $"Total ETA: {OrderETA:f2}";
            lblTotalPrice.Text = $"Total price: {OrderPrice:f2}";
        }
        /// <summary>
        /// This function is being called upon initialization of the form and makes it full screen.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderPlacedForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
        /// <summary>
        /// This function is called when the KeyPress event activates.
        /// It checks if the restaurant database is not empty, and if so, visualizes all of its elements.
        /// If it is empty, it forwards you to the admin login page, where you can manipulate the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
