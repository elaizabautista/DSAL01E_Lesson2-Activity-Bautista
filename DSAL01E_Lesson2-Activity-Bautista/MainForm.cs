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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;   //Needed for child forms
        }

        private void jeePOSIncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Example2 newMDIChild = new Example2(); // create a class and instatiate it
            newMDIChild.MdiParent = this; // code for calling the new class created use for calling the form
            newMDIChild.Show(); // code for displaying the pointed form to be displayed
        }

        private void jEEPOSOrderingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Example4 newMDIChild = new Example4();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jeePOSIncToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Example5 newMDIChild = new Example5();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void jeePOSOrderingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Example3 newMDIChild = new Example3();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newMDIChild = new Form2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tile all child forms in vertical display
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tile all child forms in horizontal display
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tile all child forms in cascade display
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void payrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson5_Activity newMDIChild = new Lesson5_Activity();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void employeeInformationPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity1 newMDIChild = new Activity1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void humanResourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Example1 newMDIChild = new Example1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
