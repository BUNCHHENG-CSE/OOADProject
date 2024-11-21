using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOADPRO.Forms.AdminDisplayForm
{
    public partial class SaleReportForm : Form
    {
        public SaleReportForm()
        {
            InitializeComponent();
        }
        private void DailySale()
        {
            double[] dataX = new double[] { 157, 158, 150, 87, 237 };
            double[] dataY = new double[] { 1, 2, 3, 4, 5 };
            formsPlotDailySale.Plot.AddBar(dataX, dataY);
            formsPlotDailySale.Refresh();
        }
        private void MonthlySale()
        {
            double[] dataX = new double[] { 1, 4, 9, 16, 25 };
            double[] dataY = new double[] { 1, 2, 3, 4, 5 };
            formsPlotMonthlySale.Plot.AddBar(dataX, dataY);
            formsPlotMonthlySale.Refresh();
        }
        private void YearlySale()
        {
            double[] dataX = new double[] { 1, 4, 9, 16, 25 };
            double[] dataY = new double[] { 1, 2, 3, 4, 5 };
            formsPlotYearlySale.Plot.AddBar(dataX, dataY);
            formsPlotYearlySale.Refresh();
        }
        private void OverallIncome()
        {
            double[] values = { 789,1200,3453 };
            string[] labels = { "Daily","Monthly","Yearly" };
            Color[] labelcolors = { Color.White, Color.White, Color.White };
            Color[] slicecolors = { Color.Gold,Color.BlueViolet,Color.Cyan };
            var pie = formsPlotOverallIncome.Plot.AddPie(values);
            pie.SliceLabels = labels;
            pie.ShowLabels = true;
            pie.SliceFillColors = slicecolors;
            pie.SliceLabelColors = labelcolors;
            formsPlotOverallIncome.Plot.Style(this.BackColor, this.BackColor);
            formsPlotOverallIncome.Plot.XAxis.Ticks(false);
            formsPlotOverallIncome.Plot.YAxis.Ticks(false);
            formsPlotOverallIncome.Refresh();
        }
        private void SaleReportForm_Load(object sender, EventArgs e)
        {
            DailySale();
            MonthlySale();
            YearlySale();
            OverallIncome();
        }
    }
}
