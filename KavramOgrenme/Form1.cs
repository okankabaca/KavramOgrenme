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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sonrakiadim_Click(object sender, EventArgs e)
        {   
            if (textalansayisi.Text.Length>0 && textverisayisi.Text.Length>0)
            {
                //Gerekli boyuttaki dizileri ayarlamak için kullanıcıdan gireceği alan sayısını aldık.
                Boyutlar.alansayisi = Convert.ToInt32(textalansayisi.Text);
                //Yine kullanıcıdan o alanlara kaçar tane öğrenme verisi gireceğini aldık.
                Boyutlar.verisayisi = Convert.ToInt32(textverisayisi.Text);
                //MessageBox.Show(Boyutlar.alansayisi.ToString() + "," + Boyutlar.verisayisi.ToString());

                Boyutlar.tablodizisi = new String[Boyutlar.verisayisi + 1, Boyutlar.alansayisi];
                //Dizilerimin 0.Satırında herzaman alan adlarını tutacağım için +1 ekledim.
                Boyutlar.sonucdizisi = new String[Boyutlar.verisayisi + 1];
                Boyutlar.sonucdizisi[0] = "sonuç";
                //MessageBox.Show(Boyutlar.sonucdizisi[0]);

                Form2 form2 = new Form2();
                MessageBox.Show("Sonraki forma yönlendiriliyorsunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form2.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Alan sayıları boş olamaz.","Uyarı", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           

        }

        private void textalansayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textverisayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
