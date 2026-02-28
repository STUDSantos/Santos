using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DecisionMakingApp
{
    public partial class StudentGradeProgram : Form
    {
        public StudentGradeProgram()
        {
            InitializeComponent();
            lblOutput.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = TBName.Text;

                double english = double.Parse(TBEnglish.Text);
                double math = double.Parse(TBMath.Text);
                double science = double.Parse(TBScience.Text);
                double filipino = double.Parse(TBFilipino.Text);
                double history = double.Parse(TBHistory.Text);

                double average = (english + math + science + filipino + history) / 5;

                lblOutput.Text = "The Student passed. " +
                                 $"\nThe General Average of {name} is {average:F2}.";

                lblOutput.Visible = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number entered is too large or too small.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
