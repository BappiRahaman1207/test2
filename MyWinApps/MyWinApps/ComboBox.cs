﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApps
{
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string planetName = planetNameComboBox.Text;
            if (planetName == "Planet")
            {
                MessageBox.Show("It is in 3rd position");
            }
            else if (planetName == "Saturn")
            {
                MessageBox.Show("It is in 6th position");
            }
            else if (planetName == "Mars")
            {
                MessageBox.Show("It is in 4th position");
            }
            else
            {
                MessageBox.Show("I don’t know");

            }
        }

        private void ComboBox_Load(object sender, EventArgs e)
        {
            planetNameComboBox.Text = "Select Item";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Home newForm = new Home();
            newForm.Show();
            this.Hide();
        }
    }
}
