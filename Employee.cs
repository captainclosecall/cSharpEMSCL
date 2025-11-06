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
        internal List<DateTime> clockInHistory = new List<DateTime> { };
        internal List<DateTime> clockOutHistory = new List<DateTime> { };

        //Constructor
        public Employee(int id, string name)
        {
            mId = id;
            mName = name;
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
                DateTime now = DateTime.Now;
                clockStatus = true;
                clockInHistory.Add(now);
                Console.WriteLine($"{mName} has clocked in at {now:f}");
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
                DateTime now = DateTime.Now;
                clockStatus = false;
                clockOutHistory.Add(now);
                Console.WriteLine($"{mName} has clocked out at {now:f}");
            }
            else
            {
                Console.WriteLine($"{mName} is already clocked out.");
            }
        }

        internal void CheckClockStats()
        {
            Console.WriteLine("Clock in stats:");

            if(clockInHistory.Count == 0)
            {
                Console.WriteLine("No clock history.");
                return;
            }

            for(int i = 0; i < clockInHistory.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {clockInHistory[i].ToString()}");
            }

            Console.WriteLine("Clock out stats:");

            if (clockOutHistory.Count == 0)
            {
                Console.WriteLine("No clock history.");
            }

            for (int i = 0; i < clockOutHistory.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {clockOutHistory[i].ToString()}");
            }

            Console.WriteLine("Time Worked:");
            if (clockInHistory.Count != clockOutHistory.Count)
            {
                Console.WriteLine("Clock out to see your time worked.");
                return;
            }

            for(int i = 0; i < clockOutHistory.Count;i++)
            {
                TimeSpan timeDiff = clockOutHistory[i].Subtract(clockInHistory[i]);

                Console.WriteLine($"{i + 1}: {timeDiff}");
            }
        }


    }
}
