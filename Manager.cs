using cSharpEMSCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeObj
{
    internal class Manager : Employee
    {
        //Fields
        internal List<Employee> employeeList = new (){new Employee(1,"J",castRole.foodAndBeverage) };

        //Constructor
        internal Manager(int id, string name, castRole role) : base(id, name,role) { }
       
        //Methods
        internal void ListEmployees<T>(IEnumerable<T> castList) where T : Employee
        {
            Console.WriteLine($"{typeof(T).Name}");

            foreach(var member in castList)
            {
                int i = 1;
                Console.Write($"{i++}- Name: {member.mName} ID: {member.mId} Role: {member.mJobTitle}");
                if(member.mClockStatus)
                {
                    Console.WriteLine(" Clock status: Clocked in");
                }
                else
                {
                    Console.WriteLine(" Clock status: Clocked out");
                }
            }
        }

        /*Trying to figure out how to write this with the least code repetition as possible*/
        internal void ChangeClockStatusOfSubordinates<T>(IEnumerable<T> castList) where T : Employee
        {
            Console.Write("Enter employee ID of member you want to clock in:");

            int employeeToClock = EMSutilies.SwitchInputErrorCheck();
            
            foreach(var member in castList)
            {
                if(employeeToClock == member.mId)
                {
                    member.CheckClockStatus();
                    Console.Write("would you like to change the clock status?");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. Back to main menu");
                    Console.Write("Select an option: ");

                    int clockDecision = EMSutilies.SwitchInputErrorCheck();

                    switch(clockDecision)
                    {
                        case 1:
                            member.mClockStatus = !mClockStatus;
                            break;
                    }
                }
            }
        }
    }
}
