
namespace HotelManagementSystem
{
    partial class Kirjautuminen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KayttajaTunnusLB = new System.Windows.Forms.Label();
            this.salasanaLB = new System.Windows.Forms.Label();
            this.KayttajaTunnusTB = new System.Windows.Forms.TextBox();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.KirjauduBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagementSystem.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(173, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 49);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kirjaudu sisään";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KirjauduBT);
            this.groupBox1.Controls.Add(this.SalasanaTB);
            this.groupBox1.Controls.Add(this.KayttajaTunnusTB);
            this.groupBox1.Controls.Add(this.salasanaLB);
            this.groupBox1.Controls.Add(this.KayttajaTunnusLB);
            this.groupBox1.Location = new System.Drawing.Point(13, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 261);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // KayttajaTunnusLB
            // 
            this.KayttajaTunnusLB.AutoSize = true;
            this.KayttajaTunnusLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayttajaTunnusLB.ForeColor = System.Drawing.Color.White;
            this.KayttajaTunnusLB.Location = new System.Drawing.Point(7, 40);
            this.KayttajaTunnusLB.Name = "KayttajaTunnusLB";
            this.KayttajaTunnusLB.Size = new System.Drawing.Size(161, 25);
            this.KayttajaTunnusLB.TabIndex = 0;
            this.KayttajaTunnusLB.Text = "Käyttäjätunnus:";
            this.KayttajaTunnusLB.Click += new System.EventHandler(this.label2_Click);
            // 
            // salasanaLB
            // 
            this.salasanaLB.AutoSize = true;
            this.salasanaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasanaLB.ForeColor = System.Drawing.Color.White;
            this.salasanaLB.Location = new System.Drawing.Point(6, 109);
            this.salasanaLB.Name = "salasanaLB";
            this.salasanaLB.Size = new System.Drawing.Size(108, 25);
            this.salasanaLB.TabIndex = 1;
            this.salasanaLB.Text = "Salasana:";
            // 
            // KayttajaTunnusTB
            // 
            this.KayttajaTunnusTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayttajaTunnusTB.Location = new System.Drawing.Point(200, 43);
            this.KayttajaTunnusTB.Name = "KayttajaTunnusTB";
            this.KayttajaTunnusTB.Size = new System.Drawing.Size(245, 22);
            this.KayttajaTunnusTB.TabIndex = 2;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaTB.Location = new System.Drawing.Point(200, 112);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(245, 22);
            this.SalasanaTB.TabIndex = 3;
            // 
            // KirjauduBT
            // 
            this.KirjauduBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KirjauduBT.Location = new System.Drawing.Point(73, 192);
            this.KirjauduBT.Name = "KirjauduBT";
            this.KirjauduBT.Size = new System.Drawing.Size(319, 54);
            this.KirjauduBT.TabIndex = 4;
            this.KirjauduBT.Text = "Kirjaudu";
            this.KirjauduBT.UseVisualStyleBackColor = true;
            // 
            // Kirjautuminen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(487, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Kirjautuminen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Kirjautuminen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label KayttajaTunnusLB;
        private System.Windows.Forms.Label salasanaLB;
        private System.Windows.Forms.Button KirjauduBT;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.TextBox KayttajaTunnusTB;
    }
}

