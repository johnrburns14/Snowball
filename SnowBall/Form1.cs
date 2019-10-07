using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowBall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void NameLabel_Click(object sender, EventArgs e)
        {

        }
        private void AmtBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Counter to Handle the first Click to make the ExtraForDebt textbox and label dissapear. 
        int NextDebtButtonClick = 0;

        //Create Debt dictionary
        DebtDictionary NewDebtDict = new DebtDictionary();

        private void Button1_Click(object sender, EventArgs e)
        {
            //Check for empty Text Boxes and display message if found. 
            if (NameTextBox.Text == "" || AmountTextBox.Text == "" || MinimumPaymentTextBox.Text == "" || ExtraForDebtTextBox.Text == "")
            {
                MessageBox.Show("Please enter a value in each field");
            }
            else
            {
                try
                {
                    //Increment button click
                    ++NextDebtButtonClick;

                    //Pulling all of the values from the form and assigning them to a variable 
                    string NewDebtName = NameTextBox.Text.ToString();
                    double NewDebtAmt = double.Parse(AmountTextBox.Text);
                    double NewDebtMinPymnt = double.Parse(MinimumPaymentTextBox.Text);

                    //Switch to handle data from form, should be special for the first click then different for every other one
                    switch (NextDebtButtonClick)
                    {
                        //This executes on the first debt item input. 
                        case 1:
                            //Makes a new debt object and assigns the variables from text box above. Sets the ExtraForDebt variable in DebtDictionary class. Adds to the DebtDictionary. 
                            var NewDebt = new Debt(NewDebtName, NewDebtAmt, NewDebtMinPymnt);
                            NewDebtDict.ExtraForDebt = (double.Parse(ExtraForDebtTextBox.Text));
                            NewDebtDict.Add(NewDebtAmt, NewDebt);
                            
                            //Clears the text boxes for the next debt. 
                            NameTextBox.ResetText();
                            AmountTextBox.ResetText();
                            MinimumPaymentTextBox.ResetText();

                            //Removes the ExtraForDebt label and text box. 
                            ExtraForDebtLabel.Visible = false;
                            ExtraForDebtTextBox.Visible = false;
                            
                            //End
                            break;

                        //Handles all other debt input items after the first. 
                        default:
                            //Makes a new debt object and adds to the DebtDictionary
                            var OtherNewDebt = new Debt(NewDebtName, NewDebtAmt, NewDebtMinPymnt);
                            NewDebtDict.Add(NewDebtAmt, OtherNewDebt);
                            
                            //Clear Text boxes for next debt. 
                            NameTextBox.ResetText();
                            AmountTextBox.ResetText();
                            MinimumPaymentTextBox.ResetText();
                            
                            //End
                            break;
                    }
                }
                //Catch all errors and reports. 
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
        
        private void FinishedButton_Click(object sender, EventArgs e)
        {
            //Check for empty Text Boxes and display message if found.
            if (NameTextBox.Text == "" || AmountTextBox.Text == "" || MinimumPaymentTextBox.Text == "" || ExtraForDebtTextBox.Text == "")
            {
                MessageBox.Show("Please enter a value in each field");
            }
            else
            {
                try
                {
                    //Pulling all of the values from the form and assigning them to a variable
                    string NewDebtName = NameTextBox.Text.ToString();
                    double NewDebtAmt = double.Parse(AmountTextBox.Text);
                    double NewDebtMinPymnt = double.Parse(MinimumPaymentTextBox.Text);

                    //Makes a new debt object and adds to the DebtDictionary
                    var OtherNewDebt = new Debt(NewDebtName, NewDebtAmt, NewDebtMinPymnt);
                    NewDebtDict.Add(NewDebtAmt, OtherNewDebt);

                    //Clear text boxes for the next debt. 
                    NameTextBox.ResetText();
                    AmountTextBox.ResetText();
                    MinimumPaymentTextBox.ResetText();

                    //Call function in DebtDictionary to calculate and return final output. 
                    MessageBox.Show(NewDebtDict.DictionaryCalc().ToString());
                }
                //Catch errors and report
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }           
        }
        //Check inputs to AmountTextBox and catch any non numeric inputs with the exception of decimals and show a message if bad input detected. 
        private void AmtBox_KeyPress(object sender, KeyPressEventArgs InputKey)
        {
            Char chr = InputKey.KeyChar;

            //Catches multiple decimals. 
            if (chr == 46 && AmountTextBox.Text.IndexOf('.') != -1)
            {
                InputKey.Handled = true;
                MessageBox.Show("Please enter a valid value");
            }
            //Catches non-numeric input and allows for backspacing and decimals.
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                InputKey.Handled = true;
                MessageBox.Show("Please enter a valid value");
            }
        }
        //Check inputs to MinimumPaymentTextBox and catch any non numeric inputs with the exception of decimals and show a message if bad input detected.
        private void MonthlyPayment_KeyPress(object sender, KeyPressEventArgs InputKey)
        {
            Char chr = InputKey.KeyChar;

            //Catches multiple decimals. 
            if (chr == 46 && MinimumPaymentTextBox.Text.IndexOf('.') != -1)
            {
                InputKey.Handled = true;
                MessageBox.Show("Please enter a valid value");
            }
            //Catches non-numeric input and allows for backspacing and decimals.
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                InputKey.Handled = true;
                MessageBox.Show("Please enter a valid value");
            }
        }
        //Check inputs to ExtraForDebtTextBox and catch any non numeric inputs with the exception of decimals and show a message if bad input detected.
        private void ExtraMoneyTxtBox_KeyPress(object sender, KeyPressEventArgs InputKey)
        {
            Char chr = InputKey.KeyChar;

            //Catches multiple decimals. 
            if (chr == 46 && ExtraForDebtTextBox.Text.IndexOf('.') != -1)
            {
                InputKey.Handled = true;
                MessageBox.Show("Please enter a valid value");
            }
            //Catches non-numeric input and allows for backspacing and decimals.
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                InputKey.Handled = true;
                MessageBox.Show("Please enter a valid value");
            }
        }
    }
}
