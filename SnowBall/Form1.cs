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

        /// <summary>
        /// Counter to Handle the first Click to make the ExtraForDebt textbox and label dissapear
        /// </summary>
        int NextDebtButtonClick = 0;

        /// <summary>
        /// Debt dictionary for all input to go to.
        /// </summary>
        DebtDictionary NewDebtDict;

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBoxesEmpty())
            {
                MessageBox.Show("Please enter a value in each field");
            }
            else
            {
                try
                { 
                    ++NextDebtButtonClick;

                    string NewDebtName;
                    double NewDebtAmt, NewDebtMinPymnt;
                    ConvertValuesFromTextBoxes(out NewDebtName, out NewDebtAmt, out NewDebtMinPymnt);

                    //Switch to handle data from form, should be special for the first click
                    switch (NextDebtButtonClick)
                    {
                         
                        case 1:

                            InitializeFirstDebt(NewDebtName, NewDebtAmt, NewDebtMinPymnt);

                            break;

                        default:

                            AddNewDebt(NewDebtName, NewDebtAmt, NewDebtMinPymnt);

                            break;
                    }
                }
                //Catch all errors and reports. 
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        /// <summary>
        /// Adds input from form to DebtDictionary and resets form. 
        /// </summary>
        /// <param name="NewDebtName"></param>
        /// <param name="NewDebtAmt"></param>
        /// <param name="NewDebtMinPymnt"></param>
        private void AddNewDebt(string NewDebtName, double NewDebtAmt, double NewDebtMinPymnt)
        {
            var OtherNewDebt = new Debt(NewDebtName, NewDebtAmt, NewDebtMinPymnt);
            NewDebtDict.Add(NewDebtAmt, OtherNewDebt);

            ResetForm();
        }

        /// <summary>
        /// Adds input from form to DebtDictionary, resets form, and Hide extra for debt textbox/label.
        /// </summary>
        /// <param name="NewDebtName"></param>
        /// <param name="NewDebtAmt"></param>
        /// <param name="NewDebtMinPymnt"></param>
        private void InitializeFirstDebt(string NewDebtName, double NewDebtAmt, double NewDebtMinPymnt)
        { 
            var NewDebt = new Debt(NewDebtName, NewDebtAmt, NewDebtMinPymnt);
            NewDebtDict = new DebtDictionary((double.Parse(ExtraForDebtTextBox.Text)));
            NewDebtDict.Add(NewDebtAmt, NewDebt);

            ResetForm();

            HideExtraForDebt();
        }

        /// <summary>
        /// Makes extra for debt label/textbox  invisible
        /// </summary>
        private void HideExtraForDebt()
        { 
            ExtraForDebtLabel.Visible = false;
            ExtraForDebtTextBox.Visible = false;
        }

        /// <summary>
        /// Clears the text boxes for the next debt. 
        /// </summary>
        private void ResetForm()
        {
            NameTextBox.ResetText();
            AmountTextBox.ResetText();
            MinimumPaymentTextBox.ResetText();
        }

        /// <summary>
        ///  Pulls all of the values from the form and assigns them to variables 
        /// </summary>
        /// <param name="NewDebtName"></param>
        /// <param name="NewDebtAmt"></param>
        /// <param name="NewDebtMinPymnt"></param>
        private void ConvertValuesFromTextBoxes(out string NewDebtName, out double NewDebtAmt, out double NewDebtMinPymnt)
        {
            NewDebtName = NameTextBox.Text.ToString();
            NewDebtAmt = double.Parse(AmountTextBox.Text);
            NewDebtMinPymnt = double.Parse(MinimumPaymentTextBox.Text);
        }

        /// <summary>
        /// Checks to see if each text box is empty
        /// </summary>
        /// <returns></returns>
        private bool TextBoxesEmpty()
        {
            return NameTextBox.Text == "" || AmountTextBox.Text == "" || MinimumPaymentTextBox.Text == "" || ExtraForDebtTextBox.Text == "";
        }

        private void FinishedButton_Click(object sender, EventArgs e)
        {
            if (TextBoxesEmpty())
            {
                MessageBox.Show("Please enter a value in each field");
            }
            else
            {
                try
                {
                    string NewDebtName;
                    double NewDebtAmt, NewDebtMinPymnt;
                    ConvertValuesFromTextBoxes(out NewDebtName, out NewDebtAmt, out NewDebtMinPymnt);

                    AddNewDebt(NewDebtName, NewDebtAmt, NewDebtMinPymnt);

                    ResetForm();

                    //Call function in DebtDictionary to calculate and return final output. 
                    MessageBox.Show(NewDebtDict.DictionaryCalc().ToString());
                }
                //Catch all errors and report
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }           
        }
        private void AmtBox_KeyPress(object sender, KeyPressEventArgs InputKey)
        {
            ValidateInput(InputKey);
        }
        private void MonthlyPayment_KeyPress(object sender, KeyPressEventArgs InputKey)
        {
            ValidateInput(InputKey);
        }
        private void ExtraMoneyTxtBox_KeyPress(object sender, KeyPressEventArgs InputKey)
        {
            ValidateInput(InputKey);
        }

        /// <summary>
        /// Check every keypress in textbox to ensure validity
        /// </summary>
        /// <param name="InputKey"></param>
        private void ValidateInput(KeyPressEventArgs InputKey)
        {
            if (MultipleDecimals(InputKey.KeyChar) || IsInvalidCharacter(InputKey.KeyChar))
            {
                InputKey.Handled = true;
                MessageBox.Show("Please enter a valid value");
            }
        }

        /// <summary>
        /// Checks for non-numeric characters but allows for backspace and a decimal
        /// </summary>
        /// <param name="chr"></param>
        /// <returns></returns>
        private static bool IsInvalidCharacter(char chr)
        {
            return !Char.IsDigit(chr) && chr != 8 && chr != 46;
        }

        /// <summary>
        /// Checks for multiple decimals
        /// </summary>
        /// <param name="chr"></param>
        /// <returns></returns>
        private bool MultipleDecimals(char chr)
        {
            return chr == 46 && AmountTextBox.Text.IndexOf('.') != -1;
        }     
    }
}
