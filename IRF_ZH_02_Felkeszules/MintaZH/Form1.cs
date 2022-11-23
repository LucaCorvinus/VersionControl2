using MintaZH.Abstractions;
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
using System.Xml;

namespace MintaZH
{
    public partial class Form1 : Form
    {
        List<Product> _products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            XMLOlvaso();
            Visualization();
        }

        private string Beolvaso(string FileName)
        {
            StreamReader sr = new StreamReader(FileName, Encoding.Default);
            sr.ReadLine();
            string result = sr.ReadToEnd();
            sr.Close();
            return result;
        }

        private void XMLOlvaso()
        {
            string result = Beolvaso("Menu.xml");
            richTextBox1.Text = result;

            var xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement element in xml.DocumentElement)
            {
                var childElement1 = (XmlElement)element.ChildNodes[0];
                string PROBA = childElement1.InnerText;
                MessageBox.Show(PROBA);

                //var childElement2 = (XmlElement)element.ChildNodes[2];
                //string description = childElement2.InnerText;

                //var childElement3 = (XmlElement)element.ChildNodes[3];
                //int calories = int.Parse(childElement3.InnerText);

                //var childElement4 = (XmlElement)element.ChildNodes[4];
                //string type = childElement3.InnerText;

                var name = element.SelectSingleNode("name").InnerText;
                var calories = element.SelectSingleNode("calories").InnerText;
                var description = element.SelectSingleNode("description").InnerText;
                var type = element.SelectSingleNode("type").InnerText;

                if (type == "food")
                {
                    Food food = new Food(); 
                    food.Title = name;
                    food.Description = description;
                    food.Calories = int.Parse(calories);
                    _products.Add(food);
                }

                if (type == "drink")
                {
                    Drink drink = new Drink();
                    drink.Title = name;
                    drink.Calories = int.Parse(calories);
                    _products.Add(drink);
                }
            }
        }

        private void Visualization()
        {
            var topPosition = 0;

            var rendezettlista = from x in _products
                                 orderby x.Title
                                 select x;

            foreach (var product in rendezettlista)
            { 
                product.Left = 0;
                product.Top = topPosition;
                Controls.Add(product);
                topPosition += product.Height;
            }
        }
    }
}
