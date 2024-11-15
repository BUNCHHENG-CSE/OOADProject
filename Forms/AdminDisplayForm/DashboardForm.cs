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

    private void DashboardForm_Load(object sender, EventArgs e)
    {
        double[] values = { 789, 143, 283 };
        string[] labels = { "America", "China", "Canada" };
        Color[] labelcolors = { Color.White, Color.White, Color.White, };
        Color[] slicecolors = { Color.Red, Color.Coral, Color.Gold };
        var pie = formsPlot1.Plot.AddPie(values);
        pie.SliceLabels = labels;
        pie.ShowLabels = true;
        pie.SliceFillColors = slicecolors;
        pie.SliceLabelColors = labelcolors;
        formsPlot1.Plot.Style(this.BackColor, this.BackColor);

        formsPlot1.Plot.XAxis.Ticks(false);
        formsPlot1.Plot.YAxis.Ticks(false);
        formsPlot1.Refresh();
        //formsPlot1.Plot.Frame(false);
    }
}
