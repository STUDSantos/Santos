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
    public partial class StuFrmReg : Form
    {
        public StuFrmReg()
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
            string[] courses = { "BSIT", "BSTM", "BSP", "BSBA", "BSHM", };
            {
                
                for (int i = 0; i < courses.Length; i++)
                {
                    cmbPrograms.Items.Add(courses[i]);
                }
                    
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
            string firstName = txtLastName.Text;
            string lastName = txtFirstName.Text;


            string gender = "";

            if (radMale.Checked)
            {
                gender = "Male";
            }
            else if (radFemale.Checked)
            {
                gender = "Female";
            }

            string days = cmbDay.SelectedItem?.ToString();
            string months = cmbMonth.SelectedItem?.ToString();
            string years = cmbYear.SelectedItem?.ToString();
            string programs = cmbPrograms.SelectedItem?.ToString();

            MessageBox.Show(
             "STUDENT INFORMATION\n\n" +
             "STUDENT NAME: " + firstName + " " + lastName + "\n\n" +
             "GENDER: " + gender + "\n\n" +
             "DAY OF BIRTH: " + months + "/" + days + "/" + years + "\n\n",
             "Program: " + programs + "\n\n",
              MessageBoxButtons.OK,
             MessageBoxIcon.Information);
        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void cmbPrograms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}