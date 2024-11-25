using OOADPRO.Models;
using OOADPRO.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOADPRO.Forms.CashierDisplayForm
{
    public partial class CashierProductForm : Form
    {
        int productCount = 0;

        public CashierProductForm()
        {
            InitializeComponent();
            LoadingDataProducts();

        }
        private void LoadingDataProducts()
        {
            try
            {

                var result = ProductFunc.GetAllProducts(Program.Connection);

                foreach (var product in result)
                {

                    Panel productPanel = new Panel
                    {
                        Width = 185,
                        Height = 270,
                        BorderStyle = BorderStyle.FixedSingle,
                        Padding = new Padding(20)
                    };

                    PictureBox pictureBox = new PictureBox
                    {
                        Width = 180,
                        Height = 180,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Image = product.ProductImage != null ? ConvertImageClass.ConvertByteArrayToImage(product.ProductImage) : null
                    };

                    Label productNameLabel = new Label
                    {
                        Text = $"Name: {product.ProductName}",
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Size = new Size(180, 30),
                        TextAlign = ContentAlignment.MiddleLeft,
                        AutoSize = false,
                        Location = new Point(5, 210)
                    };

                    Label productStockLabel = new Label
                    {
                        Text = $"Stock: {product.ProductsStock}",
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        Size = new Size(180, 30),
                        TextAlign = ContentAlignment.MiddleLeft,
                        AutoSize = false,

                        Location = new Point(5, 230)
                    };
                    Label categoryNameLabel = new Label
                    {
                        Text = $"Category: {product.Category.CategoryName}",
                        Font = new Font("Arial", 9, FontStyle.Bold),
                        Size = new Size(180, 30),
                        TextAlign = ContentAlignment.MiddleLeft,
                        AutoSize = false,

                        Location = new Point(5, 190)
                    };

                    flowLayoutPanelProducts.Padding = new Padding(20);
                    productPanel.Controls.Add(pictureBox);
                    productPanel.Controls.Add(categoryNameLabel);
                    productPanel.Controls.Add(productNameLabel);
                    productPanel.Controls.Add(productStockLabel);
                    flowLayoutPanelProducts.Controls.Add(productPanel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retriving staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}