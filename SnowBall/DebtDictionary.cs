using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowBall
{
    public class DebtDictionary
    {
        //ExtraForDebt exist here so it can be used to handle the final output with the DictionaryCalc function below. 
        public double ExtraForDebt { get; set; }

        //Create Dictionary for form values to go into
        public SortedDictionary<double, List<Debt>> InternalDebtDictionary = new SortedDictionary<double, List<Debt>>();

        //Function to add inputs from form to the Dicttionary created above by checking for an already existing key and adding to the List if a duplicate Key. 
        public void Add(double DebtAmount, Debt NewDebt)
        {
            if (InternalDebtDictionary.ContainsKey(DebtAmount))
            {
                List<Debt> list = InternalDebtDictionary[DebtAmount];
                if (list.Contains(NewDebt) == false)
                {
                    list.Add(NewDebt);
                }
            }
            else
            {
                List<Debt> list = new List<Debt>();
                list.Add(NewDebt);
                this.InternalDebtDictionary.Add(DebtAmount, list);
            }
        }
        
        //Function to create a finalized output. 
        public StringBuilder DictionaryCalc()
        {
            double monthsTotal = 0;
            StringBuilder OutputString = new StringBuilder();
            OutputString.AppendLine("Pay your debts in the following order:");

            //Go through every item in the DebtDictionary and every Debt in the List. Starts with determining if previous months have been paid and subtracting the monthly minimum payments from the debt total
            //before more calculations. Second calculate how much should be paid monthly. Third calculate how many months to pay off the debt. Adds calculations and debt information the output. Fourth take the 
            //now freed up money from the debt that is paid off and add it to ExtraForDebt. Finally account for months you spent paying off the current debt so the next debt can be properly calculated. 
            foreach (var value in InternalDebtDictionary.Values)
            {
                foreach(var ListVal in value)
                {
                    ListVal.DebtAmount -= monthsTotal * ListVal.DebtMinimumPayment;
                    double MonthlyPayment = ExtraForDebt + ListVal.DebtMinimumPayment;
                    double MonthsToPay =Math.Ceiling(ListVal.DebtAmount / MonthlyPayment);
                   
                    OutputString.AppendLine(ListVal.DebtName + " should take " + MonthsToPay + " months to pay off, and you should be paying $" + MonthlyPayment + " per month.");

                    ExtraForDebt += ListVal.DebtMinimumPayment;
                    monthsTotal += MonthsToPay;
                }
            }
            return OutputString;
        }
    }
}
