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
using Business;
using Data;

namespace GEFMA
{
    /// <summary>
    /// Form that lets users see ordered items in their order list.
    /// </summary>
    public partial class OrderedListForm : Form
    {
        /// <summary>
        /// Fields used in the methods of the form.
        /// </summary>
        decimal TotalPrice = 0;
        float TotalETA = 0;
        int CurrentID = 0;
        List<Dish> OrderedDishes = new List<Dish>();
        public OrderBusiness OrderBusiness = new OrderBusiness();
        /// <summary>
        /// A constructor for the form which takes a List of OrderedItems as a parameter. It also loads the first dish of the list.
        /// </summary>
        /// <param name="OrderedItems"></param>
        public OrderedListForm(List<Dish> OrderedItems)
        {
            InitializeComponent();
            OrderedDishes = OrderedItems;
            foreach (Dish item in OrderedDishes)
            {
                TotalPrice += item.Price;
                TotalETA += item.EstimatedTimeToComplete;
            }
            if (OrderedItems.Count == 1)
            {
                btnNext.Visible = false;
                btnPrevious.Visible = false;
            }
            lblTotalPrice.Text = $"Total price: {TotalPrice:f2}";
            lblTotalETA.Text = $"Total ETA: {TotalETA:f2}";
            LoadDish(0);
            CurrentID = 0;
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
            Dish CurrentDish = OrderedDishes[id];
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
        /// Load event of the form. We maximize the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderedListForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
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
                CurrentID = OrderedDishes.Count - 1;
            }
            LoadDish(CurrentID);
        }
        /// <summary>
        /// A method that loads the next Dish. Called when a button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentID + 1 <= OrderedDishes.Count - 1)
            {
                CurrentID++;
            }
            else
            {
                CurrentID = 0;
            }
            LoadDish(CurrentID);
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
        /// A method which creates a OrderPlacedForm. Called when a button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            OrderBusiness.Add(new Data.Models.Order(OrderedDishes, TotalPrice, TotalETA));
            OrderPlacedForm OrderPlacedForm = new OrderPlacedForm(TotalETA, TotalPrice);
            OrderPlacedForm.Show();
            Hide();
        }
        /// <summary>
        /// A method that deletes the current item from the OrderedList. Called when a button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (OrderedDishes.Count == 1)
            {
                OrderForm OrderForm = new OrderForm();
                OrderForm.Show();
                Hide();
                return;
            }
            if (CurrentID < OrderedDishes.Count && CurrentID >= 0)
            {
                OrderedDishes.RemoveAt(CurrentID);
                CurrentID = 0;
                LoadDish(0);
                TotalPrice = 0;
                TotalETA = 0;
                foreach (Dish item in OrderedDishes)
                {
                    TotalPrice += item.Price;
                    TotalETA += item.EstimatedTimeToComplete;
                }
                lblTotalPrice.Text = $"Total price: {TotalPrice:f2}";
                lblTotalETA.Text = $"Total ETA: {TotalETA:f2}";
            }
        }
    }
}
