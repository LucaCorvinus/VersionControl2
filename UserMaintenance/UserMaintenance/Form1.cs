﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();

            label_FullName.Text = Resource1.FullName;
            button_Add.Text = Resource1.Add;

            listBox_User.DataSource = users;
            listBox_User.ValueMember = "ID";
            listBox_User.DisplayMember = "FullName";
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            User newuser = new User();
            newuser.FullName = textBox_FullName.Text;
            users.Add(newuser);
        }
    }
}
