using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance1
{
    public class StudentInfo:PersonalInfo
    {
        //StudentID, Degree, Department, semester
        private static int s_studentID=8000;
        public string StudentID{get;}
        public string Degree{get;set;}
        public string Department{get;set;}
        public int Semester{get;set;}
        
        public StudentInfo(string name,string fatherName,DateTime dob,string phone,Gender gender,string mail,string degree,string department,int semester):base(name,fatherName,dob,phone,gender,mail)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            Degree=degree;
            Department=department;
            Semester=semester;
            
        }
        public void ShowDetails()
        {
            Console.WriteLine($"| {Name} | {FatherName} | {DOB} | {Phone} | {Gender} | {Mail} | {Degree} | {Department} | {Semester} |");
        }
    }
}