using OOADPRO.Forms.AdminDisplayForm;
namespace OOADPRO;

public partial class AdminForm : Form
{
    public AdminForm()
    {
        InitializeComponent();
        btnDashboard.Click += DoClickDashboard;
        btnStaff.Click += DoClickStaff;
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
