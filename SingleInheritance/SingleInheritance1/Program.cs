using System;
namespace SingleInheritance1;
public class Program
{
    public static void Main(string[] args)
    {
        //Objects
        PersonalDetails personal=new PersonalDetails("Vijay","Surya",9876543210,"sdfghgfd@gmail.com",new DateTime(2000,10,10),Gender.Male);
        StudentDetails student=new StudentDetails(personal.Name,personal.FatherName,personal.Phone,personal.Mail,personal.DOB,personal.Gender, "10","science",2023);
        //Method call 
        student.ShowStudentInfo();
    }
    
}
