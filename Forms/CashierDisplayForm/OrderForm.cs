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

namespace OOADPRO.Forms.CashierDisplayForm
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            btnAddStaff.Click += DoClickAddOrderDetail;
        }

        private void DoClickAddOrderDetail(object? sender, EventArgs e)
        {
            new OrderDetailAddForm().Show();
        }
       
    }
}
