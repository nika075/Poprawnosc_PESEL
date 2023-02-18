namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cyfry = new System.Windows.Forms.Label();
            this.tbCyfry = new System.Windows.Forms.TextBox();
            this.bGenerujCyfreKontrolna = new System.Windows.Forms.Button();
            this.lPesel = new System.Windows.Forms.Label();
            this.tbPesel = new System.Windows.Forms.TextBox();
            this.bSprawdzPesel = new System.Windows.Forms.Button();
            this.lPeselPopr = new System.Windows.Forms.Label();
            this.lPeselPoprawnosc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cyfry
            // 
            this.Cyfry.AutoSize = true;
            this.Cyfry.Location = new System.Drawing.Point(33, 26);
            this.Cyfry.Name = "Cyfry";
            this.Cyfry.Size = new System.Drawing.Size(56, 20);
            this.Cyfry.TabIndex = 0;
            this.Cyfry.Text = "10 cyfr:";
            // 
            // tbCyfry
            // 
            this.tbCyfry.Location = new System.Drawing.Point(108, 26);
            this.tbCyfry.MaxLength = 10;
            this.tbCyfry.Name = "tbCyfry";
            this.tbCyfry.Size = new System.Drawing.Size(125, 27);
            this.tbCyfry.TabIndex = 1;
            // 
            // bGenerujCyfreKontrolna
            // 
            this.bGenerujCyfreKontrolna.Location = new System.Drawing.Point(33, 75);
            this.bGenerujCyfreKontrolna.Name = "bGenerujCyfreKontrolna";
            this.bGenerujCyfreKontrolna.Size = new System.Drawing.Size(224, 29);
            this.bGenerujCyfreKontrolna.TabIndex = 2;
            this.bGenerujCyfreKontrolna.Text = "Generuj cyfrę kontrolną";
            this.bGenerujCyfreKontrolna.UseVisualStyleBackColor = true;
            this.bGenerujCyfreKontrolna.Click += new System.EventHandler(this.bGenerujCyfreKontrolna_Click);
            // 
            // lPesel
            // 
            this.lPesel.AutoSize = true;
            this.lPesel.Location = new System.Drawing.Point(33, 126);
            this.lPesel.Name = "lPesel";
            this.lPesel.Size = new System.Drawing.Size(49, 20);
            this.lPesel.TabIndex = 3;
            this.lPesel.Text = "Pesel: ";
            // 
            // tbPesel
            // 
            this.tbPesel.Location = new System.Drawing.Point(109, 129);
            this.tbPesel.Name = "tbPesel";
            this.tbPesel.ReadOnly = true;
            this.tbPesel.Size = new System.Drawing.Size(125, 27);
            this.tbPesel.TabIndex = 4;
            // 
            // bSprawdzPesel
            // 
            this.bSprawdzPesel.Location = new System.Drawing.Point(33, 171);
            this.bSprawdzPesel.Name = "bSprawdzPesel";
            this.bSprawdzPesel.Size = new System.Drawing.Size(224, 29);
            this.bSprawdzPesel.TabIndex = 5;
            this.bSprawdzPesel.Text = "Sprawdź pesel";
            this.bSprawdzPesel.UseVisualStyleBackColor = true;
            this.bSprawdzPesel.Click += new System.EventHandler(this.bSprawdzPesel_Click);
            // 
            // lPeselPopr
            // 
            this.lPeselPopr.AutoSize = true;
            this.lPeselPopr.Location = new System.Drawing.Point(34, 218);
            this.lPeselPopr.Name = "lPeselPopr";
            this.lPeselPopr.Size = new System.Drawing.Size(51, 20);
            this.lPeselPopr.TabIndex = 6;
            this.lPeselPopr.Text = "PESEL:";
            // 
            // lPeselPoprawnosc
            // 
            this.lPeselPoprawnosc.AutoSize = true;
            this.lPeselPoprawnosc.Location = new System.Drawing.Point(104, 222);
            this.lPeselPoprawnosc.Name = "lPeselPoprawnosc";
            this.lPeselPoprawnosc.Size = new System.Drawing.Size(0, 20);
            this.lPeselPoprawnosc.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 8;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 47);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 24);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "żeńska";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(121, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 24);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "męska";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(353, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 125);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "płeć";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lPeselPoprawnosc);
            this.Controls.Add(this.lPeselPopr);
            this.Controls.Add(this.bSprawdzPesel);
            this.Controls.Add(this.tbPesel);
            this.Controls.Add(this.lPesel);
            this.Controls.Add(this.bGenerujCyfreKontrolna);
            this.Controls.Add(this.tbCyfry);
            this.Controls.Add(this.Cyfry);
            this.Name = "Form1";
            this.Text = "POPRAWNOŚĆ PESEL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Cyfry;
        private TextBox tbCyfry;
        private Button bGenerujCyfreKontrolna;
        private Label lPesel;
        private TextBox tbPesel;
        private Button bSprawdzPesel;
        private Label lPeselPopr;
        private Label lPeselPoprawnosc;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
    }
}