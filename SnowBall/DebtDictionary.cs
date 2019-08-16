using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowBall
{
    public class DebtDictionary
    {
        //Create Dictionary for form values to go into
        public SortedDictionary<double, List<Debt>> InternalDebtDictionary = new SortedDictionary<double, List<Debt>>();

        public void Add(double DbtAmt, Debt NewDbt)
        {
            if (this.InternalDebtDictionary.ContainsKey(DbtAmt))
            {
                List<Debt> list = this.InternalDebtDictionary[DbtAmt];
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
    }
}
