using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance1
{
    public class HSCDetails:StudentInfo
    {
        private static int s_hSCMarksheetNumber=100;
        public string HSCMarksheetNumber{get;} 
        public int Physics{get;set;} 
        public int Chemistry{get;set;}
        public int Maths{get;set;} 
        public double Total{get;set;} 
        public double Percentage{get;set;} 

        public HSCDetails(string name,string fatherName,long phone ,string mail,DateTime dob,Gender gender,string standard,string branch,int acadamicYear,int physics,int chemistry,int maths):base(name,fatherName,phone ,mail,dob,gender,standard,branch,acadamicYear)
        {
            s_hSCMarksheetNumber++;
            HSCMarksheetNumber="HSCM"+s_hSCMarksheetNumber;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        public void GetMarks()
        {
            Console.WriteLine("Enter Physics mark : ");
            Physics=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Chemstry mark : ");
            Chemistry=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Maths mark : ");
            Maths=int.Parse(Console.ReadLine());
        } 
        public void Calculate()
        {
            Total=Physics+Chemistry+Maths;
            Percentage=Total/300*100;
           
        }
        public void ShowMarksheet()
        {
            Console.WriteLine("Physics    : "+Physics);
            Console.WriteLine("Chemistry  : "+Chemistry);
            Console.WriteLine("Maths      : "+Maths);
            Console.WriteLine("Total      : "+Total);
            Console.WriteLine("Percentage : "+Percentage);
        }
    }
}