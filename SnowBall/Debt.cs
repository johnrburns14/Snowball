using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowBall
{
    public class Debt
    {
        public string DebtName { get; set; }
        public double DebtAmount { get; set; } 
        public double DebtMinimumPayment { get; set; }
        public Debt(string debtName, double debtAmount, double debtMinimumPayment)
        {
            DebtName = debtName;
            DebtAmount = debtAmount;
            DebtMinimumPayment = debtMinimumPayment;
        }
       
    }
}
