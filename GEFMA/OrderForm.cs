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
        public Dish currentDish;
        public OrderForm(Dish dish)
        {
            InitializeComponent();
            currentDish = dish;
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
        private void OrderForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            lblName.Text = currentDish.Name;
            lblPrice.Text = $"{currentDish.Price:2f}";
            lblDescription.Text = currentDish.Description;
            pictureBox.Image = ConvertByteArrayToImage(currentDish.Image);
            chkIsVegan.Checked = currentDish.IsVegan;
            chkIsVegetarian.Checked = currentDish.IsVegetarian;
            chkIsGlutenFree.Checked = currentDish.IsGlutenFree;
            chkIsHalal.Checked = currentDish.IsHalal;
        }   
    }
}
