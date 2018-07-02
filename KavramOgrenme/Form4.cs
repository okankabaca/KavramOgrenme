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
    public partial class Form4 : Form
    {
        public DataTable dataTable = new DataTable();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Width = Boyutlar.alansayisi * 120 + 100;
            veritablosu.Width = this.Width - 35;
            analizet.Width = this.Width - 35;
            label1.Width = this.Width - 35;
            combosonuc.Width = this.Width - 35;

            for (int i = 0; i < Boyutlar.alansayisi; i++) // sutunlar belli olur.
            {
                dataTable.Columns.Add(Boyutlar.tablodizisi[0, i].ToString());
            }
            dataTable.Columns.Add(Boyutlar.sonucdizisi[0].ToString());

            for (int i=1;i<Boyutlar.verisayisi + 1;i++)
            {
                DataRow rowlar = dataTable.NewRow();

                for (int k = 0; k < (Boyutlar.alansayisi + 1); k++) // sütünlar arası dolaşım
                {

                    if (k == Boyutlar.alansayisi)//sonuç değeri buradan okunuyor
                    {

                        rowlar["sonuç"] = Boyutlar.sonucdizisi[i].ToString();
                    }
                    else//satırdaki sütünlar soldan sağa sırayla burada okunuyor.
                    {
                        rowlar[Boyutlar.tablodizisi[0,k].ToString()] = Boyutlar.tablodizisi[i,k].ToString();
                    }
                    
                }
                dataTable.Rows.Add(rowlar);
            }
            veritablosu.DataSource = dataTable;

            for (int i = 1; i < Boyutlar.verisayisi + 1; i++)
            {
                if (combosonuc.FindString(Boyutlar.sonucdizisi[i])>=0)
                {
                    //MessageBox.Show("bu item var");
                }
                else{
                    combosonuc.Items.Add(Boyutlar.sonucdizisi[i].ToString());
                }
            }
            combosonuc.SelectedIndex = 0;

        }

        static int referanssayisi(string g_referans)
        {
            int sonuc=0;
            for (int satir = 1; satir < Boyutlar.verisayisi+1; satir++)
            {
                if (Boyutlar.sonucdizisi[satir] ==g_referans)
                {
                    sonuc++;
                }
            }
            return sonuc;
        }

        static string sutunreferansibelirle(string g_referans, int g_sutun)
        {
            string sonuc = "";
            for (int satir = 1; satir < Boyutlar.verisayisi + 1; satir++)
            {
                if (Boyutlar.sonucdizisi[satir] ==g_referans)
                {
                    sonuc = Boyutlar.tablodizisi[satir, g_sutun];
                }
            }
            return sonuc;
        }

        static int sutunreferanssayisi(string g_referans,int g_sutun)
        {
            string kontrol = sutunreferansibelirle(g_referans,g_sutun);
            int sonuc = 0;
            for (int satir = 1; satir < Boyutlar.verisayisi + 1; satir++)
            {
                if (Boyutlar.tablodizisi[satir, g_sutun] == kontrol)
                {
                    sonuc++;
                }
            }
            return sonuc;
        }



        private void analizet_Click(object sender, EventArgs e)
        {
            string referans = combosonuc.SelectedItem.ToString();
            int rsayisi = referanssayisi(referans); // sabit kalacak
            //MessageBox.Show(rsayisi.ToString());

            Boyutlar.analizdizisi = new string[Boyutlar.alansayisi];

            for (int sutun = 0; sutun < Boyutlar.alansayisi; sutun++) // sırasıyla bütün sutunlara bakacagız
            {

                int kontrol= (sutunreferanssayisi(referans, sutun)); // bu sayilar eşit değilse kesinlikle ? olacak
                if (kontrol!=rsayisi)
                {
                    Boyutlar.analizdizisi[sutun] = "?";
                }
                else
                {
                    Boyutlar.analizdizisi[sutun] = sutunreferansibelirle(referans,sutun);
                }
            }

            string sonifade = Boyutlar.analizdizisi[0];
            for (int i = 1; i < Boyutlar.analizdizisi.Length; i++)
            {
                sonifade = sonifade + " , " + Boyutlar.analizdizisi[i];
            }

            MessageBox.Show("Bu bilgilere göre bulunan sonuç verisi: " + sonifade);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }
    }
}
