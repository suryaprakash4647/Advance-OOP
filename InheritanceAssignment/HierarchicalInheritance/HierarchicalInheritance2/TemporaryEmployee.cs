using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance2
{
    public class TemporaryEmployee: SalaryInfo
    {
        private static int s_employeeID=1000;
        public string EmployeeID{get;}
        public string EmployeeType{get;set;}
        public double DA{get;set;}
        public double HRA{get;set;}
        public double PF{get;set;}
        public double TotalSalary{get;set;}
        public TemporaryEmployee(double basicSalary, int month, string employeeType):base(basicSalary,month)
        {
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            EmployeeType=employeeType;
        }
        public void ShowSalary2()
        {
            DA=BasicSalary*0.0015;
            HRA=BasicSalary*0.0013;
            PF=BasicSalary*0.001;
            TotalSalary=BasicSalary+DA+HRA-PF;
            Console.WriteLine($"Your Salary is : {TotalSalary} - Temporary.");
        }
    }
}