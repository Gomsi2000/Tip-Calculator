using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Calculator
{
    
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {







        }
        //minus Percentage button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // store the tip percentage in string format
                String percent = tip.Text;
                //remove the % symbol from the string and convert string to int
                int percentage = int.Parse(percent.Remove(percent.Length - 1, 1)) ;
                //when we click on this button it will decrease by one 
                percentage--;
                //take the value from the bill textbox
                double billText = double.Parse(bill.Text);
                //take the value from the people text box
                int peopleText = int.Parse(people.Text);
                //percentage never be negative
                if (percentage >= 0)
                {
                    //print the tip value in % format inside the tip Percentage textBox 
                    tip.Text = percentage.ToString()+"%";
                    //divide the bill and people and get in double datatype
                    double totalPerPerson = billText / peopleText;
                    //find the total percentage per person
                    double tipPer = totalPerPerson * percentage / 100;
                    //print the total percentage in Tip per person
                    totaltip.Text = "$"+tipPer.ToString();
                    //print the total bill include tip per person
                    totalbill.Text = "$"+(totalPerPerson + tipPer).ToString();

                }
            }
            //Exception 
            catch (Exception ex)
            {

                string input = bill.Text;
                //if the bill text is empty
                if (string.IsNullOrEmpty(input))
                {
                    string message = "Please enter Bill Amount";
                    string title = "Warning!!!  bill is empty";
                    bill.Text = "";
                    //throw the message dialog box as a pop up
                    MessageBox.Show(message, title);
                }
                else
                {
                    string message = "Please enter correct Bill Amount";
                    string title = "Warning!!! ";
                    bill.Text = "";
                    //throw the message dialog box as a popup
                    MessageBox.Show(message, title);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        //Plus percentage button
        private void plustip_Click(object sender, EventArgs e)
        {
            try {
                // store the tip percentage in string format
                String percent = tip.Text;
                //remove the % symbol from the string and convert string to int
                int percentage = int.Parse(percent.Remove(percent.Length - 1, 1));
                //when we click on this button it will increase by one
                percentage++;
                //take the value from the bill textbox
                double billText = double.Parse(bill.Text);
                //take the value from the people textbox
                int peopleText = int.Parse(people.Text);
                //percentage never be greater than 100
                if (percentage <= 100)
                {
                    //print the tip value in % format inside the tip Percentage textBox 
                    tip.Text = percentage.ToString()+"%";
                    //divide the bill and people and get in double datatype
                    double totalPerPerson = billText / peopleText;
                    //find the total percentage per person
                    double tipPer = totalPerPerson * percentage / 100;
                    //print the total percentage in Tip per person
                    totaltip.Text = "$"+tipPer.ToString();
                    //print the total bill include tip per person 
                    totalbill.Text = "$"+(totalPerPerson + tipPer).ToString();
                }
            }
            //Exception
            catch (Exception ex)
            {
                string input = bill.Text;
                //if the bill text is empty
                if (string.IsNullOrEmpty(input))
                {
                    string message = "Please enter Bill Amount";
                    string title = "Warning!!!  bill is empty";
                    bill.Text = "";
                    //throw the message dialog box as a pop up
                    MessageBox.Show(message, title);
                }
                else
                {
                    string message = "Please enter correct Bill Amount";
                    string title = "Warning!!! ";
                    bill.Text = "";
                    //throw the message dialog box as a popup
                    MessageBox.Show(message, title);
                }
            }
        }
        //Minus People Button
        private void minuspeople_Click(object sender, EventArgs e)
        {
            try
            {
                // store the no. of peoples from the people Text in string format
                int peopleText = int.Parse(people.Text);
                //when we click on this button it will decrease by one
                peopleText--;
                //take the value from the bill textbox
                double billText = double.Parse(bill.Text);
                // store the tip percentage in string format
                String percent = tip.Text;
                //remove the % symbol from the string and convert string to int
                int percentage = int.Parse(percent.Remove(percent.Length - 1, 1));
                //percentage never be smaller than 1
                if (peopleText >= 1)
                {
                    //print the no. of people inside the peopleText textBox
                    people.Text = peopleText.ToString();
                    //divide the bill and people and get in double datatype
                    double totalPerPerson = billText / peopleText;
                    //find the total percentage per person
                    double tipPer = totalPerPerson * percentage / 100;
                    //print the total percentage in Tip per person
                    totaltip.Text = "$"+tipPer.ToString();
                    //print the total bill include tip per person
                    totalbill.Text = "$"+(totalPerPerson + tipPer).ToString();
                }
            }
            //Exception
            catch (Exception ex)
            {
                string input = bill.Text;
                //if the bill text is empty
                if (string.IsNullOrEmpty(input))
                {
                    string message = "Please enter Bill Amount";
                    string title = "Warning!!!  bill is empty";
                    bill.Text = "";
                    //throw the message dialog box as a pop up
                    MessageBox.Show(message, title);
                }
                else
                {
                    string message = "Please enter correct Bill Amount";
                    string title = "Warning!!! ";
                    bill.Text = "";
                    //throw the message dialog box as a pop up
                    MessageBox.Show(message, title);
                }
            }
        }

        private void pluspeople_Click(object sender, EventArgs e)
        {
            try
            {
                // store the no. of peoples from the people Text in string format
                int peopleText = int.Parse(people.Text);
                //when we click on this button it will increase by one
                peopleText++;
                //take the value from the bill textbox
                double billText = double.Parse(bill.Text);
                // store the tip percentage in string format
                String percent = tip.Text;
                //remove the % symbol from the string and convert string to int
                int percentage = int.Parse(percent.Remove(percent.Length - 1, 1));
                //print the no. of people inside the peopleText textBox
                people.Text = peopleText.ToString();
                //divide the bill and people and get in double datatype
                double totalPerPerson = billText / peopleText;
                //find the total percentage per person
                double tipPer = totalPerPerson * percentage / 100;
                //print the total percentage in Tip per person
                totaltip.Text = "$"+tipPer.ToString();
                //print the total bill include tip per person
                totalbill.Text = "$"+(totalPerPerson + tipPer).ToString();
                
            }
            //Exception
            catch (Exception ex)
            {
                string input = bill.Text;
                //if the bill text is empty
                if (string.IsNullOrEmpty(input))
                {
                    string message = "Please enter Bill Amount";
                    string title = "Warning!!!  bill is empty";
                    bill.Text = "";
                    //throw the message dialog box as a pop up
                    MessageBox.Show(message, title);
                }
                else
                {
                    string message = "Please enter correct Bill Amount";
                    string title = "Warning!!! ";
                    bill.Text = "";
                    //throw the message dialog box as a pop up
                    MessageBox.Show(message, title);
                }
            }

        }

        private void bill_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if ((!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            TextBox textBox = sender as TextBox;
            //split the string into parts
            string[] parts = textBox.Text.Split('.');
            // checks to make sure only 1 decimal is allowed Or length of number is less than 9  

            if (((e.KeyChar == '.') && (textBox.Text.IndexOf('.') > -1)) || (!char.IsControl(e.KeyChar) && ((parts[0].Length >= 9))))
            {
                e.Handled = true;
            }
        }
    }
}
