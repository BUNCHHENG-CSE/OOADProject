using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOADPRO.Forms.AdminDisplayForm;
using OOADPRO.Models;
using OOADPRO.Utilities;

namespace OOADPRO.Forms.CashierDisplayForm
{
    public partial class OrderForm : Form
    {
        Order? effectedOrder = null;
       
        public OrderForm()
        {
            InitializeComponent();
            btnAddStaff.Click += DoClickAddOrderDetail;
            dgvOrder.CellClick += Select_Handling_Order;
        }

        private void Select_Handling_Order(object? sender, EventArgs e)
        {
            if (dgvOrder.CurrentRow == null) return;
            int no = (int)dgvOrder.CurrentRow.Cells["CategoryID"].Value;
            try
            {
                Order? effectedOrder =OrderFunc.GetOneOrder(Program.Connection, no);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Here: {ex.Message}");
            }
        }

        private void DoClickAddOrderDetail(object? sender, EventArgs e)
        {
            new OrderDetailAddForm().Show();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
