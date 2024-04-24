using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance1
{
    public class Teacher:PersonalInfo
    {
        //TeacherID, Department, Subject teaching, Qualification, YearOfExperience, DateOfJoining
        private static int s_teacherID=4000;
        public string TeacherID{get;}
        public string Department{get;set;}
        public string SubjectTeaching{get;set;}
        public string Qualification{get;set;}
        public int YearOfExperience{get;set;}
        public DateTime DateOfJoining{get;set;}

        public Teacher(string name,string fatherName,DateTime dob,string phone,Gender gender,string mail,string department,string subjectTeaching,string qualification,int yearOfExperience,DateTime dateOfJoining):base(name,fatherName,dob,phone,gender,mail)
        {
            s_teacherID++;
            TeacherID="TID"+s_teacherID;
            Department=department;
            SubjectTeaching=subjectTeaching;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Department       :"+Department);
            Console.WriteLine("SubjectTeaching  :"+SubjectTeaching);
            Console.WriteLine("Qualification    :"+Qualification);
            Console.WriteLine("YearOfExperience :"+YearOfExperience);
            Console.WriteLine("DateOfJoining    :"+YearOfExperience);
        }

    }
}