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
    public partial class POS2_Function : Form
    {
        //Class level variables (fields)
        int total_qty = 0;
        double total_amount = 0;
        double currentPrice = 0;
        double currentDiscount = 0;

        private void price_item_TextValue(string itemName, string itemPrice)
        {
            priceTxtBox.Text = itemPrice;
            discountamountTxtbox.Text = "0.00";
            displayListbox.Items.Add(itemName + "              " + itemPrice);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void quantityTxtbox()
        {
            qtyTxtbox.Focus();
        }

        public POS2_Function()
        {
            InitializeComponent();
            foodARdbtn.CheckedChanged += foodARdbtn_CheckedChanged;
            foodBRdtn.CheckedChanged += foodBRdtn_CheckedChanged;
        }

        private void UpdateTotals()
        {
            total_qty = 0;
            total_amount = 0;

            if (A_CokeCheckBox.Checked) { total_qty += 1; total_amount += 120; }
            if (A_FriedChickencheckBox.Checked) { total_qty += 1; total_amount += 200; }
            // repeat for all checkboxes...

            totalQtyTxtbox.Text = total_qty.ToString();
            totalBillsTxtbox.Text = total_amount.ToString("n");
        }

        private void POS2_Function_Load(object sender, EventArgs e)
        {
            DisableTextBoxes();
            DisableCheckBoxes();
        }

            // ---------------- Function Methods ---------------- //

        private void DisableTextBoxes()
        {
            priceTxtBox.Enabled = false;
            discountedamountTxtbox.Enabled = false;
            changeTxtbox.Enabled = false;
            totalBillsTxtbox.Enabled = false;
            discountamountTxtbox.Enabled = false;
            totalQtyTxtbox.Enabled = false;
        }

        private void DisableCheckBoxes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox cb) cb.Enabled = false;
            }
        }

        private void foodARdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!foodARdbtn.Checked) return;

            this.BackColor = Color.LightPink;
            foodBRdtn.Checked = false;

            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\Bautista\\source\\repos\\elaizabautista\\final2_visualstudio_form123\\Images\\b1.jpg");
            
            // Check/uncheck checkboxes
            A_CokeCheckBox.Checked = true;
            A_FriedChickencheckBox.Checked = true;
            A_FriesCheckBox.Checked = true;
            A_sideDishCheckBox.Checked = true;
            A_SpecialPizzaCheckbox.Checked = true;

            B_carbonaracheckBox.Checked = false;
            B_Chickencheckbox.Checked = false;
            B_Friescheckbox.Checked = false;
            B_halohalocheckBox.Checked = false;
            B_HawaiiancheckBox.Checked = false;

            // Numeric price & discount
            currentPrice = 1000;
            currentDiscount = 200;
            priceTxtBox.Text = currentPrice.ToString("n");
            discountamountTxtbox.Text = currentDiscount.ToString("n");

            displayListbox.Items.Add(foodARdbtn.Text + "              " + priceTxtBox.Text);
            displayListbox.Items.Add("       Discount Amount:" + "               " + discountamountTxtbox.Text);

            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();

            UpdateTotals();
        }

        private void foodBRdtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!foodBRdtn.Checked) return;

            this.BackColor = Color.LightBlue;
            foodARdbtn.Checked = false;

            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\Bautista\\source\\repos\\elaizabautista\\final2_visualstudio_form123\\Images\\b2.jpg");

            A_CokeCheckBox.Checked = false;
            A_FriedChickencheckBox.Checked = false;
            A_FriesCheckBox.Checked = false;
            A_sideDishCheckBox.Checked = false;
            A_SpecialPizzaCheckbox.Checked = false;

            B_carbonaracheckBox.Checked = true;
            B_Chickencheckbox.Checked = true;
            B_Friescheckbox.Checked = true;
            B_halohalocheckBox.Checked = true;
            B_HawaiiancheckBox.Checked = true;

            // Numeric price & discount
            currentPrice = 1299;
            currentDiscount = currentPrice * 0.15; // 15% discount
            priceTxtBox.Text = currentPrice.ToString("n");
            discountamountTxtbox.Text = currentDiscount.ToString("n");

            displayListbox.Items.Add(foodBRdtn.Text + "              " + priceTxtBox.Text);
            displayListbox.Items.Add("       Discount Amount:" + "               " + discountamountTxtbox.Text);

            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();

            UpdateTotals();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double cash_given, change, total_amountPaid;
            cash_given = Convert.ToDouble(cashGivenTxtbox.Text);
            total_amountPaid = Convert.ToDouble(totalBillsTxtbox.Text);
            change = cash_given - total_amountPaid;
            changeTxtbox.Text = change.ToString("n");
            displayListbox.Items.Add("Total Bills: " + "              " + totalBillsTxtbox.Text);
            displayListbox.Items.Add("Cash Given: " + "              " + cashGivenTxtbox.Text);
            displayListbox.Items.Add("Change: " + "              " + changeTxtbox.Text);
            displayListbox.Items.Add("Total No. of Items: " + "              " + totalQtyTxtbox.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // create instance of the other form
            PrintForm print = new PrintForm();

            // copy items from current form's listbox to the other form's listbox
            print.Listbox1.Items.AddRange(displayListbox.Items); //make sure to see the Listbox1 is public (under modifiers) in the PrintForm

            // show the other form
            print.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //codes to remove the selected data inside the listbox
            displayListbox.Items.RemoveAt(displayListbox.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Uncheck radio buttons
            foodARdbtn.Checked = false;
            foodBRdtn.Checked = false;

            // Reset picture
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\Bautista\\source\\repos\\elaizabautista\\final2_visualstudio_form123\\Lesson3_Exercises\\Images\\b13.jpg");

            // Uncheck all checkboxes in the form
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is CheckBox cb)
                {
                    cb.Checked = false;
                }
            }

            // Clear textboxes
            priceTxtBox.Clear();
            qtyTxtbox.Clear();

            // Clear listbox
            displayListbox.Items.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void qtyTxtbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(qtyTxtbox.Text)) return;

            try
            {
                int qty = Convert.ToInt32(qtyTxtbox.Text);
                double price = Convert.ToDouble(priceTxtBox.Text);
                double discount = Convert.ToDouble(discountamountTxtbox.Text);

                // Calculate current item total
                double discounted_amount = (price * qty) - discount;

                // Update total amount and total quantity (not cumulative addition)
                totalQtyTxtbox.Text = qty.ToString();
                totalBillsTxtbox.Text = discounted_amount.ToString("n");
                discountedamountTxtbox.Text = discounted_amount.ToString("n");
            }
            catch
            {
                // Optional: clear if invalid entry
                qtyTxtbox.Text = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            price_item_TextValue("Pizza 1", "600.10");
            quantityTxtbox();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            price_item_TextValue("Pizza 2", "650.10");
            quantityTxtbox();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            price_item_TextValue("Pizza 3", "700.20");
            quantityTxtbox();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            price_item_TextValue("Pizza 4", "600.10");
            quantityTxtbox();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            price_item_TextValue("Pizza 5", "600.10");
            quantityTxtbox();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            price_item_TextValue("Pizza 6", "600.10");
            quantityTxtbox();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            price_item_TextValue("Pizza 7", "600.10");
            quantityTxtbox();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            price_item_TextValue("Pizza 8", "600.10");
            quantityTxtbox();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            price_item_TextValue("Pizza 9", "600.10");
            quantityTxtbox();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            price_item_TextValue("Pizza 10", "600.10");
            quantityTxtbox();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            price_item_TextValue("Pizza 11", "600.10");
            quantityTxtbox();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            price_item_TextValue("Pizza 12", "600.10");
            quantityTxtbox();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            price_item_TextValue("Pizza 13", "600.10");
            quantityTxtbox();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            price_item_TextValue("Pizza 14", "600.10");
            quantityTxtbox();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            price_item_TextValue("Pizza 15", "600.10");
            quantityTxtbox();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            price_item_TextValue("Pizza 16", "600.10");
            quantityTxtbox();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            price_item_TextValue("Pizza 17", "600.10");
            quantityTxtbox();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            price_item_TextValue("Pizza 18", "600.10");
            quantityTxtbox();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            price_item_TextValue("Pizza 19", "600.10");
            quantityTxtbox();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            price_item_TextValue("Pizza 20", "600.10");
            quantityTxtbox();
        }
    }
    
}
