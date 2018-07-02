using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KavramOgrenme
{
    public partial class Form2 : Form
    {
        int alanadi = 1;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            alanadiekle.Text = (alanadi.ToString() +".alan adını ekle");
        }

        private void alanadiekle_Click(object sender, EventArgs e)
        {
            if (textalanadi.Text.Length>0)
            {// Burada textbox boşluğu kontrolü yapılır
                if (alanadi <= Boyutlar.alansayisi)  
                {
                    Boyutlar.tablodizisi[0, (alanadi - 1)] = textalanadi.Text;
                    alanadi++;
                    if (alanadi == Boyutlar.alansayisi + 1) // +1 çünkü alanadi 1 fazla oluyor. 
                    {
                        label1.Visible = true;
                        textalanadi.Enabled = false;
                        alanadiekle.Text = "Sonraki adıma geç";
                    }
                    else
                    {
                        alanadiekle.Text = (alanadi.ToString() + ".alan adını ekle");
                        textalanadi.Text = "";
                    }
                }
                else
                {
                    //MessageBox.Show(Boyutlar.tablodizisi[0,alanadi-2]); 
                    MessageBox.Show("Sonraki forma yönlendiriliyorsunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Alan adları boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult sonuc;
            //sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
           //if (sonuc == DialogResult.Yes)
            //{
           //     Application.Exit();
            //}
            //else
            //{
                //e.Cancel = true;
            //}
        }

        private void textalanadi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
