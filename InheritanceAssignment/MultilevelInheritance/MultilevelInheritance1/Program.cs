using System;
namespace MultilevelInheritance1;
public class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo personal=new PersonalInfo("Vijay","Surya",9876543210,"sdyuyt@gmil.com",new DateTime(2000,12,20),Gender.Male);
        StudentInfo student=new StudentInfo(personal.Name,personal.FatherName,personal.Phone,personal.Mail,personal.DOB,personal.Gender,"10th","ECE",2019);  
        student.GetStudentInfo(student.Standard,student.Branch,student.AcadamicYear);
        student.ShowInfo();
        HSCDetails hSC=new HSCDetails(personal.Name,personal.FatherName,personal.Phone,personal.Mail,personal.DOB,personal.Gender,student.Standard,student.Branch,student.AcadamicYear,90,80,70);
        hSC.GetMarks();
        hSC.Calculate();
        hSC.ShowMarksheet();
    }
}
