using MintaZH.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

namespace MintaZH
{
    public partial class Form1 : Form
    {
        List<OlympicResult> results = new List<OlympicResult>();
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;

        public Form1()
        {
            InitializeComponent();
            ReadData("Summer_olympic_Medals.csv");
            SelectYear();
            CountryPosition();
        }

        private void ReadData(string fileToRead)
        {
            StreamReader sr = new StreamReader(fileToRead, Encoding.Default);
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(',');

                var newresult = new OlympicResult();
                newresult.Year = Convert.ToInt32(line[0]);
                newresult.Country = line[3];
                //newresult.Position =
                newresult.Medals = new int[]
                {
                    int.Parse(line[5]),
                    int.Parse(line[6]),
                    int.Parse(line[7])
                };

                results.Add(newresult);
            }
        }

        private void SelectYear()
        {
            var evek = (from x in results
                        orderby x.Year
                        select x.Year).Distinct();

            comboBox_Year.DataSource = evek.ToList();
        }

        private int Position(OlympicResult or)
        {
            int counter = 0;

            var masorszagokazevben = from x in results
                                     where x.Year == or.Year
                                     where x.Country != or.Country
                                     select x;

            foreach (OlympicResult r in masorszagokazevben)
            {
                if (or.Medals[0] > r.Medals[0])
                {
                    counter++;
                }
                if (or.Medals[0] == r.Medals[0] & or.Medals[1] < r.Medals[1])
                {
                    counter++;
                }
                if (or.Medals[0] == r.Medals[0] & or.Medals[1] == r.Medals[1] & or.Medals[2] < r.Medals[2])
                {
                    counter++;
                }
            }

            return counter + 1;
        }

        private void CountryPosition()
        {
            foreach (var result in results)
            {
                result.Position = Position(result);
            }
        }

        private void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;

                CreateTable();

                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }

        private void CreateTable()
        {
            string[] headers = new string[]
            {
                "Helyezés",
                "Ország",
                "Arany",
                "Ezüst",
                "Bronz"
            };

            for (int i = 0; i < headers.Length; i++)
                xlSheet.Cells[1, i + 1] = headers[i];

            var adottevorszagai = from x in results
                                  where x.Year == int.Parse(comboBox_Year.Text)
                                  orderby x.Position 
                                  select x;

            var counter = 2;
            foreach (var r in adottevorszagai)
            {
                xlSheet.Cells[counter, 1] = r.Position;
                xlSheet.Cells[counter, 2] = r.Country;
                for (int i = 0; i <= 2; i++)
                {
                    xlSheet.Cells[counter, i + 3] = r.Medals[i];
                }
                counter++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateExcel();
        }
    }
}
