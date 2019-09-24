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
    public partial class Method : Form
    {
        const int size = 10;
        int[] number = new int[size];
        int index = 0;
        int sum = 0;
        public Method()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Home newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            

            number[index] = Convert.ToInt32(AddTextBox.Text);
            index++;

            string message = Show();



            ShowRichTextBox.Text = "Array Are :" + "\n" + message + "\n";
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string message = "";

             message = Show();

            ShowRichTextBox.Text = "Array Are Show:" + "\n" + message + "\n";
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            string message = "";

            message=Show();

            message = message+ "\n"+ "Array Are Reverse:" + "\n";

            for (int index=number.Length-1; index>=0; index--)
            {

                if (number[index] != 0)
                {

                    message = message + "Value of Index " + index + " is: " + number[index].ToString() + "\n";

                }
            }

            ShowRichTextBox.Text = "Array Are Show:" + "\n" + message + "\n";
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
           

         
            for (int index = 0; index < number.Length; index++)
            {

                if (number[index] != 0)
                {

                    sum = sum + number[index];
               
                }



            }

            ShowRichTextBox.Text = "Array Sum :" + "\n" + sum + "\n";
        }





        //Method


        private string Show()
        {
            string message = "";
            for (int index = 0; index < number.Length; index++)
            {

                if (number[index] != 0)
                {

                    message = message + "Value of Index " + index + " is: " + number[index].ToString() + "\n";

                }



            }
            return message;
        }

    }
}
