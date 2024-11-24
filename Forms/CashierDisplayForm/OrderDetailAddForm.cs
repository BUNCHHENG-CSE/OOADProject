using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
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
                LoadOrderDetails(Program.Connection,(int)OrderID);
            }
            else
            {
                LoadProducts();
            }
            buttonpay.Click += btnSave_Click;

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
                    Tag = product 
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
            }

            int rowIndex = dataGridView1.Rows.Add();
            var newRow = dataGridView1.Rows[rowIndex];
            newRow.Cells["OrderDetailID"].Value = -1;
            newRow.Cells["ProductsID"].Value = product.ProductsID;
            newRow.Cells["ProductsName"].Value = product.ProductName;
            newRow.Cells["Qty"].Value = 1;
            newRow.Cells["UnitPrice"].Value = product.ProductsPrice;
          
            CalculateRowAmount(newRow);
            UpdateTotalAmount();
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

            txtTotal.Text = $"Total: ${TotalAmount:F2}";

        }
        private void LoadOrderDetails(SqlConnection con, int orderId)
        {
            SqlCommand cmd = new SqlCommand("GetOrderDetailsByOrderID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@odid", orderId);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int orderDetailId = reader.GetInt32(reader.GetOrdinal("OrderDetailID"));
                    int orderQty = reader.GetInt32(reader.GetOrdinal("OrderQty"));
                    float unitPrice = reader.GetFloat(reader.GetOrdinal("UnitPrice"));
                    string productName = reader.GetString(reader.GetOrdinal("ProductName"));
                    int productsId = reader.GetInt32(reader.GetOrdinal("ProductsID"));

                    // Add row to the DataGridView
                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];

                    row.Cells["OrderDetailID"].Value = orderDetailId;
                    row.Cells["ProductsID"].Value = productsId;
                    row.Cells["ProductName"].Value = productName;
                    row.Cells["Qty"].Value = orderQty;
                    row.Cells["UnitPrice"].Value = unitPrice;
                    CalculateRowAmount(row);
                    UpdateTotalAmount();
                }
            }
        }
        private void SaveOrderDetails(SqlConnection con)
        {
            SqlCommand cmd;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                int orderDetailId = Convert.ToInt32(row.Cells["OrderDetailID"].Value);
                int productId = Convert.ToInt32(row.Cells["ProductsID"].Value);
                int orderQty = Convert.ToInt32(row.Cells["Qty"].Value);
                float unitPrice = Convert.ToSingle(row.Cells["UnitPrice"].Value);
                if (orderDetailId == -1)
                {
                    cmd = new SqlCommand("InsertOrderDetail", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@OrderID", this.OrderID); 
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    cmd.Parameters.AddWithValue("@OrderQty", orderQty);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd = new SqlCommand("UpdateOrderDetail", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@OrderDetailID", orderDetailId);
                    cmd.Parameters.AddWithValue("@OrderID", this.OrderID);
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    cmd.Parameters.AddWithValue("@OrderQty", orderQty);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (Program.Connection) 
            {
                Program.Connection.Open();
                SaveOrderDetails(Program.Connection);
            }
            MessageBox.Show("Order details saved successfully!");
        }



    }
}
    