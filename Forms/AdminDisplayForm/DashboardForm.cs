using ScottPlot;
using ScottPlot.MarkerShapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOADPRO.Forms.AdminDisplayForm;

public partial class DashboardForm : Form
{
    public DashboardForm()
    {
        InitializeComponent();
    }
    private void WeeklySale()
    {
        double[] dataX = new double[] { 1, 4, 9, 16, 25 };
        double[] dataY = new double[] { 1, 2, 3, 4, 5 };
        formsPlotWeeklySale.Plot.AddBar(dataX, dataY);
        formsPlotWeeklySale.Refresh();
    }
    private void TodayvsYTDPlot()
    {
        double[] values = { 789, 143 };
        string[] labels = { "Yesterday", "Today" };
        Color[] labelcolors = { Color.White, Color.White,};
        Color[] slicecolors = { Color.Red,  Color.Gold };
        var pie = formsPlotTodayvsYTD.Plot.AddPie(values);
        pie.SliceLabels = labels;
        pie.ShowLabels = true;
        pie.SliceFillColors = slicecolors;
        pie.SliceLabelColors = labelcolors;
        formsPlotTodayvsYTD.Plot.Style(this.BackColor, this.BackColor);
        formsPlotTodayvsYTD.Plot.XAxis.Ticks(false);
        formsPlotTodayvsYTD.Plot.YAxis.Ticks(false);
        formsPlotTodayvsYTD.Refresh();
    }
    private void DashboardForm_Load(object sender, EventArgs e)
    {
        TodayvsYTDPlot();
        WeeklySale();
    }
}
