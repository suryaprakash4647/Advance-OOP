using System;
namespace HierarchicalInheritance1;
class Program 
{
    public static void Main(string[] args)
    {
        PersonalInfo person1=new PersonalInfo("rajini","kanth",new DateTime(2000,10,10),"987654321",Gender.Male,"rajinikanth@gmail.com");
        Teacher teacher=new Teacher(person1.Name,person1.FatherName,person1.DOB,person1.Phone,person1.Gender,person1.Mail,"cse","data science","BE",6,new DateTime(2000,09,09));
        StudentInfo student=new StudentInfo(person1.Name,person1.FatherName,person1.DOB,person1.Phone,person1.Gender,person1.Mail,"BE","EEE",6);
        PrincipalInfo principal=new PrincipalInfo(person1.Name,person1.FatherName,person1.DOB,person1.Phone,person1.Gender,person1.Mail,"BE",10,new DateTime(2000,10,10));


        teacher.ShowDetails();
        student.ShowDetails();
        principal.ShowDetails();
    }
}
