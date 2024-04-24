using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance1
{
    public class StudentDetails:PersonalDetails
    {
        //Field
        private static int s_registerNumber=1000;
        //Properties
        public string RegisterNumber{get;}
        public string Standard{get;set;}
        public string Branch{get;set;} 
        public int AcadamicYear{get;set;}

        //Constructor
        public StudentDetails(string name,string fatherName,long phone ,string mail,DateTime dob,Gender gender,string standard,string branch,int acadamicYear):base(name,fatherName,phone ,mail,dob,gender)
        {
            s_registerNumber++;
            RegisterNumber="SID"+s_registerNumber;
            Standard=standard;
            Branch=branch;
            AcadamicYear=acadamicYear;
        }//Constructor ends

        //Methods
        public void ShowStudentInfo()
        {
            Console.WriteLine($"| Name | FatherName | Phone | Mail | DOB | Gender | Standard | Branch | AcadamicYear |");
            Console.WriteLine($"| {Name} | {FatherName} | {Phone} | {Mail} | {DOB} | {Gender} | {Standard}  | {Branch} | {AcadamicYear} | ");
        }//Methods ends
    }
}