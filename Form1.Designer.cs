namespace Kalkulator
{
    partial class Form1
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
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.tbWynik = new System.Windows.Forms.TextBox();
            this.bMnozenie = new System.Windows.Forms.Button();
            this.bDzielenie = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bWynik = new System.Windows.Forms.Button();
            this.bDodawanie = new System.Windows.Forms.Button();
            this.bOdejmowanie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(107, 100);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(41, 23);
            this.b1.TabIndex = 0;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(62, 100);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(40, 23);
            this.b2.TabIndex = 1;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(17, 100);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(40, 23);
            this.b3.TabIndex = 2;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(107, 71);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(41, 23);
            this.b4.TabIndex = 3;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.button4_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(62, 71);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(40, 23);
            this.b5.TabIndex = 4;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(16, 71);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(40, 23);
            this.b6.TabIndex = 5;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(109, 38);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(39, 23);
            this.b7.TabIndex = 6;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(62, 38);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(42, 23);
            this.b8.TabIndex = 7;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(16, 38);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(40, 23);
            this.b9.TabIndex = 8;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // tbWynik
            // 
            this.tbWynik.Location = new System.Drawing.Point(16, 12);
            this.tbWynik.Name = "tbWynik";
            this.tbWynik.Size = new System.Drawing.Size(177, 20);
            this.tbWynik.TabIndex = 9;
            this.tbWynik.TextChanged += new System.EventHandler(this.tbWynik_TextChanged);
            // 
            // bMnozenie
            // 
            this.bMnozenie.Location = new System.Drawing.Point(154, 100);
            this.bMnozenie.Name = "bMnozenie";
            this.bMnozenie.Size = new System.Drawing.Size(39, 23);
            this.bMnozenie.TabIndex = 10;
            this.bMnozenie.Text = "*";
            this.bMnozenie.UseVisualStyleBackColor = true;
            this.bMnozenie.Click += new System.EventHandler(this.bMnozenie_Click);
            // 
            // bDzielenie
            // 
            this.bDzielenie.Location = new System.Drawing.Point(154, 129);
            this.bDzielenie.Name = "bDzielenie";
            this.bDzielenie.Size = new System.Drawing.Size(39, 23);
            this.bDzielenie.TabIndex = 11;
            this.bDzielenie.Text = "/";
            this.bDzielenie.UseVisualStyleBackColor = true;
            this.bDzielenie.Click += new System.EventHandler(this.bDzielenie_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(16, 129);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(41, 23);
            this.b0.TabIndex = 12;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // bWynik
            // 
            this.bWynik.Location = new System.Drawing.Point(62, 129);
            this.bWynik.Name = "bWynik";
            this.bWynik.Size = new System.Drawing.Size(86, 23);
            this.bWynik.TabIndex = 13;
            this.bWynik.Text = "=";
            this.bWynik.UseVisualStyleBackColor = true;
            this.bWynik.Click += new System.EventHandler(this.bWynik_Click);
            // 
            // bDodawanie
            // 
            this.bDodawanie.Location = new System.Drawing.Point(154, 38);
            this.bDodawanie.Name = "bDodawanie";
            this.bDodawanie.Size = new System.Drawing.Size(39, 23);
            this.bDodawanie.TabIndex = 14;
            this.bDodawanie.Text = "+";
            this.bDodawanie.UseVisualStyleBackColor = true;
            this.bDodawanie.Click += new System.EventHandler(this.bDodawanie_Click);
            // 
            // bOdejmowanie
            // 
            this.bOdejmowanie.Location = new System.Drawing.Point(154, 71);
            this.bOdejmowanie.Name = "bOdejmowanie";
            this.bOdejmowanie.Size = new System.Drawing.Size(39, 23);
            this.bOdejmowanie.TabIndex = 15;
            this.bOdejmowanie.Text = "-";
            this.bOdejmowanie.UseVisualStyleBackColor = true;
            this.bOdejmowanie.Click += new System.EventHandler(this.bOdejmowanie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 182);
            this.Controls.Add(this.bOdejmowanie);
            this.Controls.Add(this.bDodawanie);
            this.Controls.Add(this.bWynik);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bDzielenie);
            this.Controls.Add(this.bMnozenie);
            this.Controls.Add(this.tbWynik);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.TextBox tbWynik;
        private System.Windows.Forms.Button bMnozenie;
        private System.Windows.Forms.Button bDzielenie;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bWynik;
        private System.Windows.Forms.Button bDodawanie;
        private System.Windows.Forms.Button bOdejmowanie;
    }
}

