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
    public partial class CRUDForm : Form
    {
        public RestaurantBusiness RestaurantBusiness = new RestaurantBusiness();
        Image Image;
        private int EditId = 0;
        public CRUDForm()
        {
            InitializeComponent();
        }
        private void CRUDForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            UpdateGrid();
            ClearAllControls();
        }
        public byte[] ConvertImageToByte(Image img)
        {
            using (MemoryStream MemoryStream = new MemoryStream())
            {
                img.Save(MemoryStream, System.Drawing.Imaging.ImageFormat.Png);
                return MemoryStream.ToArray();
            }
        }
        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream MemoryStream = new MemoryStream(data))
            {
                return Image.FromStream(MemoryStream);
            }
        }
        private void UpdateGrid()
        {
            dgvItems.DataSource = RestaurantBusiness.GetAll();
            dgvItems.ReadOnly = true;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void ClearAllControls()
        {
            txtName.Text = "";
            txtPrice.Text = "";
            txtDescription.Text = "";
            txtETA.Text = "";
            chkIsGlutenFree.Checked = false;
            chkIsHalal.Checked = false;
            chkIsVegan.Checked = false;
            chkIsVegetarian.Checked = false;
            picImage.Image = null;
        }
        private Dish GetDish()
        {
            string Name = txtName.Text;
            decimal Price = 0;
            decimal.TryParse(txtPrice.Text, out Price);
            float ETA = 0;
            float.TryParse(txtETA.Text, out ETA);
            string Description = txtDescription.Text;
            byte[] Arr;
            if (Image == null)
            {
                throw new ArgumentException("Image field is not valid!");
            }
            else
            {
                Arr = ConvertImageToByte(Image);
            }
            bool isVegetarian = chkIsVegetarian.Checked;
            bool isVegan = chkIsVegan.Checked;
            bool isGluten = chkIsGlutenFree.Checked;
            bool isHalal = chkIsHalal.Checked;
            Dish Dish = new Dish(Name, Price, Description, Arr, isVegetarian, isVegan, isGluten, isHalal, ETA);
            Image = null;
            return Dish;
        }
        private Dish GetEditedDish()
        {
            string Name = txtName.Text;
            decimal Price = 0;
            decimal.TryParse(txtPrice.Text, out Price);
            float ETA = 0;
            float.TryParse(txtETA.Text, out ETA);
            string Description = txtDescription.Text;
            byte[] Arr;
            if (Image == null)
            {
                throw new ArgumentException("Image field is not valid!");
            }
            else
            {
                Arr = ConvertImageToByte(Image);
            }
            bool isVegetarian = chkIsVegetarian.Checked;
            bool isVegan = chkIsVegan.Checked;
            bool isGluten = chkIsGlutenFree.Checked;
            bool isHalal = chkIsHalal.Checked;
            Dish Dish = new Dish(Name, Price, Description, Arr, isVegetarian, isVegan, isGluten, isHalal, ETA);
            Dish.ID = EditId;
            Image = null;
            return Dish;
        }
        private void UpdateControls(int id)
        {
            Dish Dish = RestaurantBusiness.Get(id);
            txtName.Text = Dish.Name;
            txtPrice.Text = Math.Round(Dish.Price, 2).ToString();
            txtDescription.Text = Dish.Description;
            txtETA.Text = Math.Round(Dish.EstimatedTimeToComplete, 2).ToString();
            picImage.Image = ConvertByteArrayToImage(Dish.Image);
            Image = ConvertByteArrayToImage(Dish.Image);
            chkIsVegan.Checked = Dish.IsVegan;
            chkIsVegetarian.Checked = Dish.IsVegetarian;
            chkIsGlutenFree.Checked = Dish.IsGlutenFree;
            chkIsHalal.Checked = Dish.IsHalal;
        }
        private void ToggleSaveUdpate()
        {
            if (btnUpdate.Visible)
            {
                btnUpdate.Visible = false;
                btnSave.Visible = true;
                btnInsert.Visible = false;
                btnDelete.Visible = false;
            }
            else
            {
                btnUpdate.Visible = true;
                btnSave.Visible = false;
                btnInsert.Visible = true;
                btnDelete.Visible = true;
            }
        }
        private void DisableSelect()
        {
            dgvItems.Enabled = false;
        }
        private void ResetSelect()
        {
            dgvItems.ClearSelection();
            dgvItems.Enabled = true;
        }
        private void btnImageUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files (*.png;*.jpg)|*.png;*.jpg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Image = Image.FromFile(ofd.FileName);
                    picImage.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            if(Image != null)
            {
                RestaurantBusiness.Add(GetDish());
                UpdateGrid();
                ClearAllControls();
            }
            else 
            {
               MessageBox.Show("Invalid entry parameters!");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Dish editedDish = GetEditedDish();
            RestaurantBusiness.Update(editedDish);
            UpdateGrid();
            ResetSelect();
            ToggleSaveUdpate();
            ClearAllControls();
        }
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                var item = dgvItems.SelectedRows[0].Cells;
                int id = int.Parse(item[0].Value.ToString());
                EditId = id;
                UpdateControls(id);
                ToggleSaveUdpate();
                DisableSelect();
            }
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                var item = dgvItems.SelectedRows[0].Cells;
                int id = int.Parse(item[0].Value.ToString());
                RestaurantBusiness.Delete(id);
                UpdateGrid();
                ClearAllControls();
                ResetSelect();
            }
        }
        private void btnBackToDishes_Click(object sender, EventArgs e)
        {
            Dish FirstDish = RestaurantBusiness.GetAll().FirstOrDefault();
            if (FirstDish != null)
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            CRUDFormOrders formOrders = new CRUDFormOrders();
            formOrders.Show();
            Hide();
        }
    }
}
