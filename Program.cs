using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDemo.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Payroll calculation is here .");
            Staff staff1 = new Staff();
            staff1.Name = "U Aye Mya";
            staff1.Age = 18;
            staff1.Type = "Full_Time staff";
            staff1.Phno = 09791490087;
            staff1.address = "No(120) Upper Main Road, Mawlamyine";
            staff1.Role = "Manager";
            staff1.Email = "ayemya@gmail.com";
            staff1.BaseSalary = 300000;
            staff1.ShowStaffDetailInfo();
            IFulltimePay payroll = new FulltimePay();
            double monthdalary = payroll.CalculatePayrollFulltime(30000, 30, 30, 10000, 0);
            Console.WriteLine("Payment " + monthdalary);
            Staff staff2 = new Staff();
            staff2.Name ="Aung Aung";
            staff2.Age =23;
            staff2.Type ="Part_Time Staff";
            staff2.Phno =09234567854;
            staff2.address ="Maunggan";
            staff2.Role ="Sale";
            staff2.Email ="aungaung@gmail.com";
            staff2.BaseSalary =180000;
            staff2.ShowStaffDetailInfo();



            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        
    }
    }
}
