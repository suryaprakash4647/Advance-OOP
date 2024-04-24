using System;
namespace MultilevelInheritance2;
public class Program
{
    public static void Main(string[] args)
    {
        DepartmentDetails department=new DepartmentDetails("ECE","B.tech");
        RackInfo rack=new RackInfo(department.DepartmentName,department.Degree,1,3);
        BookInfo books=new BookInfo(department.DepartmentName,department.Degree,rack.RackNumber,rack.ColumnNumber,"movie","john",200);
        books.DisplayInfo();
    }
}
