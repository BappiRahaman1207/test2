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
    public partial class CoffeeShopArray : Form
    {
        const int size = 10;
        int index = 0;
       
        string[] customerName = new string[size];
        int[] contactNo = new int[size];
        string[] Address = new string[size];
        string[] Order = new string[size];
        int[] Quantity = new int[size];

        public CoffeeShopArray()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void CoffeeShopArray_Load(object sender, EventArgs e)
        {
            orderComboBox.Text = "Select Item";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
             customerName[index] = nameTextBox.Text;
             contactNo[index] = Convert.ToInt32(contactTextBox.Text);
             Address [index]= addressTextBox.Text.ToString();
             Order[index] = orderComboBox.Text;
             Quantity[index] = Convert.ToInt32(quntityTextBox.Text);

            index++;
            string message = "";
            for (int index=0;index<customerName.Length;index++)
            {
                if (Quantity[index] != 0)
                { 
                  message= message +"Customer Name: " + customerName[index] + "\n" + "Contact No: " + contactNo[index] + "\n"
                  + "Address: " + Address[index] + "\n" + "Order: " + Order[index] + "\n" + "Quantity: " + Quantity[index]+"\n\n\n";
                    
                }
            }

            ShowRichTextBox.Text = "Customer Information:"+"\n\n"+ message +"\n";
        }
    }
}
