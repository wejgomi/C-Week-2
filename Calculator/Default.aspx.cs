using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Calculator : System.Web.UI.Page
{
    //Declaration of Public variables
    Double resultValue = 0;
    String operationPerformed;
    bool isOperationPerformed = false;

   

    protected void button_click(object sender, EventArgs e)
    {
        if ((Screen.Text == "0") || (operationRadio.Checked == true)) //clears the '0' on the screen when user presses the button 
        {

            Screen.Text = "";
        }

        isOperationPerformed = false;
        operationRadio.Checked = isOperationPerformed;

        Button button = (Button)sender;
        if(button.Text == ".") //if user presses decimal 
        {
            if(!Screen.Text.Contains(".")) //checks if textbox contains decimal already
            {
                Screen.Text = Screen.Text + button.Text; //Displays the button text pressed by user on the screen
            }
        }
        else
        Screen.Text = Screen.Text + button.Text; //Displays the button text pressed by user on the screen

    }
     
    protected void operator_click(object sender, EventArgs e)
    {
        Button button1 = (Button)sender;

        if (button1.Text == "-" && (Screen.Text == "0")) //This line is to display minus sign on the screen if it is pressed at the start
        {
            Screen.Text = "-";
            isOperationPerformed = false;
            operationRadio.Checked = isOperationPerformed;

        }
        else
        {

            if (Double.Parse(resultLabel.Text) != 0)
            {
                operationPerformed = operationLabel.Text;
                resultValue = Double.Parse(resultLabel.Text);
                switch (operationPerformed)
                {
                    case "+":
                        Screen.Text = (resultValue + Double.Parse(Screen.Text)).ToString();
                        break;
                    case "-":
                        Screen.Text = (resultValue - Double.Parse(Screen.Text)).ToString();
                        break;
                    case "×":
                        Screen.Text = (resultValue * Double.Parse(Screen.Text)).ToString();
                        break;
                    case "÷":
                        Screen.Text = (resultValue / Double.Parse(Screen.Text)).ToString();
                        break;
                    case "^":
                        Screen.Text = (Math.Pow(resultValue,Double.Parse(Screen.Text))).ToString();
                        break;
                    default:
                        break;
                }

                operationPerformed = button1.Text;
                operationLabel.Text = operationPerformed;

                resultLabel.Text = Screen.Text;
                labelCurrentOperation.Text = resultLabel.Text + " " + operationPerformed;

                isOperationPerformed = true;
                operationRadio.Checked = isOperationPerformed;

            }

            else
            {
                operationPerformed = button1.Text;
                operationLabel.Text = operationPerformed;

                resultLabel.Text = Screen.Text;
                labelCurrentOperation.Text = resultLabel.Text + " " + operationPerformed;

                isOperationPerformed = true;
                operationRadio.Checked = isOperationPerformed;
            }
        }
    }

    protected void c_btn_Click(object sender, EventArgs e)
    {
        Screen.Text = "0";

        resultValue = 0;
        resultLabel.Text = "0";

        labelCurrentOperation.Text = "";
    }

    protected void eql_btn_Click(object sender, EventArgs e)
    {
       operationPerformed = operationLabel.Text;
       resultValue = Double.Parse(resultLabel.Text);
        switch (operationPerformed)
        {
            case "+":
                Screen.Text = (resultValue + Double.Parse(Screen.Text)).ToString(); 
                break;
            case "-":
                Screen.Text = (resultValue - Double.Parse(Screen.Text)).ToString();
                break;
            case "×":
                Screen.Text = (resultValue * Double.Parse(Screen.Text)).ToString();
                break; 
            case "÷":
                Screen.Text = (resultValue / Double.Parse(Screen.Text)).ToString();
                break;
            case "^":
                Screen.Text = (Math.Pow(resultValue, Double.Parse(Screen.Text))).ToString();
                break;
            default:
                break;
        }

        isOperationPerformed = true;
        operationRadio.Checked = isOperationPerformed;

        //resultValue = Double.Parse(Screen.Text);
        //resultLabel.Text = (resultValue).ToString();

 

        resultValue = 0; //
        resultLabel.Text = "0"; //


        labelCurrentOperation.Text = "";
    }

    protected void del_btn_Click(object sender, EventArgs e)
    {
        Screen.Text = "0";

        resultValue = 0;
        resultLabel.Text = "0";

        labelCurrentOperation.Text = "";
    }

    protected void percent_btn_Click(object sender, EventArgs e)
    {
        resultValue = Double.Parse(Screen.Text);

        Screen.Text = (resultValue/100).ToString();

        isOperationPerformed = true;
        operationRadio.Checked = isOperationPerformed;

    }

    protected void pi_btn_Click(object sender, EventArgs e)
    {
        Screen.Text = "3.141592653589793";
        labelCurrentOperation.Text = "π";
        isOperationPerformed = true;
        operationRadio.Checked = isOperationPerformed;
    }

    protected void Rand_btn_Click(object sender, EventArgs e)
    {
        Random rand = new Random();
        double u1 = rand.NextDouble(); //u1 generates random numbers between 0 and 1
        Screen.Text = u1.ToString();
        labelCurrentOperation.Text = "Random number between 0 & 1";
        isOperationPerformed = true;
        operationRadio.Checked = isOperationPerformed;
    }


    protected void trig_click(object sender, EventArgs e)
    {
        Button button2 = (Button)sender;
        operationPerformed = button2.Text;
        trigLabel.Text = operationPerformed;

        resultLabel.Text = Screen.Text;
        resultValue = Double.Parse(Screen.Text);

       
        labelCurrentOperation.Text = operationPerformed + "(" + resultLabel.Text + ")";
      
        switch (operationPerformed)
        {
            case "sinh":
                Screen.Text = (Math.Sinh(resultValue)).ToString();
                break;
            case "cosh":
                Screen.Text = (Math.Cosh(resultValue)).ToString();
                break;
            case "tanh":
                Screen.Text = (Math.Tanh(resultValue)).ToString();
                break;
            case "sin":
                Screen.Text = (Math.Sin(resultValue)).ToString();
                break;
            case "cos":
                Screen.Text = (Math.Cos(resultValue)).ToString();
                break;
            case "tan":
                Screen.Text = (Math.Tan(resultValue)).ToString();
                break;
            case "ln":
                Screen.Text = (Math.Log(resultValue)).ToString();
                break;
            case "exp":
                labelCurrentOperation.Text = "exp" + "(" + resultLabel.Text + ")";
                Screen.Text = (Math.Exp(resultValue)).ToString();
                break;

            default:
                break;
        }

        isOperationPerformed = true;
        operationRadio.Checked = isOperationPerformed;
    }



    protected void e_btn_Click(object sender, EventArgs e)
    {
        Screen.Text = "2.718281828459045";
        labelCurrentOperation.Text = "exp";
        isOperationPerformed = true;
        operationRadio.Checked = isOperationPerformed;
    }

    protected void factorial_Click(object sender, EventArgs e)
    {
        resultValue = double.Parse(Screen.Text);
        double factorial = resultValue;
        labelCurrentOperation.Text = resultValue + "!";
        for (double i = 1; i < resultValue; i++)
        {
            factorial = factorial * i;
        }
        Screen.Text = factorial.ToString();
        
        isOperationPerformed = true;
        operationRadio.Checked = isOperationPerformed;

    }

    protected void x_click(object sender, EventArgs e)
    {
        Button button3 = (Button)sender;
        operationPerformed = button3.Text;
        xLabel.Text = operationPerformed;

        resultLabel.Text = Screen.Text;
        resultValue = Double.Parse(Screen.Text);

        switch (operationPerformed)
        {
            case "√x":
                Screen.Text = (Math.Sqrt(resultValue)).ToString();
                labelCurrentOperation.Text = "Square Root of " + resultLabel.Text;
                break;
            case "∛x":
                Screen.Text = (Math.Pow(resultValue,(1.0/3.0))).ToString();
                labelCurrentOperation.Text = "Cube Root of " + resultLabel.Text;
                break;
            case "1/x":
                Screen.Text = (1/resultValue).ToString();
                labelCurrentOperation.Text = "1/" + resultLabel.Text;
                break;
            case "x²":
                Screen.Text = (Math.Pow(resultValue,2)).ToString();
                labelCurrentOperation.Text = "Square of " + resultLabel.Text;
                break;
            case "x³":
                Screen.Text = (Math.Pow(resultValue,3)).ToString();
                labelCurrentOperation.Text = "Cube of " + resultLabel.Text;
                break;
            case "10/x":
                Screen.Text = (10/resultValue).ToString();
                labelCurrentOperation.Text = "10/" + resultLabel.Text;
                break;

            default:
                break;
        }

        isOperationPerformed = true;
        operationRadio.Checked = isOperationPerformed;
    }
}