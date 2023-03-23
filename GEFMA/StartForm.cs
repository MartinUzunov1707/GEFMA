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
    /// <summary>
    /// This is the form that is being initialized upon starting of the program. 
    /// </summary>
    public partial class StartForm : Form
    {
        RestaurantBusiness RestaurantBusiness = new RestaurantBusiness();
        public StartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function puts the form in "fullscreen" mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;      
        }
        /// <summary>
        /// This function is called upon the StartForm_KeyPress event. 
        /// It checks if the database is empty, and if so, it loads up the login page, from which the user can 
        /// fill the database, if they have the admin credentials.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Dish firstDish = RestaurantBusiness.GetAll().FirstOrDefault();
            if(firstDish != null)
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
