using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowBall
{
    public class DebtDictionary
    {
        private double _extraForDebt { get; set; }

        /// <summary>
        /// Dictionary for form values to go into
        /// </summary>
        private SortedDictionary<double, List<Debt>> _internalDebtDictionary = new SortedDictionary<double, List<Debt>>();

        public DebtDictionary(double extraForDebt)
        {
            _extraForDebt = extraForDebt;
        }

        /// <summary>
        /// Function to add inputs from form to the Dicttionary by checking for an already existing key and adding to the List if a duplicate Key. 
        /// </summary>
        /// <param name="DebtAmount"></param>
        /// <param name="NewDebt"></param>
        public void Add(double DebtAmount, Debt NewDebt)
        {
            if (_internalDebtDictionary.ContainsKey(DebtAmount))
            {
                List<Debt> list = _internalDebtDictionary[DebtAmount];
                if (list.Contains(NewDebt) == false)
                {
                    list.Add(NewDebt);
                }
            }
            else
            {
                List<Debt> list = new List<Debt>{NewDebt};
                _internalDebtDictionary.Add(DebtAmount, list);
            }
        }

        /// <summary>
        /// Creates and returns finalized output.
        /// </summary>
        /// <returns></returns>
        public StringBuilder DictionaryCalc()
        {
            double monthsTotal = 0;
            StringBuilder OutputString = new StringBuilder();
            OutputString.AppendLine("Pay your debts in the following order:");

            //Go through every item in the DebtDictionary and every Debt in the List. Starts with determining if previous months have been paid and subtracting the monthly minimum payments from the debt total
            //before more calculations. Second calculate how much should be paid monthly. Third calculate how many months to pay off the debt. Adds calculations and debt information the output. Fourth take the 
            //now freed up money from the debt that is paid off and add it to ExtraForDebt. Finally account for months you spent paying off the current debt so the next debt can be properly calculated. 
            foreach (var listOfDebtObjects in _internalDebtDictionary.Values)
            {
                foreach(var debtObject in listOfDebtObjects)
                {
                    debtObject.DebtAmount -= monthsTotal * debtObject.DebtMinimumPayment;
                    double MonthlyPayment = _extraForDebt + debtObject.DebtMinimumPayment;
                    double MonthsToPay =Math.Ceiling(debtObject.DebtAmount / MonthlyPayment);
                   
                    OutputString.AppendLine(debtObject.DebtName + " should take " + MonthsToPay + " months to pay off, and you should be paying $" + MonthlyPayment + " per month.");

                    _extraForDebt += debtObject.DebtMinimumPayment;
                    monthsTotal += MonthsToPay;
                }
            }
            return OutputString;
        }
    }
}
