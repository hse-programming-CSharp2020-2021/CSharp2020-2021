using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library3
{
    public class PartTimeEmployee : Employee
    {
        int workingDays;
        public PartTimeEmployee(string name, decimal basepay, int workingDays)
            : base (name, basepay)
        {
            this.workingDays = workingDays;
        }
        public override decimal CalculatePay()
        {
            return basepay / 25 * workingDays;
        }
    }
}
