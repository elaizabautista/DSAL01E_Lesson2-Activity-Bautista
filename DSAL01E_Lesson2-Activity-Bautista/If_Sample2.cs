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
    public partial class If_Sample2 : Form
    {
        public If_Sample2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price, computed_discount;
            const double discount = 0.20D; //20% discount
            try
            {
                price = Convert.ToDouble(priceTxtbox.Text);
                if (price >= 2500)
                {
                    computed_discount = price * discount;
                    discountTxtbox.Text = computed_discount.ToString("C");
                }
                else
                {
                    computed_discount = (price * 0.12);
                    discountTxtbox.Text = computed_discount.ToString("C");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Input data for price is invalid!");
                priceTxtbox.Clear();
                discountTxtbox.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            priceTxtbox.Clear();
            discountTxtbox.Clear();
            priceTxtbox.Focus();
        }
    }
}
