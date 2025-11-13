using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpEMSCL
{
    internal struct EMSutilities
    {

        //Function to make sure user input integer value for switch menu select
        internal static int SwitchInputErrorCheck()
        {
            bool inputValidiation = true;
            while (inputValidiation)
            {
                string menuSelection = Console.ReadLine() ?? string.Empty;
                int menuSelectionNum;
                bool menuSelectionVerification = int.TryParse(menuSelection, out menuSelectionNum);

                if (menuSelectionVerification)
                {
                    return menuSelectionNum;
                }
            }
            return 0;
        }

        internal static void PrintInvalidInput()
        {
            Console.WriteLine("Please select a valid option.");
        }

        internal static int EmployeeIdInput()
        {
            Console.Write("Enter employee ID:");

            int userInput = EMSutilities.SwitchInputErrorCheck();

            return userInput;
        }

        //If you want this method to print bool need to be true
        internal static void employeeIdNotFound(bool idVerification)
        {
            if (idVerification)
            {
                Console.WriteLine("No employee located by that user Id.");
            }
        }
    }
}
