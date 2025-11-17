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
            Console.WriteLine($"{typeof(T).Name}:");

            foreach(var member in castList)
            {
                int i = 1;
                Console.Write($"{i++}- Name: {member.mName} |ID: {member.mId} Role: |{member.mJobTitle}|");
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
        internal bool ChangeClockStatusOfSubordinates<T>(IEnumerable<T> castList, int userInput) where T : Employee
        {
            //add mechanism that tracks who clocked in who. 
            foreach(var member in castList)
            {
                if(userInput == member.mId)
                {
                    bool employeeFound = true;
                    while (employeeFound)
                    {
                        member.CheckClockStatus();
                        Console.WriteLine("would you like to change the clock status?");
                        Console.WriteLine("1. Yes");
                        Console.WriteLine("2. Back to main menu");
                        Console.Write("Select an option: ");

                        int clockDecision = EMSutilities.SwitchInputErrorCheck();

                        switch (clockDecision)
                        {
                            case 1:
                                if (member.mClockStatus)
                                {
                                    member.ClockOut();
                                }
                                else
                                {
                                    member.ClockIn();
                                }
                                return employeeFound = false;
                            case 2:
                                return employeeFound = false;
                            default:
                                EMSutilities.PrintInvalidInput();
                                break;
                        }
                    }
                }
            }
            return true;
        }
    }
}
