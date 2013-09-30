/// <summary>
/// App Name: Bonus Checker
/// Author Name: John Earle
/// App Creation Date: 26/09/2013
/// 
/// App Description: This tool will calcuate an employees sales bonus
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        char dollarSign = '$';
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHours_TextChanged(object sender, EventArgs e)
        {
        }
        
        //Waits for validation to return true the calculates the sales bonus
        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                char[] dollarSign = { '$' };
                var unformattedMonthly = txtMonthly.Text.Trim(dollarSign);
                var hours = Convert.ToDouble(txtHours.Text);
                var monthly = Convert.ToDouble(unformattedMonthly);
                txtBonus.Text = string.Format("${0:0.00}", Convert.ToString(Math.Round(((hours / 160) * (monthly * 0.02)), 2)));
            }
            else
            {
                MessageBox.Show("Please Fill The Boxes Properly");
            }
       }
        // Validation is simple regex rules to search for . and char where there should be numbers so on and so forth
        private bool validate()
        {
            if (valTxtName())
            {
                if (valTxtMonthly())
                {
                    if (valTxtName())
                    {
                    }
                }
                return true;
            }
            else{
                MessageBox.Show("Please fill all boxes correctly");
                return false; 
            }
        }

        private bool valTxtName()
        {
            var regStr = @"^.*\d.*$";
            if (txtName.Text == "" || Regex.IsMatch(txtName.Text, regStr))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool valTxtId()
        {
            var regStr = @"^.*\D.*$";
            if (txtId.Text == "" || Regex.IsMatch(txtId.Text, regStr))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool valTxtMonthly()
        {
            var regStr = @"^.*[^\d|^\.]\..*$";
            var regStr2 = @"^.*\..*$";
            var monthly = txtMonthly.Text.Trim(dollarSign);
            if (monthly == "" || Regex.IsMatch(monthly, regStr))
            {
                return false;
            }
            else
            {

                if (Regex.IsMatch(monthly, regStr2))
                {
                    var formatedNumber = Math.Round(Convert.ToDouble(monthly), 2);
                    txtMonthly.Text = string.Format("${0:0.00}", Convert.ToString(formatedNumber));
                }
                else
                {
                    var unformatedNumber = Math.Round(Convert.ToDouble(monthly),2);
                    txtMonthly.Text = string.Format("${0:0.00}", Convert.ToString(unformatedNumber));
                }
                return true;
            }
        }
        //When The name sales text box loses focus it runs valTxtName() for validation and changes the background color accordingly.
        private void txtName_Leave(object sender, EventArgs e)
        {

            if (valTxtName())
            {
                txtName.BackColor = System.Drawing.Color.White;
            }
            else if(!valTxtName()){
                txtName.BackColor = System.Drawing.Color.Red;
            }
        }
       //Irritatingly ineffciate first attempt validation.
        private void txtHours_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtHours.Text) <= 160 & Convert.ToInt32(txtHours.Text) >= 0)
                {


                }
                else
                {
                    MessageBox.Show("Please Enter A Value Between 160 and 0");
                    txtHours.Text = "";
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Please Enter A Value Between 160 and 0");
            }
        }
        //When The ID text box loses focus it runs valTxtId() for validation and changes the background color accordingly.
        private void txtId_Leave(object sender, EventArgs e)
        {
            if (valTxtId())
            {
                txtId.BackColor = System.Drawing.Color.White;
            }
            else if (!valTxtId())
            {
                txtId.BackColor = System.Drawing.Color.Red;
            }
        }
        //When The monthly sales text box loses focus it runs valTxtMonthly() for validation and changes the background color accordingly.
        private void txtMonthly_Leave(object sender, EventArgs e)
        {
            
            if (valTxtMonthly())
            {
                txtMonthly.BackColor = System.Drawing.Color.White;
            }
            else if (!valTxtMonthly())
            {
                txtMonthly.BackColor = System.Drawing.Color.Red;
            }
        }
        /*When The Monthly sales text box is entered the present value before user input is trimmed of the dollar sign
         so it will not interfer with the regex later on        
         */
        private void txtMonthly_Enter(object sender, EventArgs e)
        {
            var unformattedMonthly = txtMonthly.Text.Trim(dollarSign);
            txtMonthly.Text = unformattedMonthly;
        }
        //When the next button is clicked all fields are emptied
        private void btnNext_Click(object sender, EventArgs e)
        {
            txtBonus.Text = "";
            txtName.Text = "";
            txtId.Text = "";
            txtMonthly.Text = "";

        }
        /*
         * Becuase there are two radio buttons in the event of any selection each ones state will be changed
         * when changed it checks the users selection and sends true to changeLanguage() for english and vise versa.
         * True and False not having any contextual value more so the small size of bool
         */
        private void radioEnglish_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFrench.Checked == true)
            {
                changeLanguage(false);
            }
            else if (radioEnglish.Checked)
            {
                changeLanguage(true);
            }
        }
        /*Change Language Holds all english and french labels in a 2 dimensonal array; 
         * [0,*] being english and [1,*] being french
         * the nth index in [*,nth] being a number from to seven of each visable title from top left to bottom too
         * top right to bottom
         * if parameter "Lang" is true english is set and vise-versa
         */
        private void changeLanguage(Boolean lang)
        {
            int arrayDepth;
            String[,] Language = new String[2, 10];
            Language[1, 0] = "Nom de l'employé";
            Language[1, 1] = "Identification du salarié";
            Language[1, 2] = "heures travaillées";
            Language[1, 3] = "ventes mensuelles";
            Language[1, 4] = "langue";
            Language[1, 5] = "prime de vente";
            Language[1, 6] = "calculer";
            Language[1, 7] = "prochaine";
            Language[0, 0] = "Employee Name";
            Language[0, 1] = "Employee ID";
            Language[0, 2] = "Total Hours Worked";
            Language[0, 3] = "Total Monthly Sales";
            Language[0, 4] = "Language";
            Language[0, 5] = "Sales Bonus";
            Language[0, 6] = "Calculate";
            Language[0, 7] = "Next";
            if (lang)
            {
                arrayDepth = 0;
            }
            else
            {
                arrayDepth = 1;
            }
            lbName.Text = Language[arrayDepth, 0];
            lbId.Text = Language[arrayDepth, 1];
            lbHours.Text = Language[arrayDepth, 2];
            lbMonthly.Text = Language[arrayDepth, 3];
            gbLang.Text = Language[arrayDepth, 4];
            lbBonus.Text = Language[arrayDepth, 5];
            btnCalc.Text = Language[arrayDepth, 6];
            btnNext.Text = Language[arrayDepth, 7];

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        }

        private void printDocument1_PrintPage()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
