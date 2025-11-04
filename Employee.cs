using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeObj
{
    internal class Employee
    {
        //Fields
        internal int mId { get;private set; }
        internal string mName { get;private set; }
        internal bool clockStatus { get; private set; }

        //Constructor
        public Employee(int id, string name)
        {
            mId = id;
            mName = name;
            //clockStatus = true;
        }

        //Methods
        internal void CheckClockStatus()
        {
            if(!clockStatus)
            {
                Console.WriteLine($"{mName} is clocked out.");
            }
            else
            {
                Console.WriteLine($"{mName} is clocked in.");
            }
        }

        internal void ClockIn()
        {
            if(!clockStatus)
            {
                clockStatus = true;
                Console.WriteLine($"{mName} has clocked in");
            }
            else
            {
                Console.WriteLine($"{mName} is already clocked in.");
            }
        }

        internal void ClockOut()
        {
            if(clockStatus)
            {
                clockStatus = false;
                Console.WriteLine($"{mName} has clocked out");
            }
            else
            {
                Console.WriteLine($"{mName} is already clocked out.");
            }
        }


    }
}
