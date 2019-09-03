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
        

        //Counter to Handle the first Click
        int Btn1Click = 0;

        //Create Debt dictionary
        DebtDictionary NewDebtDict = new DebtDictionary();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void Button1_Click(object sender, EventArgs e)
        {
            //Increment button click
            ++Btn1Click;

            //Pulling all of the values from the form and assigning them to a variable 
            string NewDebtName = NameBox.Text.ToString();
            double NewDebtAmt = double.Parse(AmtBox.Text);
            double NewDebtMinPymnt = double.Parse(MonthlyPayment.Text);

            //Switch to handle data from form, should be special for the first click then different for every other one
            switch (Btn1Click)
            {
                case 1:
                    
                    var NewDebt = new Debt(NewDebtName, NewDebtAmt, NewDebtMinPymnt);
                    NewDebt.ExtraForDebt = (double.Parse(ExtraMoneyTxtBox.Text));
                    NewDebtDict.Add(NewDebtAmt, NewDebt);
                    NameBox.ResetText();
                    AmtBox.ResetText();
                    MonthlyPayment.ResetText();
                    ExtraDebtMoney.Visible = false;
                    ExtraMoneyTxtBox.Visible = false;
                    break;

                default:
                    var OtherNewDebt = new Debt(NewDebtName, NewDebtAmt, NewDebtMinPymnt);
                    NewDebtDict.Add(NewDebtAmt, OtherNewDebt);
                    NameBox.ResetText();
                    AmtBox.ResetText();
                    MonthlyPayment.ResetText();
                    break;

            }
            
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void FinishedButton_Click(object sender, EventArgs e)
        {
            string NewDebtName = NameBox.Text.ToString();
            double NewDebtAmt = double.Parse(AmtBox.Text);
            double NewDebtMinPymnt = double.Parse(MonthlyPayment.Text);
            var OtherNewDebt = new Debt(NewDebtName, NewDebtAmt, NewDebtMinPymnt);
            NewDebtDict.Add(NewDebtAmt, OtherNewDebt);
            NameBox.ResetText();
            AmtBox.ResetText();
            MonthlyPayment.ResetText();

            foreach(var value in NewDebtDict.InternalDebtDictionary.Values)
            {
                foreach(var ListVal in value)
                {
                    MessageBox.Show(ListVal.DebtName.ToString());
                }
               
            }
            
            
        }

        private void AmtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
