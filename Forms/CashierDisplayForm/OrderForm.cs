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
            //dataGridView1.CellClick += Select_Handling_Order;
            //LoadingDataOrder();
        }

        private void DoClickAddOrderDetail(object? sender, EventArgs e)
        {
            new OrderDetailAddForm().Show();
        }

        //private void Select_Handling_Order(object? sender, EventArgs e)
        //{
        //    if (dataGridView1.CurrentRow == null) return;
        //    int no = (int)dataGridView1.CurrentRow.Cells["CategoryID"].Value;
        //    try
        //    {
        //        effectedOrder = OrderFunc.GetOneOrder(Program.Connection, no);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Here: {ex.Message}");
        //    }
        //}
        //private void OrderForm_load(object? sender, EventArgs e) {
        //    LoadingDataOrder();
        // }

        //private void LoadingDataOrder()
        //{
        //    try
        //    {
        //        var result = OrderFunc.GetAllOrder(Program.Connection);

        //        dataGridView1.Rows.Clear();
        //        foreach (var order in result)
        //        {
        //            dataGridView1.Rows.Add(order.OrderID, order.DateOrder, order.TotalPrice,order.Customer.CustomerID);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Retriving Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

    }
}
