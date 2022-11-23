using IRF_ZH_02_Felkeszules.Entities;
using IRF_ZH_02_Felkeszules.MNBServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace IRF_ZH_02_Felkeszules
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();
        BindingList<string> Currencies = new BindingList<string>();

        public Form1()
        {
            InitializeComponent();
            GetCurrencies();
            RefreshData();

            comboBox_Currencies.DataSource = Currencies;
        }

        private void GetCurrencies()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();
            var request = new GetCurrenciesRequestBody();
            var response = mnbService.GetCurrencies(request);
            var result = response.GetCurrenciesResult;
            richTextBox1.Text = result.ToString();

            var xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement element in xml.DocumentElement.ChildNodes[0])
            {
                string currency = element.InnerText;
                Currencies.Add(currency);
            }
        }

        public void RefreshData()
        {
            Rates.Clear();

            Webhívás();
            XMLFeldolgozasa();

            dgw_Rates.DataSource = Rates;

            Visualization();
        }

        private string Webhívás()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = comboBox_Currencies.Text,
                startDate = dateTimePicker_start.Value.ToString(),
                endDate = dateTimePicker_end.Value.ToString()
            };

            var response = mnbService.GetExchangeRates(request);
            var result = response.GetExchangeRatesResult;

            //richTextBox1.Text = result.ToString();

            return result.ToString();
        }

        private void XMLFeldolgozasa()
        {
            var xml = new XmlDocument();

            xml.LoadXml(Webhívás());

            foreach ( XmlElement element in xml.DocumentElement)
            {
                var rate = new RateData();
                Rates.Add(rate);

                rate.Date = DateTime.Parse(element.GetAttribute("date"));

                var childelement = (XmlElement)element.ChildNodes[0];
                if (childelement == null)
                    continue;

                rate.Currency = childelement.GetAttribute("curr");

                var unit = decimal.Parse(childelement.GetAttribute("unit"));
                var value = decimal.Parse(childelement.InnerText);
                if (unit != 0)
                {
                    rate.Value = value / unit;
                }
            }
        }

        private void Visualization()
        {
            chart_RateData.DataSource = Rates;

            var series = chart_RateData.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 2;

            var legend = chart_RateData.Legends[0];
            legend.Enabled = false;

            var chartArea = chart_RateData.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
        }

        private void dateTimePicker_start_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();  
        }

        private void dateTimePicker_end_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
