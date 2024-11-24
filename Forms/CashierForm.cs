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
using OOADPRO.Forms.CashierDisplayForm;

namespace OOADPRO.Forms
{
    public partial class CashierForm : Form
    {
        public CashierForm()
        {
            InitializeComponent();
            btnCashierProducts.Click += DoClickProducts;
            btnCustomer.Click += DoClickCustomer;
            btnOrder.Click += DoClickOrder;
                   }
        private void DoClickProducts(object? sender, EventArgs e)
        {
            AddControl(new CashierProductForm());
        }
        private void DoClickCustomer(object? sender, EventArgs e)
        {
            AddControl(new CashierCustomerForm());
        }
        private void DoClickOrder(object? sender, EventArgs e)
        {
            AddControl(new OrderForm());
        }
        public void AddControl(Form f)
        {
            panelcontrolMain.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            panelcontrolMain.Controls.Add(f);
            f.Show();
        }
        private void CashierForm_Load(object sender, EventArgs e)
        {
            AddControl(new CashierProductForm());
        }
    }
}
