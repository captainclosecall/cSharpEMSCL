// See https://aka.ms/new-console-template for more information
using EmployeeObj;
ITTech it1 = new ITTech(-1, "jew");
ITTech[] techList = { it1 };

while (true)
{
    Console.Write("Enter Employee ID: ");

    string employeeInput = Console.ReadLine() ?? string.Empty;

    int employeeNum = Convert.ToInt32(employeeInput);

    for (int i = 0; i < it1.employeeList.Length; i++)
    {
        if(employeeNum == it1.employeeList[i].mId)
        {
            Console.WriteLine($"Welcome {it1.employeeList[i].mName}!");
        }
    }

    for (int i = 0; i < it1.managerList.Length; i++)
    {
        if(employeeNum == it1.managerList[i].mId)
        {
            Console.WriteLine($"Welcome {it1.managerList[i].mName}!");
        }
    }

    for (int i = 0; i < it1.leaderList.Length; i++)
    {
        if(employeeNum == it1.leaderList[i].mId)
        {
            Console.WriteLine($"Welcome {it1.leaderList[i].mName}!");
        }
    }

    for (int i = 0; i < it1.adminList.Length; i++)
    {
        if(employeeNum == it1.adminList[i].mId)
        {
            Console.WriteLine($"Welcome {it1.adminList[i].mName}!");
        }
    }

    for (int i = 0; i < techList.Length; i++)
    {
        if(employeeNum == techList[i].mId)
        {
            Console.WriteLine($"Welcome {techList[i].mName}!");
        }
    }



}
