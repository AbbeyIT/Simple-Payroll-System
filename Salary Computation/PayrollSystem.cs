using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Computation
{
    public partial class PayrollSystem : Form
    {
        public PayrollSystem()
        {
            InitializeComponent();
        }

        private void buttonDisplayInfo_Click(object sender, EventArgs e)
        {
            PersonalInformation objpersoInfo = new PersonalInformation();
            objpersoInfo.Name = textBoxName.Text;
            objpersoInfo.Address = textBoxAddress.Text;
            objpersoInfo.EmailAddress = textBoxEmail.Text;
            objpersoInfo.CpNo = textBoxCpNo.Text;
            objpersoInfo.Department = textBoxDepartment.Text;
            objpersoInfo.JobPosition = textBoxJobPosition.Text;
            objpersoInfo.JobStatus = textBoxJobStatus.Text;
            objpersoInfo.Citizenship = textBoxCitizenship.Text;

            if (textBoxName.Text == "Juan Dela Cruz" && textBoxAddress.Text == "Marikina City, NCR" && 
                textBoxEmail.Text == "juan.dela.cruz@gmail.com" && textBoxCpNo.Text == "09010101010" && textBoxDepartment.Text == "IT" &&
                textBoxJobPosition.Text == "C# Developer" && textBoxJobStatus.Text == "Full Time" && 
                textBoxCitizenship.Text == "Filipino")
            {
                listBoxPersoInfo.Items.Add("Employee Name: " + objpersoInfo.Name);
                listBoxPersoInfo.Items.Add("Email Address: " + objpersoInfo.EmailAddress);
                listBoxPersoInfo.Items.Add("Address: " + objpersoInfo.Address);
                listBoxPersoInfo.Items.Add("Cellphone No.: " + objpersoInfo.CpNo);
                listBoxPersoInfo.Items.Add("Department: " + objpersoInfo.Department);
                listBoxPersoInfo.Items.Add("Job Position: " + objpersoInfo.JobPosition);
                listBoxPersoInfo.Items.Add("Job Status: " + objpersoInfo.JobStatus);
                listBoxPersoInfo.Items.Add("Citizenship: " + objpersoInfo.Citizenship);
            }
            else
            {
                MessageBox.Show("No user found. There might be incorrect information that was input. Please try again.");
            }
        }
        private void buttonComputeSalary_Click(object sender, EventArgs e)
        {
            SalaryInformation objSalary = new SalaryInformation();
            objSalary.EmployeeID = Convert.ToInt32(textBoxEmployeeID.Text);
            objSalary.RateInPesos = Convert.ToDouble(textBoxRate.Text);
            objSalary.HoursWork = Convert.ToInt32(textBoxHours.Text);
            objSalary.HoursOT = Convert.ToInt32(textBoxHoursOT.Text);
            objSalary.HoliPay = Convert.ToDouble(textBoxHoliPay.Text);

            Deductions objDeduc = new Deductions();
            objDeduc.SSS = Convert.ToDouble(textBoxSSS.Text);
            objDeduc.PagIbig= Convert.ToDouble(textBoxPagibig.Text);
            objDeduc.PhilHealth = Convert.ToDouble(textBoxPhilHealth.Text);
            objDeduc.Absences = Convert.ToDouble(textBoxAbsences.Text);

            objSalary.Salary = (objSalary.RateInPesos * (objSalary.HoursWork + objSalary.HoursOT)) + (objSalary.HoliPay) - 
                (objDeduc.SSS + objDeduc.PagIbig + objDeduc.PhilHealth) - (objDeduc.Absences * objSalary.RateInPesos);


            if (textBoxEmployeeID.Text == "20210617")
            {
                listBoxSalary.Items.Add("EmployeeID: " + objSalary.EmployeeID.ToString());
                listBoxSalary.Items.Add("Your salary is ₱" + objSalary.Salary.ToString());
            }
            else
            {
                MessageBox.Show("No EmployeeID found. Please try again.");
            }
            
        }
    }
}
