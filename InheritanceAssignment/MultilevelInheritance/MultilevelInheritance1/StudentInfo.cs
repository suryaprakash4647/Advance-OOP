using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance1
{
    public class StudentInfo:PersonalInfo
    {
        //Field
        private static int s_registerNumber=1000;
        //Properties
        public string RegisterNumber{get;}
        public string Standard{get;set;}
        public string Branch{get;set;} 
        public int AcadamicYear{get;set;}

        //Constructor
        public StudentInfo(string name,string fatherName,long phone ,string mail,DateTime dob,Gender gender,string standard,string branch,int acadamicYear):base(name,fatherName,phone ,mail,dob,gender)
        {
            s_registerNumber++;
            RegisterNumber="RNO"+s_registerNumber;
            Standard=standard;
            Branch=branch;
            AcadamicYear=acadamicYear;
        }//Constructor ends
        public StudentInfo(string name,string fatherName,long phone ,string mail,DateTime dob,Gender gender,string standard,string branch,int acadamicYear,string registerNumber):base(name,fatherName,phone ,mail,dob,gender)
        {
            RegisterNumber=registerNumber;
            Standard=standard;
            Branch=branch;
            AcadamicYear=acadamicYear;
        }//Constructor ends
        //Methods
        public void GetStudentInfo(string standard,string branch,int acadamicYear)
        {
            Console.WriteLine("Enter the standard : ");
            Standard=Console.ReadLine();
            Standard=standard;
            Console.WriteLine("Enter the  Branch  : ");
            Branch=Console.ReadLine();
            Branch=branch;
            Console.WriteLine("Enter the Acadamic Year : ");
            AcadamicYear=int.Parse(Console.ReadLine());
            AcadamicYear=acadamicYear;
        } 
        public void ShowInfo()
        {
            Console.WriteLine($"| Name | FatherName | Phone | Mail | DOB | Gender | Standard | Branch | AcadamicYear |");
            Console.WriteLine($"| {Name} | {FatherName} | {Phone} | {Mail} | {DOB} | {Gender} | {Standard}  | {Branch} | {AcadamicYear} | ");
        }
    }
}