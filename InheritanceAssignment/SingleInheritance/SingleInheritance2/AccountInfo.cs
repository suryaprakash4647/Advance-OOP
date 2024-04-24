using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance2
{
    public class AccountInfo : PersonalInfo
    {
        //Fields
        private static int s_accountNumber=1000;
        //Properties
        public string AccountNumber{get;}
        public string BranchName{get;set;}
        public string IFSCCode{get;set;}
        public int Balance{get;set;}

        //Constructor
        public AccountInfo(string name,string fatherName,long phone,string mail,DateTime dob,Gender gender,string branchName,string iFSCCode,int balance):base(name,fatherName,phone,mail,dob,gender)
        {
            s_accountNumber++;
            AccountNumber="MBANK"+s_accountNumber;
            BranchName=branchName;
            IFSCCode=iFSCCode;
            Balance=balance;
        }
        public void ShowAccountInfo()          
        {
            Console.WriteLine("| Name | FatherName | Phone | Mail | DOB | Gender | BranchName | IFSCCode | Balance |");
            Console.WriteLine($"| {Name} | {FatherName} | {Phone} | {Mail} | {DOB} | {Gender} | {BranchName} | {IFSCCode} | {Balance} |");
        } 
        public void Deposit(int amount)
        {
            Balance= Balance+amount;
            Console.WriteLine("Updated Balance : "+Balance);
        } 
        public void Withdraw(int amount)
        {
            Balance=Balance-amount;
            Console.WriteLine("Updated Balance : "+ Balance);
        }
        public void ShowBalance()
        {
            Console.WriteLine("Current Balance : "+ Balance);
        }

    }
}