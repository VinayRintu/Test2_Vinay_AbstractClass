using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Vinay_AbstractClass
{
    public  class Tax_Calculation:  Employee
    {
        double ta, da, tax, bonus,netSalary;
        Double EmployeeSalary;
        public override void SetSalary()
        {
            Console.WriteLine("Enter Employee Salary");
            EmployeeSalary = int.Parse(Console.ReadLine());
        }
        public void CalculateTax()
        {
            if(EmployeeSalary <= 1000)
            {
                ta = EmployeeSalary * 0.1;
                da = EmployeeSalary * 0.2;
                tax = EmployeeSalary * 0.2;
                bonus = EmployeeSalary * 0.3;
                netSalary = EmployeeSalary + ta + da - tax + bonus;
            }
            else
            {
                ta = EmployeeSalary * 0.2;
                da = EmployeeSalary * 0.3;
                tax = EmployeeSalary * 0.4;
                bonus = EmployeeSalary * 0.3;
                netSalary = EmployeeSalary + ta + da - tax + bonus;
            }
            Console.WriteLine("________________________");
            Console.WriteLine("TA : "+ta);
            Console.WriteLine("DA : " + da);
            Console.WriteLine("TAx : " + tax);
            Console.WriteLine("BONUS : " + bonus);
            Console.WriteLine("BAsic Salary : "+EmployeeSalary);
            Console.WriteLine("NET SALARY : " + netSalary);
        }
    }
    
}
