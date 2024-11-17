using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOADPRO.Forms.AdminDisplayForm
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            btnAddProduct.Click += DoClickAddProducts;
        }

        private void DoClickAddProducts(object? sender, EventArgs e)
        {
           new ProductsAddForm().Show();
        }
    }
}
