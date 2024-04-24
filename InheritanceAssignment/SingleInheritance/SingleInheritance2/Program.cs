using System;
using SingleInheritance2;
namespace SinglInheritance2;
public class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo personal=new PersonalInfo("Vijay","Surya",9876543210,"sdyuyt@gmil.com",new DateTime(2000,12,20),Gender.Male);

       AccountInfo account=new AccountInfo(personal.Name,personal.FatherName,personal.Phone,personal.Mail,personal.DOB,personal.Gender,"Chennai","MBANK1000",1000);  
        Console.WriteLine("Updated Balance : "+account.Balance);
        account.Deposit(1000);
        account.Withdraw(200);
        account.ShowBalance();
    }
}
