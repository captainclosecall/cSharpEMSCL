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
        internal List<Manager> managerList = new() { new Manager(2, "JJ", castRole.houseKeeping) };
        //Constructor
        internal Leader(int id, string name,castRole role) : base(id, name,role) { }
    }
}
