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
    public partial class CoffeeShopList : Form
    {
        const int size = 10;
        int index=0;
        List<string> customerNames = new List<string>();
        List<int> contactNos = new List<int>();
        List<string> Addresses = new List<string>();
        List<string> Orders = new List<string>();
        List<int> Quantitys = new List<int>();
        List<int> TotalPrices = new List<int>();

        int BlackCoffeePrice = 120;
        int ClodCoffeePrice = 100;
        int HotCoffeePrice = 90;
        int RegularCoffeePrice = 80;



        public CoffeeShopList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void CoffeeShopList_Load(object sender, EventArgs e)
        {
            orderComboBox.Text = "Select Coffee";
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
                
                customerNames.Add ( nameTextBox.Text);
                contactNos.Add ( Convert.ToInt32(contactTextBox.Text));
                Addresses.Add( addressTextBox.Text.ToString());
                Orders.Add( Convert.ToString(orderComboBox.Text));
                Quantitys.Add( Convert.ToInt32(quntityTextBox.Text));

                TotalPrices.Add(index);

                if (orderComboBox.Text == "Black Coffee")
                {
                    TotalPrices[index] = BlackCoffeePrice * Quantitys[index];
                }

                else if (orderComboBox.Text == "Cold Coffee")
                {
                    TotalPrices[index] = ClodCoffeePrice *Quantitys[index];
                }

                else if (orderComboBox.Text == "Hot Coffee")
                {
                    TotalPrices[index] =  HotCoffeePrice*Quantitys[index];
                }

                else if (orderComboBox.Text == "Regular Coffee")
                {
                    TotalPrices[index] = RegularCoffeePrice*Quantitys[index];
                }



                index++;


                string message = "";
                for (int index = 0; index < customerNames.Count; index++)
                {
                    if (Quantitys[index] != 0)
                    {
                        message = message + "Customer No : " +(index + 1) +"\n"+ "Customer Name: " + customerNames[index] + "\n" + "Contact No: " + contactNos[index] + "\n"
                        + "Address: " + Addresses[index] + "\n" + "Order: " + Orders[index] + "\n" + "Quantity: " + Quantitys[index] + "\n" + "Total Price: " + TotalPrices[index] + "\n\n\n";

                    }
                }

                ShowRichTextBox.Text = "Customer Information:" + "\n\n" + message + "\n";

            }
        }
    }
}
