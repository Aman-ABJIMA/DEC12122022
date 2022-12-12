using Create_Interface;
using System;
namespace interFace
{
    class Program
    {


        static void Main(string[] args)
        {
            //Object 1
            MAIN AMAN = new MAIN();            
            AMAN.empName = "aman singh";
            AMAN.email = "asingh@gmail.com";
            AMAN.empId = 10005;
            AMAN.hourlypay = 100;
            AMAN.noOfHoursWorked = 8;
            AMAN.Calculate();
            AMAN.Display();
            //Object2
            MAIN ROHIT = new MAIN();
            ROHIT.empName = "rohit singh";
            ROHIT.email = "rsingh@gmail.com";
            ROHIT.empId = 10006;
            ROHIT.hourlypay = 80;
            ROHIT.noOfHoursWorked = 6;
            ROHIT.Calculate();
            ROHIT.Display();
            //Object3
            MAIN ABHI = new MAIN();
            ABHI.empName = "abhi singh";
            ABHI.email = "abhisingh@gmail.com";
            ABHI.empId = 10007;
            ABHI.hourlypay = 70;
            ABHI.noOfHoursWorked = 8;
            ABHI.Calculate();
            ABHI.Display();
        }
    }
}