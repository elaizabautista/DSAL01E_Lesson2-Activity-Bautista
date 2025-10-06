using System;
using System.Drawing;
using System.Windows.Forms;

namespace DSAL01E_Lesson2_Activity_Bautista
{
    public partial class POS1_Function : Form
    {
        // Declare variables
        double price, discount_amt, discounted_amt;
        int qty;

        public POS1_Function()
        {
            InitializeComponent();
        }

        // Function for clearing the quantity textbox and placing cursor inside
        private void Clearquantitytxtbox()
        {
            quantitytxtbox.Clear();
            quantitytxtbox.Focus();
        }

        // Function for converting quantity and price input from string to numeric values
        private void quantity_price_Convert()
        {
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
        }

        // Function for computing discount and discounted amount
        private void computation_Formula_and_DisplayData()
        {
            discount_amt = (qty * price) * 0.10; // default 10% discount
            discounted_amt = (qty * price) - discount_amt;

            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
        }

        // Function for updating item name and price textboxes
        public void price_item_TextValue(string itemname, string price)
        {
            itemnametxtbox.Text = itemname;
            pricetextbox.Text = price;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Disable certain textboxes
            itemnametxtbox.Enabled = false;
            pricetextbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;

            // Insert pictures into PictureBoxes
            pictureBox16.Image = Image.FromFile("C:\\Users\\Bautista\\source\\repos\\elaizabautista\\final2_visualstudio_form123\\Lesson3_Exercises\\Images\\a16.jpg");
            pictureBox17.Image = Image.FromFile("C:\\Users\\Bautista\\source\\repos\\elaizabautista\\final2_visualstudio_form123\\Lesson3_Exercises\\Imagesa17.jpg");
            pictureBox18.Image = Image.FromFile("C:\\Users\\Bautista\\source\\repos\\elaizabautista\\final2_visualstudio_form123\\Lesson3_Exercises\\Images\\a18.jpg");
            pictureBox19.Image = Image.FromFile("C:\\Users\\Bautista\\source\\repos\\elaizabautista\\final2_visualstudio_form123\\Lesson3_Exercises\\Images\\a19.jpg");
            pictureBox20.Image = Image.FromFile("C:\\Users\\Bautista\\source\\repos\\elaizabautista\\final2_visualstudio_form123\\Lesson3_Exercises\\Images\\a20.jpg");

            // Insert names into Labels
            name1lbl.Text = "Midnight Brew";
            name2lbl.Text = "Velvet Sunrise";
            name3lbl.Text = "Creamy Chill Shake";
            name4lbl.Text = "Heartstrings Latte";
            name5lbl.Text = "Chocobliss Cup";
            name10lbl.Text = "Parisian Choco Twist";
            name9lbl.Text = "Choco Symphony";
            name8lbl.Text = "Strawberry Serenade";
            name7lbl.Text = "Golden Harvest Cake";
            name6lbl.Text = "Berry Dream Slice";

            // Initialize textboxes
            quantitytxtbox.Text = "0";
            pricetextbox.Text = "0";
            discounttxtbox.Text = "0";
            discountedtxtbox.Text = "0";
            cashrenderedtxtbox.Text = "0";
        }

        // Common function for radio buttons
        private void ApplyDiscount(double discountRate)
        {
            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * discountRate;
                computation_Formula_and_DisplayData();

                // Uncheck other radio buttons
                regularRbtn.Checked = false;
                EmployeeRdbtn.Checked = false;
                noTaxRdbtn.Checked = false;
            }
            catch
            {
                MessageBox.Show("Input is invalid");
            }

            Clearquantitytxtbox();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) => ApplyDiscount(0.30);
        private void regularRbtn_CheckedChanged(object sender, EventArgs e) => ApplyDiscount(0.30);
        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e) => ApplyDiscount(0.15);
        private void noTaxRdbtn_CheckedChanged(object sender, EventArgs e) => ApplyDiscount(0);

        private void button1_Click(object sender, EventArgs e)
        {
            int qty = Convert.ToInt32(quantitytxtbox.Text);
            double discount_amt = Convert.ToDouble(discounttxtbox.Text);
            double discounted_amt = Convert.ToDouble(discountedtxtbox.Text);
            double cash_rendered = Convert.ToDouble(cashrenderedtxtbox.Text);
            double change = cash_rendered - discounted_amt;

            qty_totaltxtbox.Text = qty.ToString();
            discount_totaltxtbox.Text = discount_amt.ToString("n");
            discounted_totaltxtbox.Text = discounted_amt.ToString("n");
            changetxtbox.Text = change.ToString("n");
            cashrenderedtxtbox.Text = cash_rendered.ToString("n");
        }

        private void button4_Click(object sender, EventArgs e) => this.Close();

        private void button2_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            quantitytxtbox.Clear();
            discounttxtbox.Clear();
            changetxtbox.Clear();
            cashrenderedtxtbox.Clear();
        }

        // ---------------------------
        // PictureBox click codes - KEEP EXACTLY AS IS
        // ---------------------------
        private void americano_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Americano", "89.50");
            Clearquantitytxtbox();
        }
        private void cortado_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Velvet Sumrise", "90.90");
            Clearquantitytxtbox();
        }
        private void milkshake_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Creamy Chill Shake", "90.90");
            Clearquantitytxtbox();
        }
        private void latte_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Heartstrings Latte", "100.90");
            Clearquantitytxtbox();
        }
        private void mocha_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Heartstrings Latte", "100.90");
            Clearquantitytxtbox();
        }
        private void strawberryshortcake_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name6lbl.Text, "90.50");
            Clearquantitytxtbox();
        }
        private void carrotcake_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name7lbl.Text, "95.50");
            Clearquantitytxtbox();
        }
        private void cheesecake_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name8lbl.Text, "90.50");
            Clearquantitytxtbox();
        }
        private void mochacake_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name9lbl.Text, "190.50");
            Clearquantitytxtbox();
        }
        private void chocolatecorissants_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name10lbl.Text, "80.50");
            Clearquantitytxtbox();
        }
        private void pesto_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name11lbl.Text, "70.50");
            Clearquantitytxtbox();
        }
        private void spaghetti_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name12lbl.Text, "85.50");
            Clearquantitytxtbox();
        }
        private void carbonara_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name13lbl.Text, "150.50");
            Clearquantitytxtbox();
        }
        private void parmesan_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name14lbl.Text, "100.50");
            Clearquantitytxtbox();
        }
        private void rolly_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name15lbl.Text, "110.50");
            Clearquantitytxtbox();
        }
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name16lbl.Text, "85.50");
            Clearquantitytxtbox();
        }
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name16lbl.Text, "90.50");
            Clearquantitytxtbox();
        }
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name18lbl.Text, "90.50");
            Clearquantitytxtbox();
        }
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name19lbl.Text, "80.50");
            Clearquantitytxtbox();
        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name20lbl.Text, "190.50");
            Clearquantitytxtbox();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrintForm2 print = new PrintForm2();

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

            print.Show();
        }
    }
}
