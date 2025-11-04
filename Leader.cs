using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeObj
{
    internal class Leader : Manager
    {
        //Fields
        internal Manager[] managerList = { new Manager(2, "JJ") };
        //Constructor
        internal Leader(int id, string name) : base(id, name) { }
    }
}
