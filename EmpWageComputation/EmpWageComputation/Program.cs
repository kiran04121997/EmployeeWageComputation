using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to EmpWage problem");

            EmployeeAttendence dMart = new EmployeeAttendence("DMart", 20, 2, 10);
            EmployeeAttendence reliance = new EmployeeAttendence("Reliance", 10, 4, 10);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
            Console.ReadLine();
        }
    }
}
