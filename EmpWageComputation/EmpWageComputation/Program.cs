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
            Console.WriteLine("welcome to employeewage");

            EmployeeAttendence.ComputeEmpwage("DMart", 20, 2, 10);
            EmployeeAttendence.ComputeEmpwage("Reliance", 10, 4, 20);

            Console.ReadLine();
        }
    }
}
