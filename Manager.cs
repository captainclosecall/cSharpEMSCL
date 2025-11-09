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
        internal List<Employee> employeeList = new(){new Employee(1,"J",castRole.foodAndBeverage) };

        //Constructor
        internal Manager(int id, string name, castRole role) : base(id, name,role) { }
       
        //Methods

    }
}
