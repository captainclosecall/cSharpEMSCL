using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeObj
{
    internal class ITTech : Administrator
    {
        //Fields
        internal List<Administrator> adminList = new() { new Administrator(4, "Jayleen Wilson", castRole.photoPass) };
        //Constructor
        internal ITTech(int id, string name, castRole role) : base(id, name, role) { }
    }
}
