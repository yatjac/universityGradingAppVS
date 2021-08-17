using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theTexasStateGraderApplication
{
    public static class DepartmentDB
    {
        public static List<DepartmentValue> GetAllDepartment()
        {
            List<DepartmentValue> list = new List<DepartmentValue>();
            cis3325_GraderEntities container = new cis3325_GraderEntities();
            var department = from dp in container.Departments select dp;
            foreach (Department dp in department)
            {
                DepartmentValue value = new DepartmentValue()
                {
                    DepartmentCode = dp.DepartmentCode,
                    DepartmentName = dp.DepartmentName,
                };
                list.Add(value);
            }
            return list;
        }
        public static DepartmentValue GetDepartment(string departmentCode)
        {
            DepartmentValue d = null;

            cis3325_GraderEntities container = new cis3325_GraderEntities();
            var department = from dp in container.Departments select dp;
            d = new DepartmentValue
            {
                DepartmentCode = d.DepartmentCode,
                DepartmentName = d.DepartmentName,
            };
          
            return d;
        }
    }
}
