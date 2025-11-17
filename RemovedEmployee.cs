using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeObj
{
    internal class RemovedEmployee : Employee
    {
        public RemovedEmployee(int id, string name, castRole jobTitle) : base(id,name, jobTitle) 
        {
        }
    }
}
