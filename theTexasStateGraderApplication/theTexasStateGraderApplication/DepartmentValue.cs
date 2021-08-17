using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theTexasStateGraderApplication
{
    public class DepartmentValue
    {
        private string departmentCode;
        private string departmentName;

        public string DepartmentCode { get => departmentCode; set => departmentCode = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }
    }
}
