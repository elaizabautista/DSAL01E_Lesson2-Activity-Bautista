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

        private void others_loanCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Others loan
            if (others_loanCombo.Text == "Other 1")
            {
                otherLoanTxtbox.Text = "500.00";
            }
            else if (others_loanCombo.Text == "Other 2")
            {
                otherLoanTxtbox.Text = "550.00";
            }
            else if (others_loanCombo.Text == "Other 3")
            {
                otherLoanTxtbox.Text = "1550.00";
            }
            else if (others_loanCombo.Text == "Other 4")
            {
                otherLoanTxtbox.Text = "1250.00";
            }
            else
            {
                MessageBox.Show("No other loan option selected!");
            }
        }

        private void other_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                other_numhrs = Convert.ToDouble(other_numhrsTxtbox.Text);
                other_rate = Convert.ToDouble(hono_rateTxtbox.Text);
                other_netincome = other_numhrs * other_rate;
                other_netincomeTxtbox.Text = other_netincome.ToString();
                grossincome = basicnetincome + hono_netincome + other_netincome;
                gross_incomeTxtbox.Text = grossincome.ToString("n");
                pagibig_contribTxtbox.Text = "100.00";

                //philhealth contribution based from the current table
                if (grossincome < 10000)
                {
                    philhealth_contribTxtbox.Text = "137.50";
                }
                else if (grossincome > 10000 && grossincome <= 11000)
                {
                    philhealth_contribTxtbox.Text = "151.25";
                }
                else if (grossincome > 11000 && grossincome <= 12000)
                {
                    philhealth_contribTxtbox.Text = "165.00";
                }
                else if (grossincome > 12000 && grossincome <= 13000)
                {
                    philhealth_contribTxtbox.Text = "178.75";
                }
                else if (grossincome > 13000 && grossincome <= 14000)
                {
                    philhealth_contribTxtbox.Text = "192.50";
                }
                else if (grossincome > 14000 && grossincome <= 15000)
                {
                    philhealth_contribTxtbox.Text = "206.25";
                }
                else if (grossincome > 15000 && grossincome <= 16000)
                {
                    philhealth_contribTxtbox.Text = "220.00";
                }
                else if (grossincome > 16000 && grossincome <= 17000)
                {
                    philhealth_contribTxtbox.Text = "233.75";
                }
                else if (grossincome > 17000 && grossincome <= 18000)
                {
                    philhealth_contribTxtbox.Text = "247.50";
                }
                else if (grossincome > 18000 && grossincome <= 19000)
                {
                    philhealth_contribTxtbox.Text = "261.25";
                }
                else if (grossincome > 19000 && grossincome <= 20000)
                {
                    philhealth_contribTxtbox.Text = "275.25";
                }
                else if (grossincome > 20000 && grossincome <= 21000)
                {
                    philhealth_contribTxtbox.Text = "288.75";
                }
                else if (grossincome > 21000 && grossincome <= 22000)
                {
                    philhealth_contribTxtbox.Text = "302.50";
                }
                else if (grossincome > 22000 && grossincome <= 23000)
                {
                    philhealth_contribTxtbox.Text = "316.25";
                }
                else if (grossincome > 23000 && grossincome <= 24000)
                {
                    philhealth_contribTxtbox.Text = "330.00";
                }
                else if (grossincome > 24000 && grossincome <= 25000)
                {
                    philhealth_contribTxtbox.Text = "343.75";
                }
                else if (grossincome > 25000 && grossincome <= 26000)
                {
                    philhealth_contribTxtbox.Text = "357.50";
                }
                else if (grossincome > 26000 && grossincome <= 27000)
                {
                    philhealth_contribTxtbox.Text = "371.25";
                }
                else if (grossincome > 27000 && grossincome <= 28000)
                {
                    philhealth_contribTxtbox.Text = "385.00";
                }
                else if (grossincome > 28000 && grossincome <= 29000)
                {
                    philhealth_contribTxtbox.Text = "398.75";
                }
                else if (grossincome > 29000 && grossincome <= 30000)
                {
                    philhealth_contribTxtbox.Text = "412.50";
                }
                else if (grossincome > 30000 && grossincome <= 31000)
                {
                    philhealth_contribTxtbox.Text = "426.25";
                }
                else if (grossincome > 31000 && grossincome <= 32000)
                {
                    philhealth_contribTxtbox.Text = "440.00";
                }
                else if (grossincome > 32000 && grossincome <= 33000)
                {
                    philhealth_contribTxtbox.Text = "453.75";
                }
                else if (grossincome > 33000 && grossincome <= 34000)
                {
                    philhealth_contribTxtbox.Text = "467.50";
                }
                else if (grossincome > 34000 && grossincome <= 35000)
                {
                    philhealth_contribTxtbox.Text = "481.25";
                }
                else if (grossincome > 35000 && grossincome <= 36000)
                {
                    philhealth_contribTxtbox.Text = "495.00";
                }
                else if (grossincome > 36000 && grossincome <= 37000)
                {
                    philhealth_contribTxtbox.Text = "508.75";
                }
                else if (grossincome > 37000 && grossincome <= 38000)
                {
                    philhealth_contribTxtbox.Text = "522.50";
                }
                else if (grossincome > 38000 && grossincome <= 39000)
                {
                    philhealth_contribTxtbox.Text = "536.25";
                }
                else if (grossincome > 39000 && grossincome <= 33999.99)
                {
                    philhealth_contribTxtbox.Text = "543.13";
                }
                else
                    philhealth_contribTxtbox.Text = "550.00";

                //SSS contribution based on the current table from SSS
                if (grossincome < 1000.00)
                {
                    sss_contribTxtbox.Text = "0.00";
                }
                else if (grossincome >= 1000.00 && grossincome <= 1249.99)
                {
                    sss_contribTxtbox.Text = "36.30";
                }
                else if (grossincome >= 1250.00 && grossincome <= 1749.99)
                {
                    sss_contribTxtbox.Text = "54.50";
                }
                else if (grossincome >= 1750.00 && grossincome <= 2249.99)
                {
                    sss_contribTxtbox.Text = "72.70";
                }
                else if (grossincome >= 2250.00 && grossincome <= 2749.99)
                {
                    sss_contribTxtbox.Text = "90.80";
                }
                else if (grossincome >= 2750.00 && grossincome <= 3249.99)
                {
                    sss_contribTxtbox.Text = "109.00";
                }
                else if (grossincome >= 3250.00 && grossincome <= 3749.99)
                {
                    sss_contribTxtbox.Text = "127.20";
                }
                else if (grossincome >= 3750.00 && grossincome <= 4249.99)
                {
                    sss_contribTxtbox.Text = "145.30";
                }
                else if (grossincome >= 4250.00 && grossincome <= 4749.99)
                {
                    sss_contribTxtbox.Text = "163.50";
                }
                else if (grossincome >= 4750.00 && grossincome <= 5249.99)
                {
                    sss_contribTxtbox.Text = "181.70";
                }
                else if (grossincome >= 5250.00 && grossincome <= 5749.99)
                {
                    sss_contribTxtbox.Text = "199.80";
                }
                else if (grossincome >= 5750.00 && grossincome <= 6249.99)
                {
                    sss_contribTxtbox.Text = "218.00";
                }
                else if (grossincome >= 6250.00 && grossincome <= 6749.99)
                {
                    sss_contribTxtbox.Text = "236.20";
                }
                else if (grossincome >= 6750.00 && grossincome <= 7249.99)
                {
                    sss_contribTxtbox.Text = "254.30";
                }
                else if (grossincome >= 7250.00 && grossincome <= 7749.99)
                {
                    sss_contribTxtbox.Text = "272.50";
                }
                else if (grossincome >= 7750.00 && grossincome <= 8249.99)
                {
                    sss_contribTxtbox.Text = "290.70";
                }
                else if (grossincome >= 8250.00 && grossincome <= 8749.99)
                {
                    sss_contribTxtbox.Text = "308.80";
                }
                else if (grossincome >= 8750.00 && grossincome <= 9249.99)
                {
                    sss_contribTxtbox.Text = "327.00";
                }
                else if (grossincome >= 9250.00 && grossincome <= 9749.99)
                {
                    sss_contribTxtbox.Text = "345.20";
                }
                else if (grossincome >= 9750.00 && grossincome <= 10249.99)
                {
                    sss_contribTxtbox.Text = "363.30";
                }
                else if (grossincome >= 10250.00 && grossincome <= 10749.99)
                {
                    sss_contribTxtbox.Text = "381.50";
                }
                else if (grossincome >= 10750.00 && grossincome <= 11249.99)
                {
                    sss_contribTxtbox.Text = "399.70";
                }
                else if (grossincome >= 11250.00 && grossincome <= 11749.99)
                {
                    sss_contribTxtbox.Text = "417.80";
                }
                else if (grossincome >= 11750.00 && grossincome <= 12249.99)
                {
                    sss_contribTxtbox.Text = "436.00";
                }
                else if (grossincome >= 12250.00 && grossincome <= 12749.99)
                {
                    sss_contribTxtbox.Text = "454.20";
                }
                else if (grossincome >= 12750.00 && grossincome <= 13249.99)
                {
                    sss_contribTxtbox.Text = "472.30";
                }
                else if (grossincome >= 13250.00 && grossincome <= 13749.99)
                {
                    sss_contribTxtbox.Text = "490.50";
                }
                else if (grossincome >= 13750.00 && grossincome <= 14249.99)
                {
                    sss_contribTxtbox.Text = "508.70";
                }
                else if (grossincome >= 14250.00 && grossincome <= 14749.99)
                {
                    sss_contribTxtbox.Text = "526.80";
                }
                else if (grossincome >= 14750.00 && grossincome <= 15249.99)
                {
                    sss_contribTxtbox.Text = "545.00";
                }
                else if (grossincome >= 15250.00 && grossincome <= 15749.99)
                {
                    sss_contribTxtbox.Text = "563.20";
                }
                else if (grossincome >= 15750.00 && grossincome <= 16249.99)
                {
                    sss_contribTxtbox.Text = "581.30";
                }
                else // For grossincome greater than 16249.99
                {
                    sss_contribTxtbox.Text = "581.30";
                }

                //tax contribution per month based on the new table of TAX 2019
                if (grossincome < (250000 / 24)) // grossincome < 10416.67
                {
                    tax_contribTxtbox.Text = "0.00";
                }
                else if (grossincome > 10416.67 && grossincome <= 16666.67)
                {
                    // Taxable income is (grossincome * 24) - 250000.00 (Annual Exemption)
                    tax_contrib = ((((grossincome * 24) - 250000) * 0.20) / 24);
                    tax_contribTxtbox.Text = tax_contrib.ToString("n");
                }
                else if (grossincome > 16666.67 && grossincome <= 33333.33)
                {
                    // P30,000 + 25% of excess over P400,000 (Annual)
                    tax_contrib = (((((grossincome * 24) - 400000) * 0.25) + 30000) / 24);
                    tax_contribTxtbox.Text = tax_contrib.ToString("n");
                }
                else if (grossincome > 33333.33 && grossincome <= 83333.33)
                {
                    // P130,000 + 30% of excess over P800,000 (Annual)
                    tax_contrib = (((((grossincome * 24) - 800000) * 0.30) + 130000) / 24);
                    tax_contribTxtbox.Text = tax_contrib.ToString("n");
                }
                else if (grossincome > 83333.33 && grossincome <= 333333.33)
                {
                    // P490,000 + 32% of excess over P2,000,000 (Annual)
                    tax_contrib = (((((grossincome * 24) - 2000000) * 0.32) + 490000) / 24);
                    tax_contribTxtbox.Text = tax_contrib.ToString("n");
                }
                else // For grossincome > 333333.33
                {
                    // P2,410,000 + 35% of excess over P8,000,000 (Annual)
                    tax_contrib = (((((grossincome * 24) - 8000000) * 0.35) + 2410000) / 24);
                    tax_contribTxtbox.Text = tax_contrib.ToString("n");
                }
            }
            catch (Exception)
            {
                // Error handling block
                MessageBox.Show("Invalid data entry");
                other_numhrsTxtbox.Clear();
                other_numhrsTxtbox.Focus();
            }
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
            
            others_loanCombo.Text = "Select other deduction";
            others_loanCombo.Items.Add("Other 1");
            others_loanCombo.Items.Add("Other 2");
            others_loanCombo.Items.Add("Other 3");
            others_loanCombo.Items.Add("Other 4");
            picpathTxtbox.Hide();

        }
    }
}
