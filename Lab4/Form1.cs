/**
 * Grading ID:      L8486
 * Lab:             4
 * Course:          CIS199-72
 * Due:             10/3/19
 * Description:    A Windows Form application that make simple admission decisions for a hypothetical university based on specific rules.
 * 
 * Rules:
 *  The user enters a numeric high school grade point average (for example, 3.2) and an admission test score. Display the message “Accept” if the student meets either of the following requirements:
 *  A grade point average of 3.0 or higher and an admission test score of at least 60
 *  A grade point average of less than 3.0 and an admission test score of at least 80
 *  If the student does not meet either of the qualification criteria, display “Reject”.
 *  
 *  Icon credits: Smashicons (https://www.flaticon.com/authors/smashicons)
 **/

using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        // Constant variables
        private const double GPA_MIN = 3.0;             // Minimum GPA combined with TEST_SCORE_GPA_MIN needed to be accepted
        private const int TEST_SCORE_GPA_MIN = 60;      // Minimum test score combined with GPA_MIN needed to be accepted
        private const int TEST_SCORE_LOW_GPA_MIN = 80;  // Minimum test score needed if GPA is below TEST_SCORE_GPA_MIN to be accepted

        // Variables
        float gpa;              // Student's gpa
        int testScore;          // Student's admission test score
        int acceptCounter;    // Running total of admissions accepted
        int rejectCounter;    // Running total of admissions rejected

        public Form1()
        {
            InitializeComponent();
        }

        // When submit button is clicked or ENTER, try to parse input textboxes and validate input, return and display if student was accepted or rejected, then increment the counter for subsequent result.
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (float.TryParse(gpaTextBox.Text, out gpa) && gpa >= 0.00 && gpa <= 4.00)
            {
                if (int.TryParse(testScoreTextBox.Text, out testScore) && testScore >= 0 && testScore <= 100)
                {
                    if (gpaTextBox.Text == $"{gpa:f0}") { gpaTextBox.Text = $"{gpa:f1}"; } // Formatter for whole numbers only into proper double format with one decimal of percision
                    if ((gpa >= GPA_MIN && testScore >= TEST_SCORE_GPA_MIN) || (testScore >= TEST_SCORE_LOW_GPA_MIN))
                    {
                        resultLabel.ForeColor = Color.Green;
                        resultLabel.Text = "ACCEPT";
                        acceptCounter++;
                        acceptCountLabel.Text = $"{acceptCounter}";
                    }
                    else
                    {
                        resultLabel.ForeColor = Color.Red;
                        resultLabel.Text = "REJECT";
                        rejectCounter++;
                        rejectCountLabel.Text = $"{rejectCounter}";
                    }
                }
                else
                {
                    MessageBox.Show("Error!\nFailed to parse test score");
                }
            }
            else
            {
                MessageBox.Show("Error!\nFailed to parse GPA");
            }
        }

        // On clear button click or ESC, clear text boxes and result label, and select first textbox
        private void clearButton_Click(object sender, EventArgs e)
        {
            gpaTextBox.Text = "";
            testScoreTextBox.Text = "";
            resultLabel.Text = "";
            gpaTextBox.Select();
        }

        // On link label click, open icon credit author webpage
        private void iconCreditLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            iconCreditLinkLabel.LinkVisited = true;
            Process.Start("https://www.flaticon.com/authors/smashicons");
        }
    }
}