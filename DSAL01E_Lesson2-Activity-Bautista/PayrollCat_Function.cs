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
    public partial class PayrollCat_Function : Form
    {
        // Global variables
        private string picpath;
        private double basicnetincome, basic_numhrs, basic_rate;
        private double hono_netincome, hono_numhrs, hono_rate;
        private double other_netincome, other_numhrs, other_rate;
        private double netincome, grossincome;
        private double sss_contrib, pagibig_contrib = 100, philhealth_contrib, tax_contrib;
        private double sss_loan, pagibig_loan, salary_loan, faculty_sav_loan, other_deduction, salary_savings;
        private double total_deduction;

        // Contribution tables
        private readonly double[] philRanges = { 10000, 11000, 12000, 13000, 14000, 15000, 16000, 17000, 18000, 19000, 20000,
                                21000, 22000, 23000, 24000, 25000, 26000, 27000, 28000, 29000, 30000,
                                31000, 32000, 33000, 34000, 35000, 36000, 37000, 38000, 39000 };
        private readonly double[] philAmounts = { 137.50, 151.25, 165.00, 178.75, 192.50, 206.25, 220.00, 233.75, 247.50, 261.25,
                                 275.25, 288.75, 302.50, 316.25, 330.00, 343.75, 357.50, 371.25, 385.00, 398.75,
                                 412.50, 426.25, 440.00, 453.75, 467.50, 481.25, 495.00, 508.75, 522.50, 536.25 };

        private readonly double[] sssRanges = { 1000, 1249.99, 1749.99, 2249.99, 2749.99, 3249.99, 3749.99, 4249.99,
                               4749.99, 5249.99, 5749.99, 6249.99, 6749.99, 7249.99, 7749.99, 8249.99,
                               8749.99, 9249.99, 9749.99, 10249.99, 10749.99, 11249.99, 11749.99, 12249.99,
                               12749.99, 13249.99, 13749.99, 14249.99, 14749.99, 15249.99, 15749.99, 16249.99 };
        private readonly double[] sssAmounts = { 0.00, 36.30, 54.50, 72.70, 90.80, 109.00, 127.20, 145.30,
                                163.50, 181.70, 199.80, 218.00, 236.20, 254.30, 272.50, 290.70,
                                308.80, 327.00, 345.20, 363.30, 381.50, 399.70, 417.80, 436.00,
                                454.20, 472.30, 490.50, 508.70, 526.80, 545.00, 563.20, 581.30 };
        
        public PayrollCat_Function()
        {
            InitializeComponent();
        }

        private void PayrollCat_Function_Load(object sender, EventArgs e)
        {
            others_loanCombo.Items.Add("Other 1");
            others_loanCombo.Items.Add("Other 2");
            others_loanCombo.Items.Add("Other 3");
            others_loanCombo.Items.Add("Other 4");
            others_loanCombo.Text = "Select other deduction";
            picpathTxtbox.Hide();
        }

        // ===== TextChanged Events =====
        private void basic_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            basic_numhrs = double.TryParse(basic_numhrsTxtbox.Text, out double val) ? val : 0;
            basic_rate = double.TryParse(basic_rateTxtbox.Text, out val) ? val : 0;
            basicnetincome = CalculateIncome(basic_numhrs, basic_rate);
            basicnetincome_Txtbox.Text = basicnetincome.ToString("n");
            UpdateContributions();
        }

        private void hono_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            hono_numhrs = double.TryParse(hono_numhrsTxtbox.Text, out double val) ? val : 0;
            hono_rate = double.TryParse(hono_rateTxtbox.Text, out val) ? val : 0;
            hono_netincome = CalculateIncome(hono_numhrs, hono_rate);
            hono_netincomeTxtbox.Text = hono_netincome.ToString("n");
            UpdateContributions();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            // Create an array of all textboxes
            TextBox[] textboxes = {
            emp_nuTxtbox, firstnameTxtbox, MNameTxtbox, surTxtbox, civil_statusTxtbox,
            desigTxtbox, numDependentTxtbox, empStatusTxtbox, DeptNameTxtbox,
            basicnetincome_Txtbox, basic_rateTxtbox, basic_numhrsTxtbox,
            hono_netincomeTxtbox, hono_numhrsTxtbox, hono_rateTxtbox,
            other_netincomeTxtbox, other_rateTxtbox, other_numhrsTxtbox,
            pagibig_contribTxtbox, philhealth_contribTxtbox, tax_contribTxtbox,
            sss_loanTxtbox, pagibig_loanTxtbox
};

            // Loop through and clear each textbox
            foreach (var tb in textboxes)
            {
                tb.Clear();
            }
        }

        private void New_Click(object sender, EventArgs e)
        {
            // Create an array of all textboxes
            TextBox[] textboxes = {
            emp_nuTxtbox, firstnameTxtbox, MNameTxtbox, surTxtbox, civil_statusTxtbox,
            desigTxtbox, numDependentTxtbox, empStatusTxtbox, DeptNameTxtbox,
            basicnetincome_Txtbox, basic_rateTxtbox, basic_numhrsTxtbox,
            hono_netincomeTxtbox, hono_numhrsTxtbox, hono_rateTxtbox,
            other_netincomeTxtbox, other_rateTxtbox, other_numhrsTxtbox,
            pagibig_contribTxtbox, philhealth_contribTxtbox, tax_contribTxtbox,
            sss_loanTxtbox, pagibig_loanTxtbox
};

            // Loop through and clear each textbox
            foreach (var tb in textboxes)
            {
                tb.Clear();
            }
        }

        private void other_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            other_numhrs = double.TryParse(other_numhrsTxtbox.Text, out double val) ? val : 0;
            other_rate = double.TryParse(other_rateTxtbox.Text, out val) ? val : 0;
            other_netincome = CalculateIncome(other_numhrs, other_rate);
            other_netincomeTxtbox.Text = other_netincome.ToString("n");
            UpdateContributions();
        }

        // ===== Calculation Methods =====
        private double CalculateIncome(double hours, double rate) => hours * rate;

        private void UpdateContributions()
        {
            UpdateGross();
            UpdatePhilHealth();
            UpdateSSS();
            UpdateTax();
        }

        private void UpdateGross()
        {
            grossincome = basicnetincome + hono_netincome + other_netincome;
            gross_incomeTxtbox.Text = grossincome.ToString("n");
            pagibig_contribTxtbox.Text = pagibig_contrib.ToString("n");
        }

        private void UpdatePhilHealth()
        {
            philhealth_contrib = philAmounts.Last(); // default max
            for (int i = 0; i < philRanges.Length; i++)
            {
                if (grossincome <= philRanges[i])
                {
                    philhealth_contrib = philAmounts[i];
                    break;
                }
            }
            philhealth_contribTxtbox.Text = philhealth_contrib.ToString("n");
        }

        private void UpdateSSS()
        {
            sss_contrib = sssAmounts.Last();
            for (int i = 0; i < sssRanges.Length; i++)
            {
                if (grossincome <= sssRanges[i])
                {
                    sss_contrib = sssAmounts[i];
                    break;
                }
            }
            sss_contribTxtbox.Text = sss_contrib.ToString("n");
        }

        private void UpdateTax()
        {
            double annualGross = grossincome * 24;
            if (grossincome <= 10416.67) tax_contrib = 0;
            else if (grossincome <= 16666.67) tax_contrib = ((annualGross - 250000) * 0.2) / 24;
            else if (grossincome <= 33333.33) tax_contrib = (((annualGross - 400000) * 0.25 + 30000) / 24);
            else if (grossincome <= 83333.33) tax_contrib = (((annualGross - 800000) * 0.30 + 130000) / 24);
            else if (grossincome <= 333333.33) tax_contrib = (((annualGross - 2000000) * 0.32 + 490000) / 24);
            else tax_contrib = (((annualGross - 8000000) * 0.35 + 2410000) / 24);
            tax_contribTxtbox.Text = tax_contrib.ToString("n");
        }

        private void UpdateOtherLoan()
        {
            if (others_loanCombo.Text == "Other 1") otherLoanTxtbox.Text = "500.00";
            else if (others_loanCombo.Text == "Other 2") otherLoanTxtbox.Text = "550.00";
            else if (others_loanCombo.Text == "Other 3") otherLoanTxtbox.Text = "1550.00";
            else if (others_loanCombo.Text == "Other 4") otherLoanTxtbox.Text = "1250.00";
            else MessageBox.Show("No other loan option selected!");
        }

        private void ComputeTotals()
        {
            sss_loan = double.TryParse(sss_loanTxtbox.Text, out double val) ? val : 0;
            pagibig_loan = double.TryParse(pagibig_loanTxtbox.Text, out val) ? val : 0;
            salary_loan = double.TryParse(sal_loanTxtbox.Text, out val) ? val : 0;
            faculty_sav_loan = double.TryParse(FS_loanTxtbox.Text, out val) ? val : 0;
            salary_savings = double.TryParse(FSD_depositTxtbox.Text, out val) ? val : 0;
            other_deduction = double.TryParse(otherLoanTxtbox.Text, out val) ? val : 0;

            total_deduction = sss_contrib + pagibig_contrib + philhealth_contrib + tax_contrib +
                              sss_loan + pagibig_loan + salary_loan + faculty_sav_loan + salary_savings + other_deduction;

            total_deducTxtbox.Text = total_deduction.ToString("n");
            netincome = grossincome - total_deduction;
            net_incomeTxtbox.Text = netincome.ToString("n");
        }

        // ===== Payslip Display =====
        private void PreviewPayslipDetails_Click(object sender, EventArgs e)
        {
            payslip_view_listbox.Items.Clear();

            AddPayslipLine("Employee Number", emp_nuTxtbox.Text);
            AddPayslipLine("First Name", firstnameTxtbox.Text);
            AddPayslipLine("Middle Name", MNameTxtbox.Text);
            AddPayslipLine("Surname", surTxtbox.Text);
            AddPayslipLine("Designation", desigTxtbox.Text);
            AddPayslipLine("Employee Status", empStatusTxtbox.Text);
            AddPayslipLine("Department", DeptNameTxtbox.Text);
            AddPayslipLine("Pay Date", paydateDatePicker.Text);
            payslip_view_listbox.Items.Add(new string('-', 70));

            AddPayslipLine("BP Num. of Hours", basic_numhrsTxtbox.Text);
            AddPayslipLine("BP Rate / Hr.", basic_rateTxtbox.Text);
            AddPayslipLine("Basic Pay Income", basicnetincome_Txtbox.Text);

            AddPayslipLine("HI Num. of Hrs.", hono_numhrsTxtbox.Text);
            AddPayslipLine("HI Rate / Hr.", hono_rateTxtbox.Text);
            AddPayslipLine("Honorarium Income", hono_netincomeTxtbox.Text);

            AddPayslipLine("OTI Num. of Hrs.", other_numhrsTxtbox.Text);
            AddPayslipLine("OTI Rate / Hr.", other_rateTxtbox.Text);
            AddPayslipLine("Other Income", other_netincomeTxtbox.Text);

            payslip_view_listbox.Items.Add(new string('-', 70));

            AddPayslipLine("SSS Contribution", sss_contribTxtbox.Text);
            AddPayslipLine("Philhealth Contribution", philhealth_contribTxtbox.Text);
            AddPayslipLine("Tax Contribution", tax_contribTxtbox.Text);
            AddPayslipLine("SSS Loan", sss_loanTxtbox.Text);
            AddPayslipLine("Pagibig Loan", pagibig_loanTxtbox.Text);
            AddPayslipLine("Faculty Savings Account", FSD_depositTxtbox.Text);
            AddPayslipLine("Faculty Savings Loan", FS_loanTxtbox.Text);
            AddPayslipLine("Salary Loan", sal_loanTxtbox.Text);
            AddPayslipLine("Other Loan", otherLoanTxtbox.Text);

            payslip_view_listbox.Items.Add(new string('-', 70));
            AddPayslipLine("Total Deduction", total_deducTxtbox.Text);
            AddPayslipLine("Gross Income", gross_incomeTxtbox.Text);
            AddPayslipLine("Net Income", net_incomeTxtbox.Text);
        }

        private void AddPayslipLine(string label, string value)
        {
            payslip_view_listbox.Items.Add($"{label}:     {value}");
        }

        private void PrintPayslip_Click(object sender, EventArgs e)
        {
            //codes for calling the other form connected to the current form
            PrintExample6 print1 = new PrintExample6();
            //codes for displaying the contents of the listbox from other form to the current form.
            print1.priDisplaylistbox.Items.AddRange(this.payslip_view_listbox.Items);
            //code for displaying the other form
            print1.Show();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            ComputeTotals();
        }

        private void others_loanCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateOtherLoan();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
