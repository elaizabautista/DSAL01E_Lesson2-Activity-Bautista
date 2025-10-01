using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAL01E_Lesson2_Activity_Bautista
{
    public partial class Example6 : Form
    {
    //declaration of global variables
        private string picpath;
        private Double basicnetincome = 0.00,
              basic_numhrs = 0.00,
              basic_rate = 0.00,
              hono_netincome = 0.00,
              hono_numhrs = 0.00,
              hono_rate = 0.00,
              other_netincome = 0.00,
              other_numhrs = 0.00,
              other_rate = 0.00;
        private Double netincome = 0.00,
              grossincome = 0.00,
              sss_contrib = 0.00,
              pagibig_contrib = 0.00,
              philhealth_contrib = 0.00,
              tax_contrib = 0.00;
        private Double sss_loan = 0.00,
           pagibig_loan = 0.00,
           salary_loan = 0.00,
           salary_savings = 0.00,
           faculty_sav_loan = 0.00,
           other_deduction = 0.00,
           total_deduction = 0.00,
           total_contrib = 0.00,
           total_loan = 0.00;

        private void other_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            other_numhrs = Convert.ToDouble(other_numhrsTxtbox.Text);
            other_rate = Convert.ToDouble(hono_rateTxtbox.Text);
            other_netincome = other_numhrs * other_rate;
            other_netincomeTxtbox.Text = other_netincome.ToString();
            grossincome =  basicnetincome + hono_netincome + other_netincome;
            gross_incomeTxtbox.Text += grossincome.ToString("n");
        }

        private void hono_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            hono_numhrs = Double.Parse(hono_numhrsTxtbox.Text);
            hono_rate = Convert.ToDouble(hono_rateTxtbox.Text);
            hono_netincome = hono_numhrs * hono_rate;
            hono_netincomeTxtbox.Text = hono_netincome.ToString("n");
        }

        private void basic_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            basic_numhrs = Double.Parse (basic_numhrsTxtbox.Text);
            basic_rate = Convert.ToDouble (basic_rateTxtbox.Text);
            basicnetincome = basic_numhrs * basic_rate;
            basicnetincome_Txtbox.Text = basicnetincome.ToString("n");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | * .gif; * .jpg; * .png; * .bmp";
            openFileDialog.Title = "Select Employee Picture";
            openFileDialog.ShowDialog();
            picpath = openFileDialog.FileName;
            picpathTxtbox.Text = picpath;
            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            emp_nuTxtbox.Clear();
            firstnameTxtbox.Clear();
            MNameTxtbox.Clear();
            surTxtbox.Clear();
            civil_statusTxtbox.Clear();
            desigTxtbox.Clear();
            numDependentTxtbox.Clear();
            empStatusTxtbox.Clear();
            DeptNameTxtbox.Clear();
            basicnetincome_Txtbox.Clear();
            basic_rateTxtbox.Clear();
            basic_numhrsTxtbox.Clear();
            hono_netincomeTxtbox.Clear();
            hono_numhrsTxtbox.Clear();
            hono_rateTxtbox.Clear();
            other_netincomeTxtbox.Clear();
            other_rateTxtbox.Clear();
            other_numhrsTxtbox.Clear();
            pagibig_contribTxtbox.Clear();
            philhealth_contribTxtbox.Clear();
            tax_contribTxtbox.Clear();
            sss_loanTxtbox.Clear();
            pagibig_loanTxtbox.Clear();
        }


        private void New_Click(object sender, EventArgs e)
        {
            emp_nuTxtbox.Clear();
            firstnameTxtbox.Clear();
            MNameTxtbox.Clear();
            surTxtbox.Clear();
            civil_statusTxtbox.Clear();
            desigTxtbox.Clear();
            numDependentTxtbox.Clear();
            empStatusTxtbox.Clear();
            DeptNameTxtbox.Clear();
            basicnetincome_Txtbox.Clear();
            basic_rateTxtbox.Clear();
            basic_numhrsTxtbox.Clear();
            hono_netincomeTxtbox.Clear();
            hono_numhrsTxtbox.Clear();
            hono_rateTxtbox.Clear();
            other_netincomeTxtbox.Clear();
            other_rateTxtbox.Clear();
            other_numhrsTxtbox.Clear();
            pagibig_contribTxtbox.Clear();
            philhealth_contribTxtbox.Clear();
            tax_contribTxtbox.Clear();
            sss_loanTxtbox.Clear();
            pagibig_loanTxtbox.Clear();
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

        private void PreviewPayslipDetails_Click(object sender, EventArgs e)
        {
            payslip_view_listbox.Items.Add("");
            payslip_view_listbox.Items.Add("Employee Number:     " + "" + emp_nuTxtbox.Text);
            payslip_view_listbox.Items.Add("First Name:     " + "" + firstnameTxtbox.Text);
            payslip_view_listbox.Items.Add("Middle Name:     " + "" + MNameTxtbox.Text);
            payslip_view_listbox.Items.Add("Surname:     " + "" + surTxtbox.Text);
            payslip_view_listbox.Items.Add("Designation:     " + "" + desigTxtbox.Text);
            payslip_view_listbox.Items.Add("Employee Status:     " + "" + empStatusTxtbox.Text);
            payslip_view_listbox.Items.Add("Department:     " + "" + DeptNameTxtbox.Text);
            payslip_view_listbox.Items.Add("Pay Date:     " + "" + paydateDatePicker.Text);
            payslip_view_listbox.Items.Add("---------------------------------------------------------------------------------------");
            payslip_view_listbox.Items.Add("BP Num. of Hours:     " + "P" + basic_numhrsTxtbox.Text);
            payslip_view_listbox.Items.Add("BP Rate / Hr.:     " + "P" + basic_rateTxtbox.Text);
            payslip_view_listbox.Items.Add("Basic Pay Income:     " + "P" + basicnetincome_Txtbox.Text);
            payslip_view_listbox.Items.Add("HI Num. of Hrs.:     " + "P" + hono_numhrsTxtbox.Text);
            payslip_view_listbox.Items.Add("HI Rate / Hr.:     " + "P" + hono_rateTxtbox.Text);
            payslip_view_listbox.Items.Add("Honorarium Income:     " + "P" + hono_netincomeTxtbox.Text);
            payslip_view_listbox.Items.Add("");
            payslip_view_listbox.Items.Add("OTI Num. of Hrs.:     " + "P" + other_numhrsTxtbox.Text);
            payslip_view_listbox.Items.Add("OTI Rate / Hr.:     " + "P" + other_rateTxtbox.Text);
            payslip_view_listbox.Items.Add("Other Income:     " + "P" + other_netincomeTxtbox.Text);
            payslip_view_listbox.Items.Add("---------------------------------------------------------------------------------------");
            payslip_view_listbox.Items.Add("SSS Contribution:     " + "P" + sss_contribTxtbox.Text);
            payslip_view_listbox.Items.Add("Philhealth Contribution:     " + "P" + philhealth_contribTxtbox.Text);
            payslip_view_listbox.Items.Add("Tax Contribution:     " + "P" + tax_contribTxtbox.Text);
            payslip_view_listbox.Items.Add("SSS Loan:      " + "P" + sss_loanTxtbox.Text);
            payslip_view_listbox.Items.Add("Pagibig Loan:     " + "P" + pagibig_loanTxtbox.Text);
            payslip_view_listbox.Items.Add("Faculty Savings Account:     " + "P" + FSD_depositTxtbox.Text);
            payslip_view_listbox.Items.Add("Faculty Savings Loan:     " + "P" + FS_loanTxtbox.Text);
            payslip_view_listbox.Items.Add("Salary Loan:     " + "P" + sal_loanTxtbox.Text);
            payslip_view_listbox.Items.Add("Other Loan:     " + "P" + otherLoanTxtbox.Text);
            payslip_view_listbox.Items.Add("---------------------------------------------------------------------------------------");
            payslip_view_listbox.Items.Add("Total Deduction:     " + "P" + total_deducTxtbox.Text);
            payslip_view_listbox.Items.Add("Gross Income:     " + "P" + gross_incomeTxtbox.Text);
            payslip_view_listbox.Items.Add("Net Income:     " + "P" + net_incomeTxtbox.Text);
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            //codes for converting input data from textboxes as string to numeric
            //codes for putting data from textboxes to variables
            sss_contrib = Convert.ToDouble(sss_contribTxtbox.Text);
            pagibig_contrib = Convert.ToDouble(pagibig_contribTxtbox.Text);
            philhealth_contrib = Convert.ToDouble(philhealth_contribTxtbox.Text);
            tax_contrib = Convert.ToDouble(tax_contribTxtbox.Text);
            sss_loan = Convert.ToDouble(sss_loanTxtbox.Text);
            pagibig_loan = Convert.ToDouble(pagibig_loanTxtbox.Text);
            salary_loan = Convert.ToDouble(sal_loanTxtbox.Text);
            faculty_sav_loan = Convert.ToDouble(FS_loanTxtbox.Text);
            salary_savings = Convert.ToDouble(FSD_depositTxtbox.Text);
            other_deduction = Convert.ToDouble(otherLoanTxtbox.Text);

            //formula to compute the desired data to be computed
            total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib + tax_contrib;
            total_loan = sss_loan + pagibig_loan + salary_loan + faculty_sav_loan + salary_savings + other_deduction;
            total_deduction = total_contrib + total_loan;

            //codes for converting numeric data to string and displayed it inside the textboxes
            total_deducTxtbox.Text = total_deduction.ToString();
            netincome = grossincome - total_deduction;
            net_incomeTxtbox.Text = netincome.ToString();

        }

        public Example6()
        {
            InitializeComponent();
        }
             
        private void Example6_Load(object sender, EventArgs e)
        {
            //codes for disabling textboxes
            basicnetincome_Txtbox.Enabled = false;
            hono_netincomeTxtbox.Enabled = false;
            other_netincomeTxtbox.Enabled = false;
            net_incomeTxtbox.Enabled = false;
            gross_incomeTxtbox.Enabled = false;
            total_deducTxtbox.Enabled = false;
            sss_contribTxtbox.Text = "0.00";
            pagibig_contribTxtbox.Text = "0.00";
            tax_contribTxtbox.Text = "0.00";
            sss_loanTxtbox.Text = "0.00";
            pagibig_loanTxtbox.Text = "0.00";
            FSD_depositTxtbox.Text = "0.00";
            FS_loanTxtbox.Text = "0.00";
            sal_loanTxtbox.Text = "0.00";
            otherLoanTxtbox.Text = "0.00";
            others_loanCombo.Text = "Select other deduction";
            others_loanCombo.Items.Add("Other 1");
            others_loanCombo.Items.Add("Other 2");
            others_loanCombo.Items.Add("Other 3");
            others_loanCombo.Items.Add("Other 4");
            picpathTxtbox.Hide();

        }
    }
}
