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
    public partial class ArrayDuplicate : Form
    {
        const int size = 10;
        int[] number = new int[size];
        int index = 0;
        int count = 0;
      
        public ArrayDuplicate()
        {
            InitializeComponent();
        }

        private void BackBtton_Click(object sender, EventArgs e)
        {
            Home newForm = new Home();
            newForm.Show();
            this.Hide();
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

            ShowRichTextBox.Text = "Array Are :" + "\n" + message+"\n";


             message = "The Duplicate Number";
            //for (int index = 0; index < number.Length; index++)


            //{
            //    for (int j = index + 1; j < number.Length; j++)
            //    {
            //        if (number[index] == number[j])
            //        {

            //            count++;
            //            break;

            //        }


            //    }


             
            //    ShowRichTextBox.Text = "Array Are :" + "\n" +count;


            //}
        }



    }
}
