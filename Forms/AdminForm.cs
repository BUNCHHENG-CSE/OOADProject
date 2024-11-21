using OOADPRO.Forms.AdminDisplayForm;
namespace OOADPRO;

public partial class AdminForm : Form
{
    public AdminForm()
    {
        InitializeComponent();
        btnDashboard.Click += DoClickDashboard;
        btnStaff.Click += DoClickStaff;
        btnProducts.Click += DoClickProducts;
        btnCategory.Click += DoClickCategory;
        btnUser.Click += DoClickUser;
        btnSaleReport.Click += DoClickSaleReport;
        btnOverview.Click += DoClickOverview;
    }

    private void DoClickOverview(object? sender, EventArgs e)
    {
        AddControl(new OverviewForm());
    }

    private void DoClickSaleReport(object? sender, EventArgs e)
    {
        AddControl(new SaleReportForm());
    }

    private void DoClickUser(object? sender, EventArgs e)
    {
        AddControl(new UserForm());
    }

    private void DoClickCategory(object? sender, EventArgs e)
    {
        AddControl(new CategoryForm());
    }

    private void DoClickProducts(object? sender, EventArgs e)
    {
        AddControl(new ProductsForm());
    }

    private void DoClickStaff(object? sender, EventArgs e)
    {
        AddControl(new StaffForm());
    }

    private void DoClickDashboard(object? sender, EventArgs e)
    {

        AddControl(new DashboardForm());
    }

    public void AddControl(Form f)
    {
        panelcontrolMain.Controls.Clear();
        f.Dock = DockStyle.Fill;
        f.TopLevel = false;
        panelcontrolMain.Controls.Add(f);
        f.Show();
    }

    private void AdminForm_Load(object sender, EventArgs e)
    {
        AddControl(new DashboardForm());
    }
}
