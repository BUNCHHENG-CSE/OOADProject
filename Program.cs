using Microsoft.Data.SqlClient;
using OOADPRO.Utilities;

namespace OOADPRO;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ConnectToDB();
        ApplicationConfiguration.Initialize();
        Application.Run(new AdminForm());
    }
    public static void ConnectToDB()
    {
        Helper.ConnectionStringKey = "DBConnectionString";
        try
        {
            Helper.LoadConfiguration("appSettings.json");
            Connection = Helper.OpenConnection();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Connecting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        }
    }
    public static SqlConnection Connection = default!;
    public static string[] Genders { get; set; } = new string[] { "Female", "Male" };
}