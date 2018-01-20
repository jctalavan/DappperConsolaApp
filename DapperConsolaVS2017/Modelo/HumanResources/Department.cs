using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperConsolaVS2017.Modelo.HumanResources
{
    internal class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
