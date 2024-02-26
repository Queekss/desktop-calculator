namespace FinalCalc;
using org.matheval;
using System.Text.RegularExpressions;
using System.IO;


public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }


    // Global variable to store calculation under the hood
    public string calculation = "";



    //Method to sanitise inputs prior to saving/calculating
    public string Sanitise(string input)
    {
        input = Regex.Replace(input, @"[^0-9+\-*/%√^().]", "");
        return input;
    }

    //Event handler to prevent users from using keyboard input
    private void resultBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = true;
    }


    //Shared event handler for controls that do not require "translation" i.e +
    private void button1_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        resultBox.Text += button.Text;
        calculation += button.Text;
    }
    //Shared event handler for controls that require "translation"
    private void buttonPercent_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;

        switch (button.Text)
        {
            case "√":
                resultBox.Text += button.Text + "(";
                calculation += "sqrt(";
                break;
            case "%": // Regex to capture the number prior to the selection of %, and convert to decimal equivalent
                resultBox.Text = Sanitise(resultBox.Text);
                Regex regex = new Regex(@".*?([0-9]+)$");
                Match match = regex.Match(resultBox.Text);
                if (match.Success)
                {
                    string matchingNumber = match.Groups[1].Value;
                    string newDecimal = (System.Convert.ToDecimal(matchingNumber) / 100).ToString();
                    resultBox.Text = resultBox.Text.Remove(resultBox.Text.Length - matchingNumber.Length);
                    calculation = calculation.Remove(calculation.Length - matchingNumber.Length);
                    resultBox.Text += newDecimal;
                    calculation += newDecimal;
                }
                break;


        }

    }

    //Event handler to calculate expression
    private void buttonEquals_Click(object sender, EventArgs e)
    {
        calculation = Sanitise(calculation);
       // MessageBox.Show(calculation);


        //Check for empty calculation

        if (String.IsNullOrEmpty(calculation))
        {
            MessageBox.Show("No calculation has been inputted.", "Empty Calculation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        try
        {   //Expression evaluation, using org.matheval library
            Expression expression = new Expression(calculation);
            Object result = expression.Eval();
            resultBox.Clear();
            resultBox.Text = result.ToString();
            calculation += $"={resultBox.Text}";
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred when trying to calculate expression. Ensure only valid characters are entered.", "Error in Calculation", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


    }

    //Event handler for C  and CE
    private void buttonClear_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        if (button.Text == "C")
        {
            resultBox.Clear();
            calculation = "";
        }
        else //Removes last character, as the CE symbol
        {
            if(resultBox.Text.Length > 0 && calculation.Length > 0)
            {
                //if the last character of the resultBoxText is a sqrt symmvol, remove all sqrt characters from the sqrt variable
                if (resultBox.Text[resultBox.Text.Length - 1].ToString() == "√")
                {
                    //Regex for sqrt
                    Regex regex = new Regex(@".*?([sqrt]{1,4})$");
                    Match match = regex.Match(calculation);
                    //Number of characters within resultBox and calculation differ , so when removign the "√" symbol in resultBox, have to remove "sqrt" in calc
                    resultBox.Text = resultBox.Text.Remove(resultBox.Text.Length - 1);
                    calculation = calculation.Remove(calculation.Length - match.Groups[1].Value.Length);
                }
                else
                {
                    resultBox.Text = resultBox.Text.Remove(resultBox.Text.Length - 1);
                    calculation = calculation.Remove(calculation.Length - 1);
                }

            }
            else //As CE uses indexing to function, this catches the potential error of user clearing outside the defined index; uses if else todeal with more gracefully
            {
                MessageBox.Show("Nothing to clear. Do not CE if text box is empty", "CE Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

    }

    private void buttonSave_Click(object sender, EventArgs e)
    {

        string filepath = @"C:\Users\Eunic\hi.txt";
        calculation = Sanitise(calculation);
        string entry = $"{calculation} {DateTime.Now}";
        //Erro handling to catch all IO errors
        try
        {
            File.AppendAllText(filepath, entry + Environment.NewLine);
            string message = $"Equation saved successfully:\n{calculation}";
            MessageBox.Show(message, "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information); //Shows message in body and an info icon
        }
        catch (IOException ex)
        {
            MessageBox.Show($"File Error: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }

    private void buttonRetrieve_Click(object sender, EventArgs e)
    {
        string filepath = @"C:\Users\hi.txt";
        string record = String.Empty;
        //Error handling to catch all IO errors
        try
        {
            if (File.Exists(filepath))
            {
                foreach (string line in File.ReadLines(filepath))
                {
                    //Error handling; if line not found
                    if (line.Contains(resultBox.Text + " ")) // space as <calculation> <date>, otherwise calculations sharing numbers may be displayed
                    {
                        record = line;
                        break;

                    }
                }

                if (!(record == String.Empty))
                {
                    MessageBox.Show(record, "Equation Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Equation not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


            else
            {
                MessageBox.Show("Equation not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        catch (IOException ex)
        {
            MessageBox.Show($" File Retrieval Error: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }












    //Event handler for controls that require translation

}


