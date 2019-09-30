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
    public partial class CoffeeShopUAP : Form
    {
        const int size = 10;
        int index = 0;

        string[] customerName = new string[size];
        int[] contactNo = new int[size];
        string[] Address = new string[size];
        string[] Order = new string[size];
        int[] Quantity = new int[size];
        //int BlackCoffeePrice = 120;
        //int ClodCoffeePrice = 100;
        //int HotCoffeePrice = 90;
        //int RegularCoffeePrice = 80;
        int []TotalPrice =new int [size];
        public CoffeeShopUAP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Field cannot be empty!");
            }

            else if (contactTextBox.Text == "")
            {
                MessageBox.Show("Field cannot be empty!");
            }

            else if (addressTextBox.Text == "")
            {
                MessageBox.Show("Field cannot be empty!");
            }


            else if (quntityTextBox.Text == "")
            {

                MessageBox.Show("Field cannot be empty!");
            }

            else if (orderComboBox.Text == "")
            {
                MessageBox.Show("Field cannot be empty!");
            }


            else

            {
                customerName[index] = nameTextBox.Text;
                contactNo[index] = Convert.ToInt32(contactTextBox.Text);
                Address[index] = addressTextBox.Text.ToString();
                Order[index] = orderComboBox.Text;
                Quantity[index] = Convert.ToInt32(quntityTextBox.Text);

                if (Order[index] == "Black Coffee")
                {
                    TotalPrice[index] = Quantity[index] * 120;
                }

                else if (Order[index] == "Cold Coffee")
                {
                    TotalPrice[index] = Quantity[index] * 100;
                }

                else if (Order[index] == "Hot Coffee")
                {
                    TotalPrice[index] = Quantity[index] * 90;
                }

                else if (Order[index] == "Regular Coffee")
                {
                    TotalPrice[index] = Quantity[index] * 80;
                }



                index++;


                string message = "";
                for (int index = 0; index < customerName.Length; index++)
                {
                    if (Quantity[index] != 0)
                    {
                        message = message + "Customer Name: " + customerName[index] + "\n" + "Contact No: " + contactNo[index] + "\n"
                        + "Address: " + Address[index] + "\n" + "Order: " + Order[index] + "\n" + "Quantity: " + Quantity[index] + "\n" + "Total Price: " + TotalPrice[index] + "\n\n\n";

                    }
                }

                ShowRichTextBox.Text = "Customer Information:" + "\n\n" + message + "\n";

            }
            

        }

        private void CoffeeShopUAP_Load(object sender, EventArgs e)
        {
            orderComboBox.Text = "Select Coffee";
           
        }
    }
}
