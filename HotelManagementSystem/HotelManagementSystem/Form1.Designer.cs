
namespace HotelManagementSystem
{
    partial class Paaikkuna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asiakkaitenHallintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varaustenHallintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huoneidenHallintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asiakkaitenHallintaToolStripMenuItem,
            this.varaustenHallintaToolStripMenuItem,
            this.huoneidenHallintaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asiakkaitenHallintaToolStripMenuItem
            // 
            this.asiakkaitenHallintaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.asiakkaitenHallintaToolStripMenuItem.Name = "asiakkaitenHallintaToolStripMenuItem";
            this.asiakkaitenHallintaToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.asiakkaitenHallintaToolStripMenuItem.Text = "Asiakkaiten hallinta";
            // 
            // varaustenHallintaToolStripMenuItem
            // 
            this.varaustenHallintaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.varaustenHallintaToolStripMenuItem.Name = "varaustenHallintaToolStripMenuItem";
            this.varaustenHallintaToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.varaustenHallintaToolStripMenuItem.Text = "Varausten hallinta";
            // 
            // huoneidenHallintaToolStripMenuItem
            // 
            this.huoneidenHallintaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.huoneidenHallintaToolStripMenuItem.Name = "huoneidenHallintaToolStripMenuItem";
            this.huoneidenHallintaToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.huoneidenHallintaToolStripMenuItem.Text = "Huoneiden hallinta";
            // 
            // Paaikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelManagementSystem.Properties.Resources.hotelroom_img;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(763, 517);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Paaikkuna";
            this.Text = "Paaikkuna";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Paaikkuna_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asiakkaitenHallintaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varaustenHallintaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huoneidenHallintaToolStripMenuItem;
    }
}