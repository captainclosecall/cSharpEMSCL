// See https://aka.ms/new-console-template for more information
using EmployeeObj;
ITTech it1 = new ITTech(-1, "jew",castRole.corporate);
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

        for (int i = 0; i < it1.employeeList.Length; i++)
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

                    string employeeMenu = Console.ReadLine() ?? string.Empty;
                    int employeeMenuNum = Convert.ToInt16(employeeMenu);

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
                            Console.WriteLine("Please select a valid option.");
                            break;

                    }
                }
            }
        }

        for (int i = 0; i < it1.managerList.Length; i++)
        {
            if (employeeNum == it1.managerList[i].mId)
            {
                Console.WriteLine($"Welcome {it1.managerList[i].mName}!");
                Console.WriteLine("1. Check clock status");
                Console.WriteLine("2. Clock in");
                Console.WriteLine("3. Clock out");
                Console.WriteLine("4. Check clock stats");
                Console.WriteLine("5. Exit");
                //Console.WriteLine("");
                Console.WriteLine("Please select an option");

                string managerMenu = Console.ReadLine() ?? string.Empty;
                int managerMenuNum = Convert.ToInt16(managerMenu);

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
                        userExitCondition = false;
                        break;
                    default:
                        Console.WriteLine("Please select a valid option.");
                        break;

                }
            }
        }

        for (int i = 0; i < it1.leaderList.Length; i++)
        {
            if (employeeNum == it1.leaderList[i].mId)
            {
                Console.WriteLine($"Welcome {it1.leaderList[i].mName}!");
                Console.WriteLine("1. Check clock status");
                Console.WriteLine("2. Clock in");
                Console.WriteLine("3. Clock out");
                Console.WriteLine("4. Check clock stats");
                Console.WriteLine("5. Exit");
                //Console.WriteLine("");
                Console.WriteLine("Please select an option");

                string leaderMenu = Console.ReadLine() ?? string.Empty;
                int leaderMenuNum = Convert.ToInt16(leaderMenu);

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
                        userExitCondition = false;
                        break;
                    default:
                        Console.WriteLine("Please select a valid option.");
                        break;

                }
            }
        }

        for (int i = 0; i < it1.adminList.Length; i++)
        {
            if (employeeNum == it1.adminList[i].mId)
            {
                Console.WriteLine($"Welcome {it1.adminList[i].mName}!");
                Console.WriteLine("1. Check clock status");
                Console.WriteLine("2. Clock in");
                Console.WriteLine("3. Clock out");
                Console.WriteLine("4. Check clock stats");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Please select an option");

                string adminMenu = Console.ReadLine() ?? string.Empty;
                int adminMenuNum = Convert.ToInt16(adminMenu);

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
                        userExitCondition = false;
                        break;
                    default:
                        Console.WriteLine("Please select a valid option.");
                        break;

                }
            }
        }

        for (int i = 0; i < techList.Length; i++)
        {
            if (employeeNum == techList[i].mId)
            {
                Console.WriteLine($"Welcome {techList[i].mName}!");
                Console.WriteLine("1. Check clock status");
                Console.WriteLine("2. Clock in");
                Console.WriteLine("3. Clock out");
                Console.WriteLine("4. Check clock stats");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Please select an option");

                string techMenu = Console.ReadLine() ?? string.Empty;
                int techMenuNum = Convert.ToInt16(techMenu);

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
                        userExitCondition = false;
                        break;
                    default:
                        Console.WriteLine("Please select a valid option.");
                        break;

                }
            }
        }
    }



}
