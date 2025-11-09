using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeObj
{
    internal class Administrator : Leader
    {
        //Fields
        internal List<Leader> leaderList = new() {new Leader(3, "Jayleen",castRole.merchandise) };
        //Constructor
        internal Administrator(int id,string name, castRole role) : base(id,name,role) { }

        //Methods
    }
}
