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
    public partial class POS1_Function : Form
    {
    // ---------------- Class-level variables ---------------- //
        int qty = 0;
        double price = 0;
        double discount_amt = 0;
        double discounted_amt = 0;

        public POS1_Function()
        {
            InitializeComponent();
        }
        // ---------------- Function methods ---------------- //

        // Function method for clearing the quantity textbox and placing the cursor
        private void quantityTxtbox()
        {
            quantitytxtbox.Clear();
            quantitytxtbox.Focus();
        }

        // Function method for converting quantity and price input from string to numeric
        private void quantity_price_Convert()
        {
            try
            {
                qty = Convert.ToInt32(quantitytxtbox.Text);
                price = Convert.ToDouble(pricetextbox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantityTxtbox();
            }
        }

        // Function method for the formula needed in the program's computations
        private void computation_Formula_and_DisplayData()
        {
            discounted_amt = (qty * price) - discount_amt;
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
        }

        // Function with a return value for setting the item name and price textboxes
        public void price_item_TextValue(string itemname, string itemprice)
        {
            itemnametxtbox.Text = itemname;
            pricetextbox.Text = itemprice;
        }

        private void POS1_Function_Load(object sender, EventArgs e)
        {
            // disable textboxes
            itemnametxtbox.Enabled = false;
            pricetextbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;

            quantitytxtbox.Text = "0";
            pricetextbox.Text = "0";
            discounttxtbox.Text = "0";
            discountedtxtbox.Text = "0";
            cashrenderedtxtbox.Text = "0";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0.30;
                computation_Formula_and_DisplayData();

                regularRbtn.Checked = false;
                EmployeeRdbtn.Checked = false;
                noTaxRdbtn.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
            }
            quantityTxtbox();
        }

        private void regularRbtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0.10;
                computation_Formula_and_DisplayData();

                radioButton1.Checked = false;
                EmployeeRdbtn.Checked = false;
                noTaxRdbtn.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data input in quantity");
            }
            quantityTxtbox();
        }

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0.15;
                computation_Formula_and_DisplayData();

                radioButton1.Checked = false;
                regularRbtn.Checked = false;
                noTaxRdbtn.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data input in quantity");
            }
            quantityTxtbox();
        }

        private void noTaxRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                discount_amt = 0;
                computation_Formula_and_DisplayData();

                radioButton1.Checked = false;
                regularRbtn.Checked = false;
                EmployeeRdbtn.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data input in quantity");
            }
            quantityTxtbox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaration of variables with data types
            int qty;
            double discount_amt, discounted_amt, cash_rendered, change;
            qty = Convert.ToInt32(quantitytxtbox.Text);
            discount_amt = Convert.ToDouble(discounttxtbox.Text);
            discounted_amt = Convert.ToDouble(discountedtxtbox.Text);
            cash_rendered = Convert.ToDouble(cashrenderedtxtbox.Text);
            //codes to accumulate the value of the quantity, discount given and discounted amount from one transaction to another
            qty_totaltxtbox.Text += qty;
            discount_totaltxtbox.Text += discount_amt;
            discounted_totaltxtbox.Text += discounted_amt;
            change = cash_rendered - discounted_amt;
            //convert string data form textboxes to numeric and place it as value of the variable
            qty_totaltxtbox.Text = qty.ToString();
            discount_totaltxtbox.Text = discount_amt.ToString("n");
            discounted_totaltxtbox.Text = discounted_amt.ToString("n");
            changetxtbox.Text = change.ToString("n");
            cashrenderedtxtbox.Text = cash_rendered.ToString("n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //code for closing the form application once the button is clicked
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //codes for clearing specific pointed textboxes
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            quantitytxtbox.Clear();
            discounttxtbox.Clear();
            changetxtbox.Clear();
            cashrenderedtxtbox.Clear();
        }

        private void americano_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Midnight Brew", "120.90");
            quantityTxtbox();
        }

        private void cortado_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Velvet Sunrise", "120.90");
            quantityTxtbox();
        }

        private void milkshake_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Velvet Sunrise", "120.90");
            quantityTxtbox();
        }

        private void latte_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Velvet Sunrise", "120.90");
            quantityTxtbox();
        }

        private void mocha_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Velvet Sunrise", "120.90");
            quantityTxtbox();
        }

        private void strawberryshortcake_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Velvet Sunrise", "120.90");
            quantityTxtbox();
        }

        private void carrotcake_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Velvet Sunrise", "120.90");
            quantityTxtbox();
        }

        private void cheesecake_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Velvet Sunrise", "120.90");
            quantityTxtbox();
        }

        private void mochacake_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Velvet Sunrise", "120.90");
            quantityTxtbox();
        }

        private void chocolatecorissants_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Velvet Sunrise", "120.90");
            quantityTxtbox();
        }

        private void pesto_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Velvet Sunrise", "120.90");
            quantityTxtbox();
        }

        private void spaghetti_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Velvet Sunrise", "120.90");
            quantityTxtbox();
        }

        private void carbonara_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Velvet Sunrise", "120.90");
            quantityTxtbox();
        }

        private void parmesan_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Velvet Sunrise", "120.90");
            quantityTxtbox();
        }

        private void rolly_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Velvet Sunrise", "120.90");
            quantityTxtbox();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Velvet Sunrise", "120.90");
            quantityTxtbox();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Velvet Sunrise", "120.90");
            quantityTxtbox();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Velvet Sunrise", "120.90");
            quantityTxtbox();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Velvet Sunrise", "120.90");
            quantityTxtbox();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Velvet Sunrise", "120.90");
            quantityTxtbox();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrintForm2 print = new PrintForm2();

            // Transfer the important details to Form2's listbox
            print.printListbox.Items.Add("Item Name:                                " + itemnametxtbox.Text);
            print.printListbox.Items.Add("Quantity:                                 " + quantitytxtbox.Text);
            print.printListbox.Items.Add("Price:                                    " + pricetextbox.Text);
            print.printListbox.Items.Add("Discount Amount:                          " + discounttxtbox.Text);
            print.printListbox.Items.Add("Discounted Amount:                        " + discountedtxtbox.Text);
            print.printListbox.Items.Add("Total Quantity:                           " + qty_totaltxtbox.Text);
            print.printListbox.Items.Add("Total Discount Given:                     " + discount_totaltxtbox.Text);
            print.printListbox.Items.Add("Total Discounted Given:                   " + discounted_totaltxtbox.Text);
            print.printListbox.Items.Add("Cash Rendered:                            " + cashrenderedtxtbox.Text);
            print.printListbox.Items.Add("Change:                                   " + changetxtbox.Text);

            // show the print form
            print.Show();
        }
    }
}

