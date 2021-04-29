using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class Form1 : Form
    {
        private const int FIRST_STATE = 0;
        private const int SECOND_STATE = 1;
        private const int RESULT_SHOWN = 2;
        private const int INVALID_INPUT = 3;
        private int currentState;
        private double num1, num2;
        private int indexOfOperator;
        private string operation;


        public Form1()
        {
            currentState = FIRST_STATE;
            InitializeComponent();
        }

        

        private void button_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.SystemColors.ControlDarkDark;
        }

        private void button_MouseLeaveToBlack(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");

        }
        
        private void button_MouseLeaveToGray(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.SystemColors.ControlDark;

        }

        private void buttonEqual_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.ColorTranslator.FromHtml("#3090C7");
        }

        private void number_clicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            appedTextToTextView(b.Text);
        }

        private void operatorClicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string op = b.Text;

            try
            {

                if (currentState == FIRST_STATE)
                {
                    num1 = double.Parse(this.screen.Text);
                    indexOfOperator = this.screen.Text.Length;
                    operation = op;
                    appedTextToTextView(op);
                    currentState = SECOND_STATE;

                }
                else 
                {
                    appedTextToTextView("Invalid input, pleas clear and try again", "#ff0000 ");
                    currentState = INVALID_INPUT;
                }
            }
            catch (Exception e1)
            {
                appedTextToTextView("Invalid input, pleas clear and try again", "#ff0000 ");
                currentState = INVALID_INPUT;
            }

        }

        
   
        private void clearClicked(object sender, EventArgs e)
        {
            currentState = FIRST_STATE;
            this.screen.Text ="";

        }


        private void equalClicked(object sender, EventArgs e)
        {
            try
            {
                if (currentState == SECOND_STATE)
                {

                    num2 = double.Parse(this.screen.Text.Substring(indexOfOperator + 1));
                    double result = performOperation(num1, num2, operation);
                    this.screen.Text = this.screen.Text + "= " + result;
                    this.currentState = RESULT_SHOWN;
                }
            }
            catch (Exception e2)
            {
                appedTextToTextView("Invalid input, pleas clear and try again", "#ff0000 ");
            }
        }

        private void appedTextToTextView(string text)
        {
            if (currentState == RESULT_SHOWN || currentState ==INVALID_INPUT)
            {
                this.screen.Text = "";
                currentState = FIRST_STATE;
            }
            this.screen.Text = this.screen.Text + text;
        }
        
        private void appedTextToTextView(string text, string color)
        {

            this.screen.ForeColor = System.Drawing.ColorTranslator.FromHtml(color);
            this.screen.Text = text;
        }

        private void delete_last_char(object sender, MouseEventArgs e)
        {
            if (currentState == FIRST_STATE)
            {
                this.screen.Text = this.screen.Text.Substring(0, this.screen.Text.Length - 1);
            }
            else if (currentState == SECOND_STATE)
            {
                if (this.screen.Text.Length - 1 == indexOfOperator)
                {
                    this.screen.Text = this.screen.Text.Substring(0, this.screen.Text.Length - 1);
                    currentState = FIRST_STATE;
                }
                else
                {
                    this.screen.Text = this.screen.Text.Substring(0, this.screen.Text.Length - 1);

                }

            }
            else if (currentState == RESULT_SHOWN || currentState == INVALID_INPUT)
            {
                this.screen.Text ="";
                this.currentState = FIRST_STATE;
            }
        }

        private double performOperation(double num1, double num2, string op)
        {
            switch (op)
            {
                case ("+"):
                    return num1 + num2;
                case ("-"):
                    return num1 - num2;
                case ("x"):
                    return num1 * num2;
                case ("÷"):
                    return num1 / num2;
                default:
                    return 0;

            }
        }
    }
}
