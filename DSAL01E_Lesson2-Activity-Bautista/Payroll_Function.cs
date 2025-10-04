using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAL01E_Lesson2_Activity_Bautista
{
    public partial class Payroll_Function : Form
    {
        private double basicIncome;
        private double honorariumIncome;
        private double otherIncome;
        private double grossIncome;
        private double totalDeductions;
        private double netIncome;
        private double taxContrib;

        public Payroll_Function()
        {
            InitializeComponent();
        }

        // Converts textbox value to double, returns 0 if invalid
        private double ParseValue(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
                return 0.0;
            double val;
            return double.TryParse(txt.Text.Replace(",", ""), out val) ? val : 0.0;
        }

        // Calculates incomes, gross income, and contributions
        private void grossincome_btn_Click(object sender, EventArgs e)
        {

            // Calculate basic, honorarium, and other incomes
            basicIncome = ParseValue(BIratehour_Txtbox) * ParseValue(BINoofHours_Txtbox);
            BIincomecutoff_Txtbox.Text = basicIncome.ToString("N2");

            honorariumIncome = ParseValue(HIratehour_Txtbox) * ParseValue(HINoofHours_Txtbox);
            HIincomecutoff_Txtbox.Text = honorariumIncome.ToString("N2");

            otherIncome = ParseValue(OIratehour_Txtbox) * ParseValue(OINoofHours_Txtbox);
            OIincomecutoff_Txtbox.Text = otherIncome.ToString("N2");

            grossIncome = basicIncome + honorariumIncome + otherIncome;
            grossincome_Txtbox.Text = grossIncome.ToString("N2");

            // -------------------------------
            // PhilHealth contribution based on 2025 table (5% rate)
            if (grossIncome < 10000)
            {
                philhealthcontribution_Txtbox.Text = "250.00";
            }
            else if (grossIncome > 10000 && grossIncome <= 11000)
            {
                philhealthcontribution_Txtbox.Text = ((11000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 11000 && grossIncome <= 12000)
            {
                philhealthcontribution_Txtbox.Text = ((12000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 12000 && grossIncome <= 13000)
            {
                philhealthcontribution_Txtbox.Text = ((13000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 13000 && grossIncome <= 14000)
            {
                philhealthcontribution_Txtbox.Text = ((14000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 14000 && grossIncome <= 15000)
            {
                philhealthcontribution_Txtbox.Text = ((15000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 15000 && grossIncome <= 16000)
            {
                philhealthcontribution_Txtbox.Text = ((16000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 16000 && grossIncome <= 17000)
            {
                philhealthcontribution_Txtbox.Text = ((17000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 17000 && grossIncome <= 18000)
            {
                philhealthcontribution_Txtbox.Text = ((18000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 18000 && grossIncome <= 19000)
            {
                philhealthcontribution_Txtbox.Text = ((19000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 19000 && grossIncome <= 20000)
            {
                philhealthcontribution_Txtbox.Text = ((20000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 20000 && grossIncome <= 21000)
            {
                philhealthcontribution_Txtbox.Text = ((21000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 21000 && grossIncome <= 22000)
            {
                philhealthcontribution_Txtbox.Text = ((22000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 22000 && grossIncome <= 23000)
            {
                philhealthcontribution_Txtbox.Text = ((23000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 23000 && grossIncome <= 24000)
            {
                philhealthcontribution_Txtbox.Text = ((24000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 24000 && grossIncome <= 25000)
            {
                philhealthcontribution_Txtbox.Text = ((25000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 25000 && grossIncome <= 26000)
            {
                philhealthcontribution_Txtbox.Text = ((26000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 26000 && grossIncome <= 27000)
            {
                philhealthcontribution_Txtbox.Text = ((27000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 27000 && grossIncome <= 28000)
            {
                philhealthcontribution_Txtbox.Text = ((28000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 28000 && grossIncome <= 29000)
            {
                philhealthcontribution_Txtbox.Text = ((29000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 29000 && grossIncome <= 30000)
            {
                philhealthcontribution_Txtbox.Text = ((30000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 30000 && grossIncome <= 31000)
            {
                philhealthcontribution_Txtbox.Text = ((31000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 31000 && grossIncome <= 32000)
            {
                philhealthcontribution_Txtbox.Text = ((32000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 32000 && grossIncome <= 33000)
            {
                philhealthcontribution_Txtbox.Text = ((33000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 33000 && grossIncome <= 34000)
            {
                philhealthcontribution_Txtbox.Text = ((34000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 34000 && grossIncome <= 35000)
            {
                philhealthcontribution_Txtbox.Text = ((35000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 35000 && grossIncome <= 36000)
            {
                philhealthcontribution_Txtbox.Text = ((36000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 36000 && grossIncome <= 37000)
            {
                philhealthcontribution_Txtbox.Text = ((37000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 37000 && grossIncome <= 38000)
            {
                philhealthcontribution_Txtbox.Text = ((38000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 38000 && grossIncome <= 39000)
            {
                philhealthcontribution_Txtbox.Text = ((39000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 39000 && grossIncome <= 40000)
            {
                philhealthcontribution_Txtbox.Text = ((40000 * 0.05) / 2).ToString("N2");
            }
            else if (grossIncome > 40000 && grossIncome <= 100000)
            {
                philhealthcontribution_Txtbox.Text = ((grossIncome * 0.05) / 2).ToString("N2");
            }
            else
            {
                philhealthcontribution_Txtbox.Text = "2500.00";
            }

            // SSS contribution (2025 Employee Share only, based on uploaded table)
            if (grossIncome < 5250.00)
            {
                SSScontribution_Txtbox.Text = "250.00";
            }
            else if (grossIncome >= 5250.00 && grossIncome <= 5749.99)
            {
                SSScontribution_Txtbox.Text = "275.00";
            }
            else if (grossIncome >= 5750.00 && grossIncome <= 6249.99)
            {
                SSScontribution_Txtbox.Text = "300.00";
            }
            else if (grossIncome >= 6250.00 && grossIncome <= 6749.99)
            {
                SSScontribution_Txtbox.Text = "325.00";
            }
            else if (grossIncome >= 6750.00 && grossIncome <= 7249.99)
            {
                SSScontribution_Txtbox.Text = "350.00";
            }
            else if (grossIncome >= 7250.00 && grossIncome <= 7749.99)
            {
                SSScontribution_Txtbox.Text = "375.00";
            }
            else if (grossIncome >= 7750.00 && grossIncome <= 8249.99)
            {
                SSScontribution_Txtbox.Text = "400.00";
            }
            else if (grossIncome >= 8250.00 && grossIncome <= 8749.99)
            {
                SSScontribution_Txtbox.Text = "425.00";
            }
            else if (grossIncome >= 8750.00 && grossIncome <= 9249.99)
            {
                SSScontribution_Txtbox.Text = "450.00";
            }
            else if (grossIncome >= 9250.00 && grossIncome <= 9749.99)
            {
                SSScontribution_Txtbox.Text = "475.00";
            }
            else if (grossIncome >= 9750.00 && grossIncome <= 10249.99)
            {
                SSScontribution_Txtbox.Text = "500.00";
            }
            else if (grossIncome >= 10250.00 && grossIncome <= 10749.99)
            {
                SSScontribution_Txtbox.Text = "525.00";
            }
            else if (grossIncome >= 10750.00 && grossIncome <= 11249.99)
            {
                SSScontribution_Txtbox.Text = "550.00";
            }
            else if (grossIncome >= 11250.00 && grossIncome <= 11749.99)
            {
                SSScontribution_Txtbox.Text = "575.00";
            }
            else if (grossIncome >= 11750.00 && grossIncome <= 12249.99)
            {
                SSScontribution_Txtbox.Text = "600.00";
            }
            else if (grossIncome >= 12250.00 && grossIncome <= 12749.99)
            {
                SSScontribution_Txtbox.Text = "625.00";
            }
            else if (grossIncome >= 12750.00 && grossIncome <= 13249.99)
            {
                SSScontribution_Txtbox.Text = "650.00";
            }
            else if (grossIncome >= 13250.00 && grossIncome <= 13749.99)
            {
                SSScontribution_Txtbox.Text = "675.00";
            }
            else if (grossIncome >= 13750.00 && grossIncome <= 14249.99)
            {
                SSScontribution_Txtbox.Text = "700.00";
            }
            else if (grossIncome >= 14250.00 && grossIncome <= 14749.99)
            {
                SSScontribution_Txtbox.Text = "725.00";
            }
            else if (grossIncome >= 14750.00 && grossIncome <= 15249.99)
            {
                SSScontribution_Txtbox.Text = "750.00";
            }
            else if (grossIncome >= 15250.00 && grossIncome <= 15749.99)
            {
                SSScontribution_Txtbox.Text = "775.00";
            }
            else if (grossIncome >= 15750.00 && grossIncome <= 16249.99)
            {
                SSScontribution_Txtbox.Text = "800.00";
            }
            else if (grossIncome >= 16250.00 && grossIncome <= 16749.99)
            {
                SSScontribution_Txtbox.Text = "825.00";
            }
            else if (grossIncome >= 16750.00 && grossIncome <= 17249.99)
            {
                SSScontribution_Txtbox.Text = "850.00";
            }
            else if (grossIncome >= 17250.00 && grossIncome <= 17749.99)
            {
                SSScontribution_Txtbox.Text = "875.00";
            }
            else if (grossIncome >= 17750.00 && grossIncome <= 18249.99)
            {
                SSScontribution_Txtbox.Text = "900.00";
            }
            else if (grossIncome >= 18250.00 && grossIncome <= 18749.99)
            {
                SSScontribution_Txtbox.Text = "925.00";
            }
            else if (grossIncome >= 18750.00 && grossIncome <= 19249.99)
            {
                SSScontribution_Txtbox.Text = "950.00";
            }
            else if (grossIncome >= 19250.00 && grossIncome <= 19749.99)
            {
                SSScontribution_Txtbox.Text = "975.00";
            }
            else if (grossIncome >= 19750.00 && grossIncome <= 20249.99)
            {
                SSScontribution_Txtbox.Text = "1000.00";
            }
            else
            {
                // Max contribution cap at 1000 employee share (per new 2025 table)
                SSScontribution_Txtbox.Text = "1000.00";
            }

            // TAX contribution (if-else block)
            if (grossIncome < (250000.0 / 12))
            {
                incometaxcontribution_Txtbox.Text = "0.00";
            }
            else if (grossIncome > 20833.33 && grossIncome <= 33333.33)
            {
                taxContrib = ((grossIncome - 20833.33) * 0.15);
                incometaxcontribution_Txtbox.Text = taxContrib.ToString("n");
            }
            else if (grossIncome > 33333.33 && grossIncome <= 66666.67)
            {
                taxContrib = (1875 + ((grossIncome - 33333.33) * 0.20));
                incometaxcontribution_Txtbox.Text = taxContrib.ToString("n");
            }
            else if (grossIncome > 66666.67 && grossIncome <= 166666.67)
            {
                taxContrib = (8541.80 + ((grossIncome - 66666.67) * 0.25));
                incometaxcontribution_Txtbox.Text = taxContrib.ToString("n");
            }
            else if (grossIncome > 166666.67 && grossIncome <= 666666.67)
            {
                taxContrib = (33541.80 + ((grossIncome - 166666.67) * 0.30));
                incometaxcontribution_Txtbox.Text = taxContrib.ToString("n");
            }
            else // above ₱666,666.67
            {
                taxContrib = (183541.80 + ((grossIncome - 666666.67) * 0.35));
                incometaxcontribution_Txtbox.Text = taxContrib.ToString("n");
            }
        }

        private double GetPhilHealthContribution(double grossIncome)
        {
            double contribution = grossIncome * 0.05 / 2; // 5% shared by employee/employer
            if (contribution < 250) return 250;
            if (contribution > 2500) return 2500;
            return contribution;
        }

        // Calculates total deductions and net income
        private void netincome_btn_Click(object sender, EventArgs e)
        {

            double sss = ParseValue(SSScontribution_Txtbox);
            double philhealth = ParseValue(philhealthcontribution_Txtbox);
            double incometax = ParseValue(incometaxcontribution_Txtbox);
            double pagibigContribution = ParseValue(pagibigcontribution_Txtbox);

            double sssLoan = ParseValue(SSSloan_Txtbox);
            double pagibigLoan = ParseValue(pagibigloan_Txtbox);
            double facultySavingsDeposit = ParseValue(facultysavingsdeposit_Txtbox);
            double facultySavingsLoan = ParseValue(facultysavingsloan_Txtbox);
            double salaryLoan = ParseValue(salaryloan_Txtbox);
            double otherLoans = ParseValue(otherloans_Txtbox);

            totalDeductions = sss + philhealth + incometax + pagibigContribution +
                              sssLoan + pagibigLoan + facultySavingsDeposit +
                              facultySavingsLoan + salaryLoan + otherLoans;

            totaldeduction_Txtbox.Text = totalDeductions.ToString("N2");

            netIncome = grossIncome - totalDeductions;
            netincome_Txtbox.Text = netIncome.ToString("N2");
        }


        // Loads an image into pictureBox1
        private void browse_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            // Clears all textboxes on the form
            BIratehour_Txtbox.Clear();
            BINoofHours_Txtbox.Clear();
            BIincomecutoff_Txtbox.Clear();

            HIratehour_Txtbox.Clear();
            HINoofHours_Txtbox.Clear();
            HIincomecutoff_Txtbox.Clear();

            OIratehour_Txtbox.Clear();
            OINoofHours_Txtbox.Clear();
            OIincomecutoff_Txtbox.Clear();

            grossincome_Txtbox.Clear();

            SSScontribution_Txtbox.Clear();
            philhealthcontribution_Txtbox.Clear();
            pagibigcontribution_Txtbox.Clear();
            incometaxcontribution_Txtbox.Clear();

            SSSloan_Txtbox.Clear();
            pagibigloan_Txtbox.Clear();
            facultysavingsdeposit_Txtbox.Clear();
            facultysavingsloan_Txtbox.Clear();
            salaryloan_Txtbox.Clear();
            otherloans_Txtbox.Clear();

            totaldeduction_Txtbox.Clear();
            netincome_Txtbox.Clear();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            // Combine first name, middle name, and surname 
            string fullName = firstname_Txtbox.Text + " " + middlename_Txtbox.Text + " " + surname_Txtbox.Text;

            //for the paydate
            string paydate = paydate_Txtbox.Text;

            // Create and show the PayslipReport form with all necessary data
            PayslipReport payslip = new PayslipReport(

            employeeno_Txtbox.Text,
            fullName, //combined name
            paydate,   // cutoff
            paydate,   // payperiod (same value as cutoff)

            "College of Engineering, Computer Studies and Architecture",

            basicIncome,
            honorariumIncome,
            otherIncome,
            grossIncome,
            totalDeductions,
            netIncome,
            SSScontribution_Txtbox.Text,
            philhealthcontribution_Txtbox.Text,
            pagibigcontribution_Txtbox.Text,
            incometaxcontribution_Txtbox.Text
        );
            payslip.ShowDialog();
        }
    }
}