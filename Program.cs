// See https://aka.ms/new-console-template for more information
using EmployeeObj;
using cSharpEMSCL;
ITTech it1 = new ITTech(-2, "jew",castRole.corporate);
ITTech[] techList = { it1 };

while (true)
{ 
    bool userExitCondition = true;
    Console.Write("Enter Employee ID: ");

    string employeeInput = Console.ReadLine() ?? string.Empty;

    int employeeNum;

    bool validateInput = int.TryParse(employeeInput,out employeeNum);

    if(!validateInput || employeeInput.Length == 0)
    {
        Console.WriteLine("Please select valid input.");
    }

    if (validateInput || employeeInput.Length > 0)
    {
        for (int i = 0; i < it1.employeeList.Count; i++)
        {
            if (employeeNum == it1.employeeList[i].mId)
            {
                while (userExitCondition)
                {
                    Console.WriteLine($"Welcome {it1.employeeList[i].mName}!");
                    Console.WriteLine("1. Check clock status");
                    Console.WriteLine("2. Clock in");
                    Console.WriteLine("3. Clock out");
                    Console.WriteLine("4. Clock stats");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine("Please select an option");

                    int employeeMenuNum = EMSutilities.SwitchInputErrorCheck();

                    switch (employeeMenuNum)
                    {
                        case 1:
                            it1.employeeList[i].CheckClockStatus();
                            break;
                        case 2:
                            it1.employeeList[i].ClockIn();
                            break;
                        case 3:
                            it1.employeeList[i].ClockOut();
                            break;
                        case 4:
                            it1.employeeList[i].CheckClockStats();
                            break;
                        case 5:
                            userExitCondition = false;
                            break;
                        default:
                            EMSutilities.PrintInvalidInput();
                            break;
                    }
                }
            }
        }

        for (int i = 0; i < it1.managerList.Count; i++)
        {
            if (employeeNum == it1.managerList[i].mId)
            {
                while (userExitCondition)
                {
                    Console.WriteLine($"Welcome {it1.managerList[i].mName}!");
                    Console.WriteLine("1. Check clock status");
                    Console.WriteLine("2. Clock in");
                    Console.WriteLine("3. Clock out");
                    Console.WriteLine("4. Check clock stats");
                    Console.WriteLine("5. List members");
                    Console.WriteLine("6. Clock in employee");
                    Console.WriteLine("7. Exit");
                    //Console.WriteLine("");
                    Console.WriteLine("Please select an option");

                    int managerMenuNum = EMSutilities.SwitchInputErrorCheck();

                    switch (managerMenuNum)
                    {
                        case 1:
                            it1.managerList[i].CheckClockStatus();
                            break;
                        case 2:
                            it1.managerList[i].ClockIn();
                            break;
                        case 3:
                            it1.managerList[i].ClockOut();
                            break;
                        case 4:
                            it1.managerList[i].CheckClockStats();
                            break;
                        case 5:
                            it1.managerList[i].ListEmployees(it1.employeeList);
                            break;
                        case 6:
                            bool employeeLocated = true;
                            it1.managerList[i].ListEmployees(it1.employeeList);
                            int userInput = EMSutilities.EmployeeIdInput();
                            it1.managerList[i].ChangeClockStatusOfSubordinates(it1.employeeList,userInput,employeeLocated);

                            EMSutilities.employeeIdNotFound(employeeLocated);
                            break;
                        case 7:
                            userExitCondition = false;
                            break;
                        default:
                            EMSutilities.PrintInvalidInput();
                            break;
                    }
                }
            }
        }

        for (int i = 0; i < it1.leaderList.Count; i++)
        {
            if (employeeNum == it1.leaderList[i].mId)
            {
                while (userExitCondition)
                {
                    Console.WriteLine($"Welcome {it1.leaderList[i].mName}!");
                    Console.WriteLine("1. Check clock status");
                    Console.WriteLine("2. Clock in");
                    Console.WriteLine("3. Clock out");
                    Console.WriteLine("4. Check clock stats");
                    Console.WriteLine("5. List members");
                    Console.WriteLine("6. Clock in employee");
                    Console.WriteLine("7. Exit");
                    //Console.WriteLine("");
                    Console.WriteLine("Please select an option");

                    int leaderMenuNum = EMSutilities.SwitchInputErrorCheck();

                    switch (leaderMenuNum)
                    {
                        case 1:
                            it1.leaderList[i].CheckClockStatus();
                            break;
                        case 2:
                            it1.leaderList[i].ClockIn();
                            break;
                        case 3:
                            it1.leaderList[i].ClockOut();
                            break;
                        case 4:
                            it1.leaderList[i].CheckClockStats();
                            break;
                        case 5:
                            it1.leaderList[i].ListEmployees(it1.employeeList);
                            it1.leaderList[i].ListEmployees(it1.managerList);
                            break;
                        case 6:
                            bool employeeLocated = true;
                            it1.leaderList[i].ListEmployees(it1.employeeList);
                            it1.leaderList[i].ListEmployees(it1.managerList);

                            int userInput = EMSutilities.EmployeeIdInput();
                            it1.leaderList[i].ChangeClockStatusOfSubordinates(it1.employeeList, userInput, employeeLocated);
                            it1.leaderList[i].ChangeClockStatusOfSubordinates(it1.managerList, userInput, employeeLocated);

                            EMSutilities.employeeIdNotFound(employeeLocated);
                            break;
                        case 7:
                            userExitCondition = false;
                            break;
                        default:
                            EMSutilities.PrintInvalidInput();
                            break;
                    }
                }
            }
        }

        for (int i = 0; i < it1.adminList.Count; i++)
        {
            if (employeeNum == it1.adminList[i].mId)
            {
                while (userExitCondition)
                {
                    Console.WriteLine($"Welcome {it1.adminList[i].mName}!");
                    Console.WriteLine("1. Check clock status");
                    Console.WriteLine("2. Clock in");
                    Console.WriteLine("3. Clock out");
                    Console.WriteLine("4. Check clock stats");
                    Console.WriteLine("5. List members");
                    Console.WriteLine("6. Create members");
                    Console.WriteLine("7. Exit");
                    Console.WriteLine("Please select an option");
                    //Console.WriteLine("");

                    int adminMenuNum = EMSutilities.SwitchInputErrorCheck();

                    switch (adminMenuNum)
                    {
                        case 1:
                            it1.adminList[i].CheckClockStatus();
                            break;
                        case 2:
                            it1.adminList[i].ClockIn();
                            break;
                        case 3:
                            it1.adminList[i].ClockOut();
                            break;
                        case 4:
                            it1.adminList[i].CheckClockStats();
                            break;
                        case 5:
                            it1.adminList[i].ListEmployees(it1.employeeList);
                            it1.adminList[i].ListEmployees(it1.managerList);
                            it1.adminList[i].ListEmployees(it1.leaderList);
                            break;
                        case 6:
                            it1.adminList[i].CreateCast(ref it1.employeeList, ref it1.managerList,ref it1.leaderList);
                            break;
                        case 7:
                            userExitCondition = false;
                            break;
                        default:
                            EMSutilities.PrintInvalidInput();
                            break;
                    }
                }
            }
        }

        for (int i = 0; i < techList.Length; i++)
        {
            if (employeeNum == techList[i].mId)
            {
                while (userExitCondition)
                {
                    Console.WriteLine($"Welcome {techList[i].mName}!");
                    Console.WriteLine("1. Check clock status");
                    Console.WriteLine("2. Clock in");
                    Console.WriteLine("3. Clock out");
                    Console.WriteLine("4. Check clock stats");
                    Console.WriteLine("5. List members");
                    Console.WriteLine("6. Exit");
                    Console.WriteLine("Please select an option");
                    //Console.WriteLine("");

                    int techMenuNum = EMSutilities.SwitchInputErrorCheck();

                    switch (techMenuNum)
                    {
                        case 1:
                            techList[i].CheckClockStatus();
                            break;
                        case 2:
                            techList[i].ClockIn();
                            break;
                        case 3:
                            techList[i].ClockOut();
                            break;
                        case 4:
                            techList[i].CheckClockStats();
                            break;
                        case 5:
                            techList[i].ListEmployees(it1.employeeList);
                            techList[i].ListEmployees(it1.managerList);
                            techList[i].ListEmployees(it1.leaderList);
                            techList[i].ListEmployees(it1.adminList);
                            break;
                        case 6:
                            userExitCondition = false;
                            break;
                        default:
                            EMSutilities.PrintInvalidInput();
                            break;
                    }
                }
            }
        }
    }
}
