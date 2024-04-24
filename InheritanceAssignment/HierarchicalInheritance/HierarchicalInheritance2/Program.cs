using System;
namespace HierarchicalInheritance2;
class Program
{
    public static void Main(string[] args)
    {
        SalaryInfo salary=new SalaryInfo(21500,15);
        PermanentEmployee perEmployee=new PermanentEmployee(salary.BasicSalary,salary.Month,"Permanent");
        TemporaryEmployee tempEmployee=new TemporaryEmployee(salary.BasicSalary,salary.Month,"Temporary");
        perEmployee.ShowSalary1();
        tempEmployee.ShowSalary2();
    }
}
