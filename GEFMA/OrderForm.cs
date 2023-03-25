using Business;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GEFMA
{
    /// <summary>
    /// Form that lets users order items from the database.
    /// </summary>
    public partial class OrderForm : Form
    {
        /// <summary>
        /// Fields used in the methods of the form.
        /// </summary>
        RestaurantBusiness RestaurantBusiness = new RestaurantBusiness();
        List<int> IDs = new List<int>();
        int CurrentID = 0;
        List<Dish> Ordered = new List<Dish>();
        /// <summary>
        /// Default constructor.
        /// </summary>
        public OrderForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// A method which converts an Image to a byte array.
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public byte[] ConvertImageToByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        /// <summary>
        /// A method which converts a byte array to an Image.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        /// <summary>
        /// A method that sets the controls to the appropriate Dish.
        /// </summary>
        /// <param name="id"></param>
        private void LoadDish(int id)
        {
            Dish CurrentDish = RestaurantBusiness.Get(id);
            lblName.Text = CurrentDish.Name;
            lblPrice.Text = $"Price: {CurrentDish.Price:f2}";
            lblDescription.Text = CurrentDish.Description;
            lblETA.Text = $"Estimated time to make: {CurrentDish.EstimatedTimeToComplete:f2}";
            picImage.Image = ConvertByteArrayToImage(CurrentDish.Image);
            chkIsVegan.Checked = CurrentDish.IsVegan;
            chkIsVegetarian.Checked = CurrentDish.IsVegetarian;
            chkIsGlutenFree.Checked = CurrentDish.IsGlutenFree;
            chkIsHalal.Checked = CurrentDish.IsHalal;
        }
        /// <summary>
        /// Load event of the form. We get and display the first Dish as well as maximize the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            LoadDish(RestaurantBusiness.GetAll().FirstOrDefault().ID);
            CurrentID = 0;
            if (RestaurantBusiness.GetAll().Count == 1)
            {
                btnNext.Visible = false;
                btnPrevious.Visible = false;
            }
            foreach (Dish item in RestaurantBusiness.GetAll())
            {
                IDs.Add(item.ID);
            }
        }
        /// <summary>
        /// A method that closes the window. Called when a button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// A method that creates a login form to edit the database and hides this form. Called when a button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }
        /// <summary>
        /// A method that loads the previous Dish. Called when a button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (CurrentID - 1 >= 0)
            {
                CurrentID--;
            }
            else
            {
                CurrentID = IDs.Count - 1;
            }
            LoadDish(IDs[CurrentID]);
        }
        /// <summary>
        /// A method that loads the next Dish. Called when a button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentID + 1 <= IDs.Count - 1)
            {
                CurrentID++;
            }
            else
            {
                CurrentID = 0;
            }
            LoadDish(IDs[CurrentID]);
        }
        /// <summary>
        /// A method that adds a Dish to the Order List. Called when a button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrder_Click(object sender, EventArgs e)
        {
            Ordered.Add(RestaurantBusiness.Get(IDs[CurrentID]));
            MessageBox.Show("Added to order!");
        }
        /// <summary>
        /// A method that creates an OrderListForm and hides the current form.Called when a button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            if (Ordered.Count == 0)
            {
                MessageBox.Show("Add items to your order!");
            }
            else
            {
                OrderedListForm OrderListForm = new OrderedListForm(Ordered);
                OrderListForm.Show();
                Hide();
            }
        }
    }
}
