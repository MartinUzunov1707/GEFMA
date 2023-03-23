using Business;
using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GEFMA
{
    public partial class CRUDFormOrders : Form
    {
        public OrderBusiness OrderBusiness = new OrderBusiness();
        public RestaurantBusiness RestaurantBusiness= new RestaurantBusiness();
        public CRUDFormOrders()
        {
            InitializeComponent();
        }
        private void CRUDFormOrders_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            dgvItems.DataSource = OrderBusiness.GetAll();
            dgvItems.ReadOnly = true;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void ResetSelect()
        {
            dgvItems.ClearSelection();
            dgvItems.Enabled = true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                var item = dgvItems.SelectedRows[0].Cells;
                int id = int.Parse(item[0].Value.ToString());
                OrderBusiness.Delete(id);
                UpdateGrid();
                ResetSelect();
            }
        }
        private void btnMarkAsInProgress_Click(object sender, EventArgs e)
        {
            var item = dgvItems.SelectedRows[0].Cells;
            int id = int.Parse(item[0].Value.ToString());
            Order ordered = OrderBusiness.Get(id);
            ordered.OrderState = Order.OrderStates.InProgress;
            OrderBusiness.Update(ordered);
            UpdateGrid();
            ResetSelect();
        }
        private void btnMarkAsCompleted_Click(object sender, EventArgs e)
        {
            var item = dgvItems.SelectedRows[0].Cells;
            int id = int.Parse(item[0].Value.ToString());
            Order ordered = OrderBusiness.Get(id);
            ordered.OrderState = Order.OrderStates.Completed;
            OrderBusiness.Update(ordered);
            UpdateGrid();
            ResetSelect();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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
        private void btnGoToDishes_Click(object sender, EventArgs e)
        {
            CRUDForm Form= new CRUDForm();
            Form.Show();
            Hide();
        }
        private void btnDeleteCompleted_Click(object sender, EventArgs e)
        {
            List<Order> Orders = OrderBusiness.GetAll();
            foreach (Order item in Orders)
            {
                if (item.OrderState == Order.OrderStates.Completed)
                {
                    OrderBusiness.Delete(item.ID);
                }
            }
            UpdateGrid();
            ResetSelect();
        }
    }
}
