namespace DSAL01E_Lesson2_Activity_Bautista
{
    partial class PrintExample6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.priDisplaylistbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // priDisplaylistbox
            // 
            this.priDisplaylistbox.FormattingEnabled = true;
            this.priDisplaylistbox.ItemHeight = 16;
            this.priDisplaylistbox.Location = new System.Drawing.Point(17, 19);
            this.priDisplaylistbox.Name = "priDisplaylistbox";
            this.priDisplaylistbox.Size = new System.Drawing.Size(323, 612);
            this.priDisplaylistbox.TabIndex = 0;
            // 
            // PrintExample6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(361, 652);
            this.Controls.Add(this.priDisplaylistbox);
            this.Name = "PrintExample6";
            this.Text = "PrintExample6";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox priDisplaylistbox;
    }
}