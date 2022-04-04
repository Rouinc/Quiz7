namespace Quiz7
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
            this.txtKalimat = new System.Windows.Forms.TextBox();
            this.txtHuruf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGanti = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKonversi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan kalimat";
            // 
            // txtKalimat
            // 
            this.txtKalimat.Location = new System.Drawing.Point(196, 71);
            this.txtKalimat.Name = "txtKalimat";
            this.txtKalimat.Size = new System.Drawing.Size(488, 22);
            this.txtKalimat.TabIndex = 1;
            // 
            // txtHuruf
            // 
            this.txtHuruf.Location = new System.Drawing.Point(196, 99);
            this.txtHuruf.Name = "txtHuruf";
            this.txtHuruf.Size = new System.Drawing.Size(62, 22);
            this.txtHuruf.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Masukkan huruf";
            // 
            // txtGanti
            // 
            this.txtGanti.Location = new System.Drawing.Point(417, 102);
            this.txtGanti.Name = "txtGanti";
            this.txtGanti.Size = new System.Drawing.Size(62, 22);
            this.txtGanti.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Menjadi";
            // 
            // btnKonversi
            // 
            this.btnKonversi.Location = new System.Drawing.Point(309, 160);
            this.btnKonversi.Name = "btnKonversi";
            this.btnKonversi.Size = new System.Drawing.Size(75, 23);
            this.btnKonversi.TabIndex = 6;
            this.btnKonversi.Text = "Konversi";
            this.btnKonversi.UseVisualStyleBackColor = true;
            this.btnKonversi.Click += new System.EventHandler(this.btnKonversi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasil";
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(193, 207);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(38, 16);
            this.lblHasil.TabIndex = 9;
            this.lblHasil.Text = "Hasil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 320);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKonversi);
            this.Controls.Add(this.txtGanti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHuruf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKalimat);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKalimat;
        private System.Windows.Forms.TextBox txtHuruf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGanti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKonversi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHasil;
    }
}

