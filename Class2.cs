using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Interface
{
    class MAIN : IEmployee         
    {

        public string empName;
        public int empId;
        public string email;
        public double wage;
        public int noOfHoursWorked;
        public int hourlypay;





       public void Calculate()
        {
            wage = noOfHoursWorked * hourlypay + 300;
        }

        public void Display()
        {
            Console.WriteLine($"Employee Name:{empName}\nEmployee ID:{empId}\nEmail:{email}\nWage:{wage}\n");
        }
    }
}
