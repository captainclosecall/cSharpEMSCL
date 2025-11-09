using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpEMSCL
{
    internal struct EMSutilies
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
                    inputValidiation = false;
                }
                else
                {
                    Console.WriteLine("Please select valid option.");
                    return 0;
                }
            }
            return 0;
        }

    }
}
