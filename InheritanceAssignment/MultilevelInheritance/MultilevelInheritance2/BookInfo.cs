using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance2
{
    public class BookInfo:RackInfo
    {
        public static int s_bookID=100;
        public string BookID{get;} 
        public string BookName{get;set;}
        public string AuthorName{get;set;}
        public int Price{get;set;}

        //Constructor
        public BookInfo(string departmentName,string degree,int rackNumber,int columnNumber,string bookName,string authorName,int price):base(departmentName,degree,rackNumber,columnNumber)
        {
            s_bookID++;
            BookID="BID"+s_bookID;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("| DepartmentName | Degree | RackNumber | ColumnNumber | BookName | AuthorName | Price | BookID | ");
            Console.WriteLine($"| {DepartmentName} | {Degree} | {RackNumber} | {ColumnNumber} | {BookName} | {AuthorName} | {Price} | {BookID} |");
        }
    }
}