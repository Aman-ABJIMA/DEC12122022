using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace BethanysPieShopHRM.HR
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Employee bethany = new StoreManager(10009,"Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
            Manager mary = new Manager(10008,"Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);
            JuniorResearcher bobJunior = new JuniorResearcher(10007,"Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);
            Employee kevin = new StoreManager(10006,"Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10);
            Employee kate = new StoreManager(10005,"Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10);


            List<Employee> employees = new List<Employee>();
            employees.Add(bethany);
            employees.Add(kevin);
            employees.Add(kate);
            employees.Add(bobJunior);
            employees.Add(kate);

            employees.Sort();

            foreach (var employee in employees)
            {
                employee.PerformWork();
                employee.ReceiveWage();
                employee.DisplayEmployeeDetails();
                employee.GiveBonus();
                //employee.AttendManagementMeeting();
            }

            Console.ReadLine();
        }
    }
}
