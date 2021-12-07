
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
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            this.muokkaaBT = new System.Windows.Forms.Button();
            this.lisaaBT = new System.Windows.Forms.Button();
            this.huoneetDG = new System.Windows.Forms.DataGridView();
            this.puhelinTB = new System.Windows.Forms.TextBox();
            this.numeroTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tyyppiCB = new System.Windows.Forms.ComboBox();
            this.vapaaLB = new System.Windows.Forms.Label();
            this.kyllaRB = new System.Windows.Forms.RadioButton();
            this.eiRB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.huoneetDG)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyhjennaBT.Location = new System.Drawing.Point(271, 356);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(75, 23);
            this.tyhjennaBT.TabIndex = 25;
            this.tyhjennaBT.Text = "Tyhjennä";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // poistaBT
            // 
            this.poistaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poistaBT.Location = new System.Drawing.Point(190, 356);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(75, 23);
            this.poistaBT.TabIndex = 24;
            this.poistaBT.Text = "Poista";
            this.poistaBT.UseVisualStyleBackColor = true;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
            // 
            // muokkaaBT
            // 
            this.muokkaaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muokkaaBT.Location = new System.Drawing.Point(109, 356);
            this.muokkaaBT.Name = "muokkaaBT";
            this.muokkaaBT.Size = new System.Drawing.Size(75, 23);
            this.muokkaaBT.TabIndex = 23;
            this.muokkaaBT.Text = "Muokkaa";
            this.muokkaaBT.UseVisualStyleBackColor = true;
            this.muokkaaBT.Click += new System.EventHandler(this.muokkaaBT_Click);
            // 
            // lisaaBT
            // 
            this.lisaaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisaaBT.Location = new System.Drawing.Point(28, 356);
            this.lisaaBT.Name = "lisaaBT";
            this.lisaaBT.Size = new System.Drawing.Size(75, 23);
            this.lisaaBT.TabIndex = 22;
            this.lisaaBT.Text = "Lisää";
            this.lisaaBT.UseVisualStyleBackColor = true;
            this.lisaaBT.Click += new System.EventHandler(this.lisaaBT_Click);
            // 
            // huoneetDG
            // 
            this.huoneetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.huoneetDG.Location = new System.Drawing.Point(378, 103);
            this.huoneetDG.Name = "huoneetDG";
            this.huoneetDG.Size = new System.Drawing.Size(574, 237);
            this.huoneetDG.TabIndex = 21;
            this.huoneetDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taulukkoDG_CellClick_1);
            this.huoneetDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taulukkoDG_CellContentClick);
            // 
            // puhelinTB
            // 
            this.puhelinTB.Location = new System.Drawing.Point(175, 179);
            this.puhelinTB.Name = "puhelinTB";
            this.puhelinTB.Size = new System.Drawing.Size(127, 20);
            this.puhelinTB.TabIndex = 18;
            // 
            // numeroTB
            // 
            this.numeroTB.Location = new System.Drawing.Point(175, 126);
            this.numeroTB.Name = "numeroTB";
            this.numeroTB.Size = new System.Drawing.Size(127, 20);
            this.numeroTB.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Puhelin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Huonetyyppi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Huoneen numero:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-62, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 79);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(345, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hallitse huoneita";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tyyppiCB
            // 
            this.tyyppiCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tyyppiCB.FormattingEnabled = true;
            this.tyyppiCB.Items.AddRange(new object[] {
            "Yhden hengen",
            "Kahden hengen",
            "Perhe",
            "Sviitti"});
            this.tyyppiCB.Location = new System.Drawing.Point(175, 152);
            this.tyyppiCB.Name = "tyyppiCB";
            this.tyyppiCB.Size = new System.Drawing.Size(127, 21);
            this.tyyppiCB.TabIndex = 26;
            // 
            // vapaaLB
            // 
            this.vapaaLB.AutoSize = true;
            this.vapaaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vapaaLB.Location = new System.Drawing.Point(96, 203);
            this.vapaaLB.Name = "vapaaLB";
            this.vapaaLB.Size = new System.Drawing.Size(66, 20);
            this.vapaaLB.TabIndex = 30;
            this.vapaaLB.Text = "Vapaa:";
            // 
            // kyllaRB
            // 
            this.kyllaRB.AutoSize = true;
            this.kyllaRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kyllaRB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kyllaRB.Location = new System.Drawing.Point(189, 205);
            this.kyllaRB.Name = "kyllaRB";
            this.kyllaRB.Size = new System.Drawing.Size(55, 20);
            this.kyllaRB.TabIndex = 31;
            this.kyllaRB.TabStop = true;
            this.kyllaRB.Text = "Kyllä";
            this.kyllaRB.UseVisualStyleBackColor = true;
            // 
            // eiRB
            // 
            this.eiRB.AutoSize = true;
            this.eiRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eiRB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.eiRB.Location = new System.Drawing.Point(250, 205);
            this.eiRB.Name = "eiRB";
            this.eiRB.Size = new System.Drawing.Size(38, 20);
            this.eiRB.TabIndex = 32;
            this.eiRB.TabStop = true;
            this.eiRB.Text = "Ei";
            this.eiRB.UseVisualStyleBackColor = true;
            // 
            // Huoneet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 492);
            this.Controls.Add(this.eiRB);
            this.Controls.Add(this.kyllaRB);
            this.Controls.Add(this.vapaaLB);
            this.Controls.Add(this.tyyppiCB);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.muokkaaBT);
            this.Controls.Add(this.lisaaBT);
            this.Controls.Add(this.huoneetDG);
            this.Controls.Add(this.puhelinTB);
            this.Controls.Add(this.numeroTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Huoneet";
            this.Text = "Huoneet";
            this.Load += new System.EventHandler(this.Huoneet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.huoneetDG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button poistaBT;
        private System.Windows.Forms.Button muokkaaBT;
        private System.Windows.Forms.Button lisaaBT;
        private System.Windows.Forms.DataGridView huoneetDG;
        private System.Windows.Forms.TextBox puhelinTB;
        private System.Windows.Forms.TextBox numeroTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tyyppiCB;
        private System.Windows.Forms.Label vapaaLB;
        private System.Windows.Forms.RadioButton kyllaRB;
        private System.Windows.Forms.RadioButton eiRB;
    }
}