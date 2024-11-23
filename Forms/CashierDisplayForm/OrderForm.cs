using OOADPRO.Utilities;

namespace OOADPRO.Forms.CashierDisplayForm
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

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
                    Image = product.ProductImage != null ? ConvertImageClass.ConvertByteArrayToImage(product.ProductImage) : null
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

                Label categoryLabel = new Label
                {
                    Text = $"Category: {product.Category?.CategoryName}",
                    AutoSize = true,
                    Location = new Point(5, 230)
                };

                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(productNameLabel);
                productPanel.Controls.Add(productPriceLabel);
                productPanel.Controls.Add(categoryLabel);
                flowLayoutPanel1.Controls.Add(productPanel);
            }
        }



    }
}
