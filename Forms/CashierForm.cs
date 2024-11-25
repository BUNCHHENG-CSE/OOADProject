using OOADPRO.Forms.CashierDisplayForm;
using OOADPRO.Models;

namespace OOADPRO.Forms
{
    public partial class CashierForm : Form
    {
        public CashierForm(User user)
        {
            InitializeComponent();
            btnCashierProducts.Click += DoClickProducts;
            btnOrder.Click += DoClickOrder;
            //LabelUser.Text += " "+user.Username.ToUpper();
        }
        private void DoClickProducts(object? sender, EventArgs e)
        {
            AddControl(new CashierProductForm());
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
