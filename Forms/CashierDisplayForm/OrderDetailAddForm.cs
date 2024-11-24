using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOADPRO.Models;
using OOADPRO.Utilities;

namespace OOADPRO.Forms.CashierDisplayForm
{
    public partial class OrderDetailAddForm : Form
    {
        private int? OrderID;
        private float TotalAmount = 0;

        public OrderDetailAddForm(int? orderId = null)
        {

            InitializeComponent();
            this.OrderID = orderId;

            if (OrderID != null)
            {
                //LoadOrderDetails((int)OrderID);
            }
            else
            {
                LoadProducts();
            }

        }
        private void LoadProducts()
        {
            var products = ProductFunc.GetAllProducts(Program.Connection);
            foreach (var product in products)
            {
                Panel productPanel = new Panel
                {
                    Width = 200,
                    Height = 250,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5)
                };

                PictureBox pictureBox = new PictureBox
                {
                    Width = 180,
                    Height = 180,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = product.ProductImage != null ? ConvertImageClass.ConvertByteArrayToImage(product.ProductImage) : null,
                    Tag = product // Store product data in Tag for reference
                };
                pictureBox.Click += (s, e) =>
                {
                    AddProductToGrid((Products)pictureBox.Tag);
                };
                Label productNameLabel = new Label
                {
                    Text = product.ProductName,
                    AutoSize = true,
                    Location = new Point(5, 190)
                };
                Label productPriceLabel = new Label
                {
                    Text = $"${product.ProductsPrice}",
                    AutoSize = true,
                    Location = new Point(5, 210)
                };
                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(productNameLabel);
                productPanel.Controls.Add(productPriceLabel);
                flowLayoutPanel1.Controls.Add(productPanel);
            }
        }
        private void AddProductToGrid(Products product)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((int)row.Cells["ProductsID"].Value == product.ProductsID)
                {
                    row.Cells["Qty"].Value = Convert.ToInt32(row.Cells["Qty"].Value) + 1;
                    CalculateRowAmount(row);
                    UpdateTotalAmount();
                    return;
                }

                int rowIndex = dataGridView1.Rows.Add();
                var newRow = dataGridView1.Rows[rowIndex];
                newRow.Cells["ProductsID"].Value = product.ProductsID;
                newRow.Cells["ProductName"].Value = product.ProductName;
                newRow.Cells["Qty"].Value = 1;
                newRow.Cells["UnitPrice"].Value = product.ProductsPrice;
                CalculateRowAmount(newRow);
                UpdateTotalAmount();
            }
        }
        private void CalculateRowAmount(DataGridViewRow row)
        {
            int qty = Convert.ToInt32(row.Cells["Qty"].Value);
            float unitPrice = Convert.ToSingle(row.Cells["UnitPrice"].Value);
            row.Cells["Amount"].Value = qty * unitPrice;
        }
        private void UpdateTotalAmount()
        {
            TotalAmount = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                TotalAmount += Convert.ToSingle(row.Cells["Amount"].Value);
            }

            txtTotal.Text = TotalAmount.ToString("F2");
        }




    }
}
    