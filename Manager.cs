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
        internal Employee[] employeeList = {new Employee(1,"J") };

        //Constructor
        internal Manager(int id, string name) : base(id, name) { }
       
        //Methods

    }
}
