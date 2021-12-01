
namespace HotelManagementSystem
{
    partial class Huoneet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numeroTB = new System.Windows.Forms.TextBox();
            this.puhelinTB = new System.Windows.Forms.TextBox();
            this.tyyppiCB = new System.Windows.Forms.ComboBox();
            this.kyllaRB = new System.Windows.Forms.RadioButton();
            this.eiRB = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.huoneetDG = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lisaaBT = new System.Windows.Forms.Button();
            this.muokkaaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.huoneetDG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 110);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(254, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Huoneiden hallinta";
            // 
            // numeroTB
            // 
            this.numeroTB.Location = new System.Drawing.Point(173, 179);
            this.numeroTB.Name = "numeroTB";
            this.numeroTB.Size = new System.Drawing.Size(147, 20);
            this.numeroTB.TabIndex = 1;
            this.numeroTB.TextChanged += new System.EventHandler(this.numeroTB_TextChanged);
            // 
            // puhelinTB
            // 
            this.puhelinTB.Location = new System.Drawing.Point(173, 236);
            this.puhelinTB.Name = "puhelinTB";
            this.puhelinTB.Size = new System.Drawing.Size(147, 20);
            this.puhelinTB.TabIndex = 2;
            // 
            // tyyppiCB
            // 
            this.tyyppiCB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tyyppiCB.FormattingEnabled = true;
            this.tyyppiCB.Location = new System.Drawing.Point(173, 209);
            this.tyyppiCB.Name = "tyyppiCB";
            this.tyyppiCB.Size = new System.Drawing.Size(147, 21);
            this.tyyppiCB.TabIndex = 3;
            // 
            // kyllaRB
            // 
            this.kyllaRB.AutoSize = true;
            this.kyllaRB.Location = new System.Drawing.Point(185, 280);
            this.kyllaRB.Name = "kyllaRB";
            this.kyllaRB.Size = new System.Drawing.Size(47, 17);
            this.kyllaRB.TabIndex = 4;
            this.kyllaRB.TabStop = true;
            this.kyllaRB.Text = "Kyllä";
            this.kyllaRB.UseVisualStyleBackColor = true;
            // 
            // eiRB
            // 
            this.eiRB.AutoSize = true;
            this.eiRB.Location = new System.Drawing.Point(273, 280);
            this.eiRB.Name = "eiRB";
            this.eiRB.Size = new System.Drawing.Size(34, 17);
            this.eiRB.TabIndex = 5;
            this.eiRB.TabStop = true;
            this.eiRB.Text = "Ei";
            this.eiRB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Huoneen nro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Huonetyyppi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Puhelin:";
            // 
            // huoneetDG
            // 
            this.huoneetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.huoneetDG.Location = new System.Drawing.Point(355, 147);
            this.huoneetDG.Name = "huoneetDG";
            this.huoneetDG.Size = new System.Drawing.Size(433, 270);
            this.huoneetDG.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vapaa:";
            // 
            // lisaaBT
            // 
            this.lisaaBT.Location = new System.Drawing.Point(56, 320);
            this.lisaaBT.Name = "lisaaBT";
            this.lisaaBT.Size = new System.Drawing.Size(75, 23);
            this.lisaaBT.TabIndex = 11;
            this.lisaaBT.Text = "Lisää huone";
            this.lisaaBT.UseVisualStyleBackColor = true;
            // 
            // muokkaaBT
            // 
            this.muokkaaBT.Location = new System.Drawing.Point(157, 320);
            this.muokkaaBT.Name = "muokkaaBT";
            this.muokkaaBT.Size = new System.Drawing.Size(75, 23);
            this.muokkaaBT.TabIndex = 12;
            this.muokkaaBT.Text = "Muokkaa";
            this.muokkaaBT.UseVisualStyleBackColor = true;
            // 
            // poistaBT
            // 
            this.poistaBT.Location = new System.Drawing.Point(257, 320);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(75, 23);
            this.poistaBT.TabIndex = 13;
            this.poistaBT.Text = "Poista";
            this.poistaBT.UseVisualStyleBackColor = true;
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Location = new System.Drawing.Point(257, 372);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(75, 23);
            this.tyhjennaBT.TabIndex = 14;
            this.tyhjennaBT.Text = "Tyhjennä";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            // 
            // Huoneet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.muokkaaBT);
            this.Controls.Add(this.lisaaBT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.huoneetDG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eiRB);
            this.Controls.Add(this.kyllaRB);
            this.Controls.Add(this.tyyppiCB);
            this.Controls.Add(this.puhelinTB);
            this.Controls.Add(this.numeroTB);
            this.Controls.Add(this.panel1);
            this.Name = "Huoneet";
            this.Text = "Huoneet";
            this.Load += new System.EventHandler(this.Huoneet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.huoneetDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numeroTB;
        private System.Windows.Forms.TextBox puhelinTB;
        private System.Windows.Forms.ComboBox tyyppiCB;
        private System.Windows.Forms.RadioButton kyllaRB;
        private System.Windows.Forms.RadioButton eiRB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView huoneetDG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button lisaaBT;
        private System.Windows.Forms.Button muokkaaBT;
        private System.Windows.Forms.Button poistaBT;
        private System.Windows.Forms.Button tyhjennaBT;
    }
}