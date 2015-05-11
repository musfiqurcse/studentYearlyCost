using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class Employee
    {
        public string employeeName;
        public double amount;
        public double rent;
        public double medicalAllowence;


        public double CalculateSalary()
        {
            return (amount + (amount * rent) / 100 + (amount * medicalAllowence) / 100); 
            
         }
    }
}
