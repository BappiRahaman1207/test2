using System;
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
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Home newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            orderComboBox.Text = "Select Item";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string cutomerName = nameTextBox.Text;
            int contactNo = Convert.ToInt32(contactTextBox.Text);
            string Address = addressTextBox.Text;
            string Order = orderComboBox.Text;
            int Quantity = Convert.ToInt32(quntityTextBox.Text);
            ShowRichTextBox.Text = "Customer Name: " + cutomerName + "\n" + "Contact No: " + contactNo + "\n"
                + "Address: " + Address+"\n"+"Order: "+ Order+"\n"+"Quantity: "+ Quantity;
               
        }
    }
}
