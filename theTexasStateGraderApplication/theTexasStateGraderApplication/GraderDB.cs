using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theTexasStateGraderApplication
{
    public static class GraderDB
    {
        public static void DeleteGrader(GraderValue g)
        {
            cis3325_GraderEntities container = new cis3325_GraderEntities();
            var grader = (from gd in container.Graders where gd.GraderID == g.GraderId select gd).SingleOrDefault();

            try
            {
               
                {
                    if (grader != null)
                    container.Graders.Remove(grader);
                    container.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }
        public static void AddStudents(GraderValue g)
        {
            cis3325_GraderEntities container = new cis3325_GraderEntities();
            Grader grader = new Grader
            {
                GraderID = g.GraderId,
                FirstName = g.FirstName,
                LastName = g.LastName,
                HourlyPay = g.HourlyPay,
                Hours = g.Hours,
                Stipend = g.Stipend,
                GraderType = g.GraderType,
                Department = g.Department,
            };

            try
            {
                container.Graders.Add(grader);
                container.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }

        public static List<GraderValue> GetGraderByGraderType(string gradertype)
        {
            List<GraderValue> list = new List<GraderValue>();
            cis3325_GraderEntities container = new cis3325_GraderEntities();
            var graders = from g in container.Graders
            where g.GraderType.ToString() == gradertype select g;

            foreach (Grader g in graders)
            {
                string gt = ""; 

                if (g.GraderType != null) { gt = g.GraderType.ToString(); } 

                GraderValue value = new GraderValue
                {
                    GraderId = g.GraderID,
                    FirstName = g.FirstName,
                    LastName = g.LastName,
                    HourlyPay = (decimal)g.HourlyPay,
                    Hours = (int)g.Hours,
                    Stipend = (int)g.Stipend,
                    GraderType = (int)g.GraderType,
                    Department = g.Department,

                };
                list.Add(value);
            }

            return list;
        }
        public static List<GraderValue> GetAllGraders()
        {
            List<GraderValue> list = new List<GraderValue>();
            cis3325_GraderEntities container = new cis3325_GraderEntities();
            var graders = from g in container.Graders select g;


            foreach (Grader g in graders)
            {

                GraderValue value = new GraderValue
                {
                    GraderId = g.GraderID,
                    FirstName = g.FirstName,
                    LastName = g.LastName,
                    HourlyPay = (decimal)g.HourlyPay,
                    Hours = (int)g.Hours,
                    Stipend = (int)g.Stipend,
                    GraderType = (int)g.GraderType,
                    Department = g.Department,

                };
                list.Add(value);
            }
     
            return list;
        }
        public static GraderValue GetGrader(int graderId)
        {
            GraderValue gd = null;

            cis3325_GraderEntities container = new cis3325_GraderEntities();
            var grader = (from g in container.Graders where g.GraderID == graderId select g).SingleOrDefault();
            gd = new GraderValue
            {

                GraderId = grader.GraderID,
                FirstName = grader.FirstName,
                LastName = grader.LastName,
                Department = grader.Department,
                HourlyPay = (decimal)grader.HourlyPay.Value,
                Hours = (int)grader.Hours.Value,
                Stipend = (int)grader.Stipend.Value,
                GraderType = (int)grader.GraderType,

            };
            return gd;
        }
    }
  
}
