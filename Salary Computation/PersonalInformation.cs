using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Computation
{
    class PersonalInformation
    {
        private string name;
        private string address;
        private string emailaddress;
        private string cpno;
        private string department;
        private string jobposition;
        private string jobstatus;
        private string citizenship;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string EmailAddress
        {
            get { return emailaddress; }
            set { emailaddress = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string CpNo
        {
            get { return cpno; }
            set { cpno = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string JobPosition
        {
            get { return jobposition; }
            set { jobposition = value; }
        }

        public string JobStatus
        {
            get { return jobstatus; }
            set { jobstatus = value; }
        }

        public string Citizenship
        {
            get { return citizenship; }
            set { citizenship = value; }
        }
    }
}
