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

        public POS2_Function()
        {
            InitializeComponent();
            foodARdbtn.CheckedChanged += (s, e) => FoodBundleSelected(foodARdbtn, Color.LightPink, "b1.jpg", 1000, 200, true);
            foodBRdtn.CheckedChanged += (s, e) => FoodBundleSelected(foodBRdtn, Color.LightBlue, "b2.jpg", 1299, 194.85, false);
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
    }
    
}
