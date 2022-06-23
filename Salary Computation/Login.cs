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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (username == "IsabelIT" && password == "ilovecsharp00")
            {
                if (radioButtonSalaryComp.Checked)
                {
                    PayrollSystem salaryComp = new PayrollSystem();
                    salaryComp.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password, Please try again.");
            }
           
        }

        private void checkBoxShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowHide.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }    
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void radioButtonSalaryComp_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
