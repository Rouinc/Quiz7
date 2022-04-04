using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz7
{
    public partial class FormQuizz : Form
    {
        public FormQuizz()
        {
            InitializeComponent();
        }

        private void btnKonversi_Click(object sender, EventArgs e)
        {
            string kalimat = txtKalimat.Text;
            int []data = new int [kalimat.Length];
            int selisih;

            kalimat = kalimat.ToUpper(); 

            
            for(int i = 0; i < data.Length; i++)
            {
                data[i] = (int)kalimat[i];
            }

            
            string huruf, ganti;
            huruf = txtHuruf.Text;
            ganti = txtGanti.Text;

            huruf = huruf.ToLower();
            ganti = ganti.ToLower();

            char ch, cg;
            ch = huruf[0];
            cg = ganti[0];

            selisih = ((int)ch - (int)cg);  

            
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] != 32)
                {
                    data[i] = (int)kalimat[i] - selisih;

                    if (data[i] < 65)
                    {
                        int delta = 65 - data[i];
                        data[i] = 91 - delta;
                    }

                    if (data[i] > 90)
                    {
                        int delta = data[i] - 90;
                        data[i] = 64 + delta;
                    }
                }
            }

            
            var kal = new System.Text.StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                char a = (char)data[i]; 
                kal.Append(a);
            }
            lblHasil.Text = "" + kal;
        }
    }
}
