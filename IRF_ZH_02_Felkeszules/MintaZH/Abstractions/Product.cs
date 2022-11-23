﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MintaZH.Abstractions
{
    public abstract class Product : Button
    {
		private string _title;

		public string Title
		{
			get { return _title; }
			set {
				_title = value;
				this.Text = Title;
				}
		}

		private int _calories;

		public int Calories
		{
			get { return _calories; }
			set {
				_calories = value;
				Display();
				}
		}

		public Product()
		{
			this.Width = 150;
			this.Height = 50;
		}

		public abstract void Display();


	}
}
