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
    public partial class OrderedListForm : Form
    {
        decimal TotalPrice = 0;
        float TotalETA = 0;
        int CurrentID = 0;
        List<Dish> OrderedDishes = new List<Dish>();
        public OrderBusiness OrderBusiness = new OrderBusiness();
        public OrderedListForm(List<Dish> OrderedItems)
        {
            InitializeComponent();
            OrderedDishes = OrderedItems;
            foreach (Dish item in OrderedDishes)
            {
                TotalPrice += item.Price;
                TotalETA += item.EstimatedTimeToComplete;
            }
            lblTotalPrice.Text = $"Total price: {TotalPrice:f2}";
            lblTotalETA.Text = $"Total ETA: {TotalETA:f2}";
            LoadDish(0);
            CurrentID = 0;
        }
        public byte[] ConvertImageToByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
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
        private void OrderedListForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
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
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            OrderBusiness.Add(new Data.Models.Order(OrderedDishes, TotalPrice, TotalETA));
            OrderPlacedForm OrderPlacedForm = new OrderPlacedForm(TotalETA, TotalPrice);
            OrderPlacedForm.Show();
            Hide();
        }
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
