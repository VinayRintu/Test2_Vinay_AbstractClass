using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Vinay_AbstractClass
{
    public abstract class Employee
    {
        int EmployeeId;
        string? EmployeeName;
        string? Address;      

        public abstract void SetSalary();
        public void SetEmployeeDetails()
        {
            Console.WriteLine("Enter Employee ID");
            EmployeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter Employee Address");
            Address = Console.ReadLine();                       
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("_______________");
            Console.WriteLine("Employee ID : "+EmployeeId);
            Console.WriteLine("Employee Name : "+EmployeeName);
            Console.WriteLine("Employee Address : "+Address);            
        }
    }
}
