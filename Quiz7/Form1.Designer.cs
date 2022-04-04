namespace Quiz7
{
    partial class FormQuizz
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
            this.labelkalimat = new System.Windows.Forms.Label();
            this.txtKalimat = new System.Windows.Forms.TextBox();
            this.txtHuruf = new System.Windows.Forms.TextBox();
            this.labelhuruf = new System.Windows.Forms.Label();
            this.txtGanti = new System.Windows.Forms.TextBox();
            this.labelmenjadi = new System.Windows.Forms.Label();
            this.btnKonversi = new System.Windows.Forms.Button();
            this.labelhasil = new System.Windows.Forms.Label();
            this.lblHasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelkalimat
            // 
            this.labelkalimat.AutoSize = true;
            this.labelkalimat.Location = new System.Drawing.Point(74, 92);
            this.labelkalimat.Name = "labelkalimat";
            this.labelkalimat.Size = new System.Drawing.Size(136, 20);
            this.labelkalimat.TabIndex = 0;
            this.labelkalimat.Text = "Masukkan kalimat";
            // 
            // txtKalimat
            // 
            this.txtKalimat.Location = new System.Drawing.Point(220, 89);
            this.txtKalimat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKalimat.Name = "txtKalimat";
            this.txtKalimat.Size = new System.Drawing.Size(548, 26);
            this.txtKalimat.TabIndex = 1;
            // 
            // txtHuruf
            // 
            this.txtHuruf.Location = new System.Drawing.Point(220, 124);
            this.txtHuruf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHuruf.Name = "txtHuruf";
            this.txtHuruf.Size = new System.Drawing.Size(69, 26);
            this.txtHuruf.TabIndex = 3;
            // 
            // labelhuruf
            // 
            this.labelhuruf.AutoSize = true;
            this.labelhuruf.Location = new System.Drawing.Point(74, 128);
            this.labelhuruf.Name = "labelhuruf";
            this.labelhuruf.Size = new System.Drawing.Size(123, 20);
            this.labelhuruf.TabIndex = 2;
            this.labelhuruf.Text = "Masukkan huruf";
            // 
            // txtGanti
            // 
            this.txtGanti.Location = new System.Drawing.Point(469, 128);
            this.txtGanti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGanti.Name = "txtGanti";
            this.txtGanti.Size = new System.Drawing.Size(69, 26);
            this.txtGanti.TabIndex = 5;
            // 
            // labelmenjadi
            // 
            this.labelmenjadi.AutoSize = true;
            this.labelmenjadi.Location = new System.Drawing.Point(370, 131);
            this.labelmenjadi.Name = "labelmenjadi";
            this.labelmenjadi.Size = new System.Drawing.Size(64, 20);
            this.labelmenjadi.TabIndex = 4;
            this.labelmenjadi.Text = "Menjadi";
            // 
            // btnKonversi
            // 
            this.btnKonversi.Location = new System.Drawing.Point(348, 200);
            this.btnKonversi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKonversi.Name = "btnKonversi";
            this.btnKonversi.Size = new System.Drawing.Size(84, 29);
            this.btnKonversi.TabIndex = 6;
            this.btnKonversi.Text = "Konversi";
            this.btnKonversi.UseVisualStyleBackColor = true;
            this.btnKonversi.Click += new System.EventHandler(this.btnKonversi_Click);
            // 
            // labelhasil
            // 
            this.labelhasil.AutoSize = true;
            this.labelhasil.Location = new System.Drawing.Point(74, 259);
            this.labelhasil.Name = "labelhasil";
            this.labelhasil.Size = new System.Drawing.Size(44, 20);
            this.labelhasil.TabIndex = 7;
            this.labelhasil.Text = "Hasil";
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(217, 259);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(0, 20);
            this.lblHasil.TabIndex = 9;
            // 
            // FormQuizz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 400);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.labelhasil);
            this.Controls.Add(this.btnKonversi);
            this.Controls.Add(this.txtGanti);
            this.Controls.Add(this.labelmenjadi);
            this.Controls.Add(this.txtHuruf);
            this.Controls.Add(this.labelhuruf);
            this.Controls.Add(this.txtKalimat);
            this.Controls.Add(this.labelkalimat);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormQuizz";
            this.Text = "FormQuizPanda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelkalimat;
        private System.Windows.Forms.TextBox txtKalimat;
        private System.Windows.Forms.TextBox txtHuruf;
        private System.Windows.Forms.Label labelhuruf;
        private System.Windows.Forms.TextBox txtGanti;
        private System.Windows.Forms.Label labelmenjadi;
        private System.Windows.Forms.Button btnKonversi;
        private System.Windows.Forms.Label labelhasil;
        private System.Windows.Forms.Label lblHasil;
    }
}

