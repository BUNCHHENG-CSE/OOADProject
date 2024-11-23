using Microsoft.Data.SqlClient;
using OOADPRO.Models;
using OOADPRO.Utilities;

namespace OOADPRO.Forms.AdminDisplayForm;

public partial class StaffForm : Form
{
    int staffCount = 0;
    public StaffForm()
    {
        InitializeComponent();
        btnAddStaff.Click += DoClickAddStaff;
    }

    private void DoClickAddStaff(object? sender, EventArgs e)
    {
        StaffAddForm staffAddForm = new StaffAddForm(this);
        staffAddForm.StaffLoadingChanged += (sender, result) =>
        {
            if (result)
            {
                flowLayoutPanelStaff.Controls.Clear();
                LoadingDataStaff();
            }
        };
        staffAddForm.Show();

    
    }

    private void StaffForm_Load(object sender, EventArgs e)
    {
        LoadingDataStaff();
    }
    private void LoadingDataStaff()
    {
        try
        {
            var result = StaffFunc.GetAllStaff(Program.Connection);
            Console.WriteLine(result);
            foreach (var staff in result)
            {
                Panel productPanel = new Panel
                {
                    Width = 185,
                    Height = 250,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                PictureBox pictureBox = new PictureBox
                {
                    Width = 180,
                    Height = 180,
                    
                    SizeMode = PictureBoxSizeMode.Zoom,
                    
                    Image = staff.Photo != null ? ConvertImageClass.ConvertByteArrayToImage(staff.Photo) : null
                   
                };

                Label staffNameLabel = new Label
                {
                    Text = staff.StaffName,
                    AutoSize = true,
                    Location = new Point(5, 190)
                };

                Label staffPosition = new Label
                {
                    Text = staff.StaffPosition,
                    AutoSize = true,
                    Location = new Point(5, 210)
                };
                pictureBox.Click += (sender, e) =>
                {
                    LoadStaffForUpdate();
                };
                pictureBox.DoubleClick += (sender, e) =>
                {
                    DeleteProductById(staff.StaffID);
                };

                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(staffNameLabel);
                productPanel.Controls.Add(staffPosition);
                flowLayoutPanelStaff.Controls.Add(productPanel);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Retriving staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void LoadStaffForUpdate()
    {
        StaffAddForm updateForm = new StaffAddForm(this);
        updateForm.ShowDialog();
    }
    private void DeleteProductById(int staffid)
    {
        {
            try
            {
                var result = StaffFunc.GetAllStaff(Program.Connection);
                bool isDeleted = StaffFunc.DeleteStaff(Program.Connection, staffid);

                if (isDeleted)
                {
                    MessageBox.Show("Product deleted successfully!");
                    // Optionally, reload the products after deletion
                    flowLayoutPanelStaff.Controls.Clear();
                    LoadingDataStaff();
                }
                else
                {
                    MessageBox.Show("Failed to delete the product.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting product: {ex.Message}");
            }
        }


    }
}
