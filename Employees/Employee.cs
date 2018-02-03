using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    partial class Employee
    {
        //variables
        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string empSSN;

   

        //methods

        public void GiveBonus(float amount)
        {
            Pay += amount;
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID:{0}", ID);
            Console.WriteLine("Age:{0}", Age);
            Console.WriteLine("Pay: {0}", Pay);

        }


    }
}
