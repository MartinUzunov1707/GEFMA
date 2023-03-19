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
    public partial class OrderForm : Form
    {
        RestaurantBusiness RestaurantBusiness = new RestaurantBusiness();
        List<int> IDs = new List<int>();
        int CurrentID = 0;
        List<Dish> Ordered = new List<Dish>();
        public OrderForm()
        {
            InitializeComponent();
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
        private void OrderForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            LoadDish(RestaurantBusiness.GetAll().FirstOrDefault().ID);
            CurrentID = 0;
            foreach (Dish item in RestaurantBusiness.GetAll())
            {
                IDs.Add(item.ID);
            }
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
        private void btnOrder_Click(object sender, EventArgs e)
        {
            Ordered.Add(RestaurantBusiness.Get(IDs[CurrentID]));
            MessageBox.Show("Added to order!");
        }
        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            OrderedListForm OrderListForm = new OrderedListForm(Ordered);
            OrderListForm.Show();
            Hide();
        }
    }
}
