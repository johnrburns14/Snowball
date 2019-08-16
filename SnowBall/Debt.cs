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
        public double DebtAmt { get; set; }
       
        public double DebtMinPayment { get; set; }
        public double ExtraForDebt { get; set; }

        public Debt(string DbtName, double DbtAmt, double DbtMinPymnt)
        {
            DebtName = DbtName;
            DebtAmt = DbtAmt;
            DebtMinPayment = DbtMinPymnt;
        }
       
    }
}
