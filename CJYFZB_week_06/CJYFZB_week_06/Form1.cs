using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using CJYFZB_week_06.Entities;
using CJYFZB_week_06.MNBServiceReference;

namespace CJYFZB_week_06
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();
        BindingList<string> Currencies = new BindingList<string>();

        public Form1()
        {
            InitializeComponent();
            XMLProcessing_Currencies(GetCurrencies());
            RefreshData();

            comboBox_Currencies.DataSource = Currencies;    
        }

        private void RefreshData()
        {
            Rates.Clear();
            WebHivas();
            XMLProcessing_ExchangeRates(WebHivas());
            DataVisualization();

            dgw_Rates.DataSource = Rates;
        }

        private string WebHivas()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = (string)comboBox_Currencies.SelectedItem,
                startDate = dateTimePicker1.Value.ToString(),
                endDate = dateTimePicker2.Value.ToString()
            };

            var response = mnbService.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;

            return result;

        }

        private void XMLProcessing_ExchangeRates(string result)
        {
            var xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement element in xml.DocumentElement)
            {
                RateData rate = new RateData();
                Rates.Add(rate);

                rate.Date = DateTime.Parse(element.GetAttribute("date"));
                
                var childElement = (XmlElement)element.ChildNodes[0];
                //a következő két sort ha nem szúrom be, akkor nem fut le a program
                if (childElement == null)
                    continue;
                rate.Currency = childElement.GetAttribute("curr");

                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                    rate.Value = value / unit;
            }
        }

        private void DataVisualization()
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void comboBox_Currencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private string GetCurrencies()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetCurrenciesRequestBody();
            var response = mnbService.GetCurrencies(request);
            var result = response.GetCurrenciesResult;

            return result;
        }

        private void XMLProcessing_Currencies(string result)
        {
            var xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement element in xml.DocumentElement.ChildNodes[0])
            {
                string currency = element.InnerText;
                Currencies.Add(currency);
            }
        }
    }
}
