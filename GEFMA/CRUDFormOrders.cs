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
    /// <summary>
    /// Form that lets admins edit the database.
    /// </summary>
    public partial class CRUDFormOrders : Form
    {
        /// <summary>
        /// Fields used in the methods of the form.
        /// </summary>
        public OrderBusiness OrderBusiness = new OrderBusiness();
        public RestaurantBusiness RestaurantBusiness= new RestaurantBusiness();
        /// <summary>
        /// Default constructor.
        /// </summary>
        public CRUDFormOrders()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load event of the form. We maximize the window and update the grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRUDFormOrders_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            UpdateGrid();
        }
        /// <summary>
        /// Method that updates the DataGridView.
        /// </summary>
        private void UpdateGrid()
        {
            dgvItems.DataSource = OrderBusiness.GetAll();
            dgvItems.ReadOnly = true;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        /// <summary>
        /// Method that Resets DataGridView selection.
        /// </summary>
        private void ResetSelect()
        {
            dgvItems.ClearSelection();
            dgvItems.Enabled = true;
        }
        /// <summary>
        /// A method that deletes the current item from the database. Called when a button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// A method that marks the current item as InProgress. Called when a button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMarkAsInProgress_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                var item = dgvItems.SelectedRows[0].Cells;
                int id = int.Parse(item[0].Value.ToString());
                Order ordered = OrderBusiness.Get(id);
                ordered.OrderState = Order.OrderStates.InProgress;
                OrderBusiness.Update(ordered);
                UpdateGrid();
                ResetSelect();
            }
        }
        /// <summary>
        /// A method that marks the current item as Completed. Called when a button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMarkAsCompleted_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                var item = dgvItems.SelectedRows[0].Cells;
                int id = int.Parse(item[0].Value.ToString());
                Order ordered = OrderBusiness.Get(id);
                ordered.OrderState = Order.OrderStates.Completed;
                OrderBusiness.Update(ordered);
                UpdateGrid();
                ResetSelect();
            }
        }
        /// <summary>
        /// A method that closes the window. Called when a button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// A method that makes an OrderForm object and hides the current form. Called when a button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// A method that makes a CrudForm object and hides the current form. Called when a button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGoToDishes_Click(object sender, EventArgs e)
        {
            CRUDForm Form= new CRUDForm();
            Form.Show();
            Hide();
        }
        /// <summary>
        /// A method that deletes all completed orders. Called when a button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
