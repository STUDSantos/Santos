using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApp
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {
            for (int day = 1; day <= 31; day++)
            {
                cmbDay.Items.Add(day);
            }

            for (int month = 1; month <= 12; month++)
            {
                cmbMonth.Items.Add(month);
            }

            for (int year = 1900; year <= DateTime.Now.Year; year++)
            {
                cmbYear.Items.Add(year);
            }
        }

        private void TB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string address = txtAddress.Text;

            string gender = "";

            if (radMale.Checked)
            {
                gender = "Male";
            }
            else if (radFemale.Checked)
            {
                gender = "Female";
            }

            string day = cmbDay.SelectedItem?.ToString();
            string month = cmbMonth.SelectedItem?.ToString();
            string year = cmbYear.SelectedItem?.ToString();

            MessageBox.Show(
             "STUDENT INFORMATION\n\n" +
             "FIRST NAME: " + firstName + "\n\n" +
             "LAST NAME: " + lastName + "\n\n" +
             "ADDRESS: " + address + "\n\n" +
             "GENDER: " + gender + "\n\n" +
             "BIRTHDATE: " + month + "/" + day + "/" + year,
             "Registration Complete",
             MessageBoxButtons.OK,
             MessageBoxIcon.Information);
        }
}
}
