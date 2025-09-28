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
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
            //codes below is to display all the contents of the listbox from Example4.cs form to this current form
            Listbox1.Items.AddRange(Listbox1.Items);
        }
    }
}
