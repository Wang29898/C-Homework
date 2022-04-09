using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDemo.cs
{
    public class PartimePay : IParttime
    {
        public double CalculatePayrollParttime(int amountofperhour, int workinghours, int benefit)
        {
            double resulttwo = (amountofperhour * workinghours);
            return resulttwo;
        }
   
    
}
