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
    public partial class Array : Form
    {
        const int size = 10;
        int[] number = new int[size];
        //ek jagey 2 ta index verable hoi na eki scop ar modey tai globaly dioa hoise!
        int index = 0;
        public Array()
        {
            InitializeComponent();

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            //Array fix kore const die!
            const int size = 10;

            //Array Declaration
            int[] number = new int[size];

            number[0] = 1;
            number[1] = 2;
            number[2] = 3;

            //ShowRichTextBox.Text = number[0].ToString();
            //ShowRichTextBox.Text = number[1].ToString();
            //ShowRichTextBox.Text = number[2].ToString();

            string message = "";

            //EKta kor Input nio Jono

            //message = message + "Value of Index 0 is: " +number[0].ToString()+"\n";
            //message = message + "Value of Index 1 is: " + number[1].ToString()+ "\n";
            //message = message + "Value of Index 2 is: " + number[2].ToString()+ "\n";

            //Bar Bar na likha lagey tar jono
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                {
                    message = message + "Value of Index " + index + " is: " + number[index].ToString() + "\n";
                }

            }


            ShowRichTextBox.Text = message;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
          

            number[index] =Convert.ToInt32( addTextBox.Text);
            index++;

            //ShowRichTextBox.Text = number[0].ToString();
            //ShowRichTextBox.Text = number[1].ToString();
            //ShowRichTextBox.Text = number[2].ToString();

            string message = "";

            //EKta kor Input nio Jono

            //message = message + "Value of Index 0 is: " +number[0].ToString()+"\n";
            //message = message + "Value of Index 1 is: " + number[1].ToString()+ "\n";
            //message = message + "Value of Index 2 is: " + number[2].ToString()+ "\n";

            //Bar Bar na likha lagey tar jono
            for (int index =0; index < number.Length; index++)
            {
                if (number[index] != 0)
                {
                   
                    message = message + "Value of Index " + index + " is: " + number[index].ToString() + "\n";
                }

            }

           
                ShowRichTextBox.Text = message;
        
        }
    }
}
