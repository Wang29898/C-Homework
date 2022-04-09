using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDemo.cs
{
    public interface IFulltimePay
    {
        double CalculatePayrollFulltime(int basesalary, int workingDays, int attday, int benefit, int deduction);
        
    }
}
