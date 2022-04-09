using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDemo.cs
{
    public class Staff : IShowDetail//Is-A relationship (OOD)
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }
        public long Phno { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public int BaseSalary { get; set; }
        public string address { get; set; }//has-A relationship(OOD)

        public void ShowStaffDetailInfo()
        {
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("Age :"+ Age);
            Console.WriteLine("Type of worker : "+Type);
            Console.WriteLine("Phone Number :" +Phno);
            Console.WriteLine("Role :" + Role);
            Console.WriteLine("Emial :" + Email);
            Console.WriteLine("Address :" + address);
            Console.WriteLine("BaseSalary :" + BaseSalary);
        }
    }
}
