using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private void OrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
