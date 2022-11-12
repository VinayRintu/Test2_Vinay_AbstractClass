// See https://aka.ms/new-console-template for more information
using Test2_Vinay_AbstractClass;

Console.WriteLine("Hello, World!");


Tax_Calculation objectTax=new Tax_Calculation();
objectTax.SetEmployeeDetails();
objectTax.DisplayEmployeeDetails();
objectTax.SetSalary();
objectTax.CalculateTax();
