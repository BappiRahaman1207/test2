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
    public partial class ArrayProgram2 : Form
    {
        const int size = 10;
        int[] number = new int[size];
        int index = 0;
        public ArrayProgram2()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string message = "";

            number[index] = Convert.ToInt32(AddTextBox.Text);
            index++;
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                {
                    message = message + "Value of Index " + index + " is: " + number[index].ToString() + "\n";
                }

            }
            ShowRichTextBox.Text = "Array Are :" + "\n" +message;


        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            string message = "";
            for (int index = number.Length - 1; index >= 0; index--)
            {
                if (number[index] != 0)

                    message = message + "elment of array " + index + " :" + number[index].ToString() + "\n";


            }

            ShowRichTextBox.Text = "Reverse Array :"+"\n" + message;
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            
            int Sum=0;

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                {
                  

                    Sum += number[index];
                }

            }
            ShowRichTextBox.Text = "Total :" +Sum.ToString();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            string message = "";
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                {
                    message = message + "Value of Index " + index + " is: " + number[index].ToString() + "\n";
                }

            }
            ShowRichTextBox.Text = "Copy Array :" +"\n"+message;
        }

        private void BackBtton_Click(object sender, EventArgs e)
        {
            Home newForm = new Home();
            newForm.Show();
            this.Hide();
        }
    }
}