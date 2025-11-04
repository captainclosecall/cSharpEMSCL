using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeObj
{
    internal class Employee
    {
        //Fields
        internal int mId { get;private set; }
        internal string mName { get;private set; }

        //Constructor
        public Employee(int id, string name)
        {
            mId = id;
            mName = name;
        }

        //Methods
    }
}
