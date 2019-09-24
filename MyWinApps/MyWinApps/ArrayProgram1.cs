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
    public partial class ArrayProgram1 : Form
    {
        const int size = 10;
        int[] number = new int[size];
        int index = 0;
        public ArrayProgram1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
           

            string message = "";

            number[index] = Convert.ToInt32(AddTextBox.Text);
            index++;
            for (int index=0;index<number.Length;index++)
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
