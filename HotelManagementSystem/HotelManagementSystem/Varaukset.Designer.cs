
namespace HotelManagementSystem
{
    partial class Varaukset
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
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            this.muokkaaBT = new System.Windows.Forms.Button();
            this.lisaaBT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.varauksetDG = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tyyppiCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vidTB = new System.Windows.Forms.TextBox();
            this.hnroCB = new System.Windows.Forms.ComboBox();
            this.sisaanDT = new System.Windows.Forms.DateTimePicker();
            this.ulosDT = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.asiakasCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.asiakasIDTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetDG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 79);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(368, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varausten hallinta";
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Location = new System.Drawing.Point(271, 345);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(75, 23);
            this.tyhjennaBT.TabIndex = 29;
            this.tyhjennaBT.Text = "Tyhjennä";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // poistaBT
            // 
            this.poistaBT.Location = new System.Drawing.Point(190, 345);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(75, 23);
            this.poistaBT.TabIndex = 28;
            this.poistaBT.Text = "Poista";
            this.poistaBT.UseVisualStyleBackColor = true;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
            // 
            // muokkaaBT
            // 
            this.muokkaaBT.Location = new System.Drawing.Point(109, 345);
            this.muokkaaBT.Name = "muokkaaBT";
            this.muokkaaBT.Size = new System.Drawing.Size(75, 23);
            this.muokkaaBT.TabIndex = 27;
            this.muokkaaBT.Text = "Muokkaa";
            this.muokkaaBT.UseVisualStyleBackColor = true;
            this.muokkaaBT.Click += new System.EventHandler(this.muokkaaBT_Click);
            // 
            // lisaaBT
            // 
            this.lisaaBT.Location = new System.Drawing.Point(12, 345);
            this.lisaaBT.Name = "lisaaBT";
            this.lisaaBT.Size = new System.Drawing.Size(81, 23);
            this.lisaaBT.TabIndex = 26;
            this.lisaaBT.Text = "Lisää varaus";
            this.lisaaBT.UseVisualStyleBackColor = true;
            this.lisaaBT.Click += new System.EventHandler(this.lisaaBT_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Alkaen:";
            // 
            // varauksetDG
            // 
            this.varauksetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varauksetDG.Location = new System.Drawing.Point(371, 149);
            this.varauksetDG.Name = "varauksetDG";
            this.varauksetDG.Size = new System.Drawing.Size(660, 279);
            this.varauksetDG.TabIndex = 24;
            this.varauksetDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.varauksetDG_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Huonetyyppi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Huoneen nro:";
            // 
            // tyyppiCB
            // 
            this.tyyppiCB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tyyppiCB.FormattingEnabled = true;
            this.tyyppiCB.Location = new System.Drawing.Point(173, 201);
            this.tyyppiCB.Name = "tyyppiCB";
            this.tyyppiCB.Size = new System.Drawing.Size(173, 21);
            this.tyyppiCB.TabIndex = 18;
            this.tyyppiCB.SelectedIndexChanged += new System.EventHandler(this.tyyppiCB_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "Varauksen ID:";
            // 
            // vidTB
            // 
            this.vidTB.Location = new System.Drawing.Point(173, 175);
            this.vidTB.Name = "vidTB";
            this.vidTB.Size = new System.Drawing.Size(173, 20);
            this.vidTB.TabIndex = 30;
            // 
            // hnroCB
            // 
            this.hnroCB.FormattingEnabled = true;
            this.hnroCB.Location = new System.Drawing.Point(173, 228);
            this.hnroCB.Name = "hnroCB";
            this.hnroCB.Size = new System.Drawing.Size(173, 21);
            this.hnroCB.TabIndex = 32;
            // 
            // sisaanDT
            // 
            this.sisaanDT.Location = new System.Drawing.Point(173, 255);
            this.sisaanDT.Name = "sisaanDT";
            this.sisaanDT.Size = new System.Drawing.Size(173, 20);
            this.sisaanDT.TabIndex = 33;
            // 
            // ulosDT
            // 
            this.ulosDT.Location = new System.Drawing.Point(173, 281);
            this.ulosDT.Name = "ulosDT";
            this.ulosDT.Size = new System.Drawing.Size(173, 20);
            this.ulosDT.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 34;
            this.label7.Text = "Loppuen:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(96, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 37;
            this.label8.Text = "Asiakas:";
            // 
            // asiakasCB
            // 
            this.asiakasCB.FormattingEnabled = true;
            this.asiakasCB.Location = new System.Drawing.Point(173, 149);
            this.asiakasCB.Name = "asiakasCB";
            this.asiakasCB.Size = new System.Drawing.Size(173, 21);
            this.asiakasCB.TabIndex = 38;
            this.asiakasCB.SelectedIndexChanged += new System.EventHandler(this.asiakasCB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Asiakkaan ID:";
            // 
            // asiakasIDTB
            // 
            this.asiakasIDTB.Location = new System.Drawing.Point(173, 121);
            this.asiakasIDTB.Name = "asiakasIDTB";
            this.asiakasIDTB.Size = new System.Drawing.Size(173, 20);
            this.asiakasIDTB.TabIndex = 40;
            // 
            // Varaukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.Controls.Add(this.asiakasIDTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.asiakasCB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ulosDT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sisaanDT);
            this.Controls.Add(this.hnroCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vidTB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.muokkaaBT);
            this.Controls.Add(this.lisaaBT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.varauksetDG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tyyppiCB);
            this.Name = "Varaukset";
            this.Text = "Varaukset";
            this.Load += new System.EventHandler(this.Varaukset_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button poistaBT;
        private System.Windows.Forms.Button muokkaaBT;
        private System.Windows.Forms.Button lisaaBT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView varauksetDG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tyyppiCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox vidTB;
        private System.Windows.Forms.ComboBox hnroCB;
        private System.Windows.Forms.DateTimePicker sisaanDT;
        private System.Windows.Forms.DateTimePicker ulosDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox asiakasCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox asiakasIDTB;
    }
}