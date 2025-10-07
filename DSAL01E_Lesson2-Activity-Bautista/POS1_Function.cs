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
        
        //initialize textboxes and disable input for certain fields
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

        // Radio button discount events
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
            quantityTxtbox(); //resets quantity textbox
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

        // Button to compute totals and change
        private void button1_Click(object sender, EventArgs e)
        {
            //Convert quantity and price safely
            if (!int.TryParse(quantitytxtbox.Text.Trim(), out qty))
            {
                MessageBox.Show("Quantity must be a whole number");
                quantityTxtbox();
                return;
            }

            if (!double.TryParse(pricetextbox.Text.Trim(), out price))
            {
                MessageBox.Show("Price must be a number");
                quantityTxtbox();
                return;
            }

            //Compute discount and discounted amount
            computation_Formula_and_DisplayData();

            if (!double.TryParse(cashrenderedtxtbox.Text.Trim(), out double cash_rendered))
            {
                MessageBox.Show("Cash Rendered must be a number");
                cashrenderedtxtbox.Focus();
                return;
            }

            //Accumulate totals
            int totalQty = 0;
            double totalDiscount = 0, totalDiscounted = 0;

            //Safely parse existing totals
            int.TryParse(qty_totaltxtbox.Text.Trim(), out totalQty);
            double.TryParse(discount_totaltxtbox.Text.Trim(), out totalDiscount);
            double.TryParse(discounted_totaltxtbox.Text.Trim(), out totalDiscount);
            totalQty += qty;
            totalDiscount += discount_amt;
            totalDiscounted += discounted_amt;
            qty_totaltxtbox.Text = totalQty.ToString();
            discount_totaltxtbox.Text = totalDiscount.ToString("n");
            discounted_totaltxtbox.Text = totalDiscounted.ToString("n");
            double change = cash_rendered - discounted_amt;
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
            // Button to clear selected textboxes
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            quantitytxtbox.Clear();
            discounttxtbox.Clear();
            changetxtbox.Clear();
            cashrenderedtxtbox.Clear();
        }

        // Item buttons to set name and price
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

