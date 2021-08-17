using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theTexasStateGraderApplication
{
    public class GraderValue
    {
        private int graderId;
        private string firstName;
        private string lastName;
        private string department;
        private int hours;
        private decimal hourlyPay;
        private decimal stipend;
        private int graderType;

        public int GraderId { get => graderId; set => graderId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Department { get => department; set => department = value; }
        public decimal HourlyPay { get => hourlyPay; set => hourlyPay = value; }
        public decimal Stipend { get => stipend; set => stipend = value; }
        public int Hours { get => hours; set => hours = value; }
        public int GraderType { get => graderType; set => graderType = value; }

        public decimal getPayment()
        {
            return HourlyPay * Hours + Stipend;
        }

    }
}
