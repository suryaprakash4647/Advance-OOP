using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance1
{
    public class PrincipalInfo : PersonalInfo
    {
        private static int s_principalID=2000;
        public string PrincipalID{get;}
        public string Qualification{get;set;}
        public int YearOfExperience{get;set;}
        public DateTime DateOfJoining{get;set;}
        public PrincipalInfo(string name,string fatherName,DateTime dob,string phone,Gender gender,string mail,string qualification,int yearOfExperience,DateTime dateOfJoining):base(name,fatherName,dob,phone,gender,mail)
        {
            s_principalID++;
            PrincipalID="PID"+s_principalID;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;

        }
        public void ShowDetails()
        {
            Console.WriteLine($"| {Name} | {FatherName} | {DOB} | {Phone} | {Gender} | {Mail} | {Qualification} | {YearOfExperience} | {DateOfJoining} |");
        }
    }
}