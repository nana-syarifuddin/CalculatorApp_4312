
namespace CalculatorWindowsFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNilaiA = new System.Windows.Forms.TextBox();
            this.txtNilaiB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOperasi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHitung = new System.Windows.Forms.Button();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nilai A";
            // 
            // txtNilaiA
            // 
            this.txtNilaiA.Location = new System.Drawing.Point(85, 81);
            this.txtNilaiA.Name = "txtNilaiA";
            this.txtNilaiA.Size = new System.Drawing.Size(100, 20);
            this.txtNilaiA.TabIndex = 2;
            // 
            // txtNilaiB
            // 
            this.txtNilaiB.Location = new System.Drawing.Point(85, 107);
            this.txtNilaiB.Name = "txtNilaiB";
            this.txtNilaiB.Size = new System.Drawing.Size(100, 20);
            this.txtNilaiB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nilai B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Operasi";
            // 
            // cmbOperasi
            // 
            this.cmbOperasi.FormattingEnabled = true;
            this.cmbOperasi.Items.AddRange(new object[] {
            "Penambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian",
            "Pangkat",
            "Module"});
            this.cmbOperasi.Location = new System.Drawing.Point(85, 54);
            this.cmbOperasi.Name = "cmbOperasi";
            this.cmbOperasi.Size = new System.Drawing.Size(100, 21);
            this.cmbOperasi.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hasil";
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(85, 159);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(100, 23);
            this.btnHitung.TabIndex = 9;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click_1);
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(85, 133);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.ReadOnly = true;
            this.txtHasil.Size = new System.Drawing.Size(100, 20);
            this.txtHasil.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 211);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbOperasi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNilaiB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNilaiA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNilaiA;
        private System.Windows.Forms.TextBox txtNilaiB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOperasi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.TextBox txtHasil;
    }
}

