using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Computation
{
    class SalaryInformation
    {
        private int employeeID;
        private double rateInPesos;
        private int hoursWork;
        private double salary;
        private int hoursOT;
        private double holiPay;

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public double RateInPesos
        {
            get { return rateInPesos; }
            set { rateInPesos = value; }
        }

        public int HoursWork
        {
            get { return hoursWork; }
            set { hoursWork = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public int HoursOT
        {
            get { return hoursOT; }
            set { hoursOT = value; }
        }

        public double HoliPay
        {
            get { return holiPay; }
            set { holiPay = value; }
        }

    }
}
