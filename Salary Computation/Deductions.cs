using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Computation
{
    class Deductions
    {
        private double sss;
        private double pagibig;
        private double philhealth;
        private double absences;

        public double SSS
        {
            get { return sss; }
            set { sss = value; }
        }

        public double PagIbig
        {
            get { return pagibig; }
            set { pagibig = value; }
        }

        public double PhilHealth
        {
            get { return philhealth; }
            set { philhealth = value; }
        }

        public double Absences
        {
            get { return absences; }
            set { absences = value; }
        }
    }
}
