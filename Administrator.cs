using cSharpEMSCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeObj
{
    internal class Administrator : Leader
    {
        //Fields
        internal List<Leader> leaderList = new() {new Leader(3, "Jayleen",castRole.merchandise) };
        //Constructor
        internal Administrator(int id,string name, castRole role) : base(id,name,role) { }

        //Methods
        public void CreateCast(ref List<Employee> emp, ref List<Manager> mg, ref List<Leader> lead)
        {
            bool castCreationValidation = true;
            castRole roleAssignment = castRole.noRole;
            int idAssign = emp.Count + mg.Count + lead.Count +1;
            string castName = "";

            while (castCreationValidation)
            {
                Console.Write("Enter Employee Name:");
                castName = Console.ReadLine() ?? String.Empty;
                if (castName.Length <= 0)
                {
                    Console.WriteLine("Please enter a name for new employee.");
                }
                else
                {
                    castCreationValidation = false;
                }
            }
            castCreationValidation = true;

            while (castCreationValidation)
            {
                Console.WriteLine("Please select a Role");
                Console.WriteLine("1. Merchandise");
                Console.WriteLine("2. Food & Beverage");
                Console.WriteLine("3. HousePerson");
                Console.WriteLine("4. Corporate");

                int jobSelectionNum = EMSutilities.SwitchInputErrorCheck();
              
                    switch (jobSelectionNum)
                    {
                        case 1:
                            castCreationValidation = false;
                            roleAssignment = castRole.merchandise;
                            break;
                        case 2:
                            castCreationValidation = false;
                            roleAssignment = castRole.foodAndBeverage;
                            break;
                        case 3:
                            castCreationValidation = false;
                            roleAssignment = castRole.houseKeeping;
                            break;
                        case 4:
                            castCreationValidation = false;
                            roleAssignment = castRole.corporate;
                            break;
                        default:
                            Console.WriteLine("Please Select a valid option.");
                            break;
                    }
            }
            castCreationValidation = true;
            while (castCreationValidation)
            {
                Console.WriteLine("1. Employee");
                Console.WriteLine("2. Manager");
                Console.WriteLine("3. Leader");
                Console.WriteLine($"Please select {castName}'s rank:");


                int castRankNum = EMSutilities.SwitchInputErrorCheck();

                    switch (castRankNum)
                    {
                        case 1:
                            emp.Add(new Employee(idAssign, castName, roleAssignment));
                            castCreationValidation = false;
                            break;
                        case 2:
                            mg.Add(new Manager(idAssign, castName, roleAssignment));
                            castCreationValidation = false;
                            break;
                        case 3:
                            lead.Add(new Leader(idAssign, castName, roleAssignment));
                            castCreationValidation = false;
                            break;
                    default:
                        Console.WriteLine("Please select a valid option.");
                        break;
                    }
            }
        }

        public void ListAllEmployee<T>(IEnumerable<T> castList) where T : Employee
        {
            Console.WriteLine($"{typeof(T).Name}s:");
            int i = 1;
            foreach (var member in castList)
            {
                Console.WriteLine($"{i++}- Name: {member.mName} ID: {member.mId} Role: {member.mJobTitle}");
            }
        }
    }
}