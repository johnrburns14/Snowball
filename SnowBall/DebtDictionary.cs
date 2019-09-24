using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowBall
{
    public class DebtDictionary
    {

        public double ExtraForDebt { get; set; }

        //Create Dictionary for form values to go into
        public SortedDictionary<double, List<Debt>> InternalDebtDictionary = new SortedDictionary<double, List<Debt>>();

        public void Add(double DbtAmt, Debt NewDbt)
        {
            if (InternalDebtDictionary.ContainsKey(DbtAmt))
            {
                List<Debt> list = InternalDebtDictionary[DbtAmt];
                if (list.Contains(NewDbt) == false)
                {
                    list.Add(NewDbt);
                }
            }
            else
            {
                List<Debt> list = new List<Debt>();
                list.Add(NewDbt);
                this.InternalDebtDictionary.Add(DbtAmt, list);
            }
        }

        public StringBuilder DictionaryCalc()
        {
            double monthsTotal = 0;
            StringBuilder OutputString = new StringBuilder();
            OutputString.AppendLine("Pay your debts in the following order:");

            foreach (var value in InternalDebtDictionary.Values)
            {
                foreach(var ListVal in value)
                {
                    ListVal.DebtAmt -= monthsTotal * ListVal.DebtMinPayment;
                    double MonthlyPayment = ExtraForDebt + ListVal.DebtMinPayment;
                    double MonthsToPay =Math.Ceiling(ListVal.DebtAmt / MonthlyPayment);
                   
                    OutputString.AppendLine(ListVal.DebtName + " should take " + MonthsToPay + " months to pay off, and you should be paying $" + MonthlyPayment + " per month.");

                    ExtraForDebt += ListVal.DebtMinPayment;
                    monthsTotal += MonthsToPay;
                }
            }




            return OutputString;

        }
    }
}
