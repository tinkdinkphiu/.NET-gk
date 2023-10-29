using BUS;
using DTO;
using LiveCharts;
using LiveCharts.Definitions.Charts;
using LiveCharts.Maps;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _52100572_52100852_Source_GK
{
    public partial class Revenue : Form
    {
        public Revenue()
        {
            InitializeComponent();
            lv_Revenue.Columns.Add("Hãng Xe", 80);
            lv_Revenue.Columns.Add("Số lượng", 80);
            lv_Revenue.Columns.Add("Doanh Thu", 120);

            pieChart_Quantity.DataClick += PieChart1_DataClick;
            pieChart_Revenue.DataClick += PieChart1_DataClick;
            pieChart_CarDistributionByType.DataClick += PieChart1_DataClick;

            DateTime end = DateTime.Now;
            DateTime start = new DateTime(end.Year, end.Month, 1);
            dtpk_BatDau.Value = start;
            dtpk_KetThuc.Value = end;
            dtpk_BatDau.MaxDate = end;
            dtpk_KetThuc.MaxDate = end;

            DisplayCarDistributionByType();
        }

        private void Revenue_Load(object sender, EventArgs e)
        {

            List<StaticsDTO> data = DonDatXeBUS.Instance.GetRevenueByHang(dtpk_BatDau.Value, dtpk_KetThuc.Value);
            bindingData(data);

            DisplayRevenueByMonthYear(DateTime.Now.Year);
        }

        private void bindingData(List<StaticsDTO> data)
        {
            lv_Revenue.Items.Clear();
            pieChart_Quantity.Series = new SeriesCollection();
            pieChart_Revenue.Series = new SeriesCollection();
            foreach (var item in data)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.SubItems[0].Text = item.item1.ToString();
                listViewItem.SubItems.Add(item.item2.ToString());
                listViewItem.SubItems.Add(double.Parse(item.item3).ToString("N0"));
                lv_Revenue.Items.Add(listViewItem);

                pieChart_Quantity.Series.Add(new PieSeries
                {
                    Title = item.item1,
                    Values = new ChartValues<int> { int.Parse(item.item2) },
                    DataLabels = true
                });
                pieChart_Revenue.Series.Add(new PieSeries
                {
                    Title = item.item1,
                    Values = new ChartValues<Double> { double.Parse(item.item3) },
                    DataLabels = true
                });
            }


        }
        private void PieChart1_DataClick(object sender, ChartPoint chartPoint)
        {
            MessageBox.Show($"{chartPoint.SeriesView.Title}: {chartPoint.Y}");
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            if (cbb_RevenueBy.SelectedIndex == 0)
            {
                List<StaticsDTO> data = DonDatXeBUS.Instance.GetRevenueByHang(dtpk_BatDau.Value, dtpk_KetThuc.Value);
                lv_Revenue.Columns[0].Text = "Hãng Xe";
                bindingData(data);
            }
            else
            {
                List<StaticsDTO> data = DonDatXeBUS.Instance.GetRevenueByModel(dtpk_BatDau.Value, dtpk_KetThuc.Value);
                lv_Revenue.Columns[0].Text = "Model";

                bindingData(data);
            }
        }
        public void DisplayCarDistributionByType()
        {
            var data = DonDatXeBUS.Instance.GetCarDistributionByType();

            pieChart_CarDistributionByType.Series = new SeriesCollection();
            foreach (var item in data)
            {
                pieChart_CarDistributionByType.Series.Add(new PieSeries
                {
                    Title = item.item1,
                    Values = new ChartValues<int> { int.Parse(item.item2) },
                    DataLabels = true
                });
            }
        }

        public void DisplayRevenueByMonthYear(int year)
        {
            var data = DonDatXeBUS.Instance.GetRevenueOfYear(year);
            chart_RevenueOfYear.Series.Clear();
            chart_RevenueOfYear.AxisX.Clear();
            chart_RevenueOfYear.AxisY.Clear();

            chart_RevenueOfYear.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Doanh thu",
                    Values = new ChartValues<double>(data.Select(x =>  double.Parse(x.item2)))
                }
            };

            chart_RevenueOfYear.AxisX.Add(new Axis
            {
                Title = "Tháng",
                Labels = data.Select(x => x.item1).ToList()
            });

            chart_RevenueOfYear.AxisY.Add(new Axis
            {
                Title = "Số tiền",
                LabelFormatter = value => value.ToString("C")
            });
        }


        private void btn_LoadRevenueByYear_Click(object sender, EventArgs e)
        {
            DisplayRevenueByMonthYear(dtpk_Year.Value.Year); 
        }
    }
}
