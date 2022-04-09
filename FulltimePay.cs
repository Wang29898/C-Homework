using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDemo.cs
{
    public class FulltimePay : IFulltimePay
    {
        public double CalculatePayrollFulltime(int basesalary, int workingDays, int attday, int benefit, int deduction)
        {
            double result = ((basesalary / workingDays) * attday) + benefit - deduction;
            return result;
        }
        
    }
}
