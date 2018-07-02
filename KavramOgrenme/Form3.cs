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
    public partial class Form3 : Form
    {
        public DataTable dataTable = new DataTable();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < Boyutlar.alansayisi; i++) {
                dataTable.Columns.Add(Boyutlar.tablodizisi[0, i].ToString());
            }
            dataTable.Columns.Add(Boyutlar.sonucdizisi[0].ToString());
            veritablosu.DataSource = dataTable;

            this.Width = Boyutlar.alansayisi * 120+100;
            veritablosu.Width = this.Width - 35;
            veriekle.Width = this.Width - 35;

         }

        private void veriekle_Click(object sender, EventArgs e)
        {
            if (veritablosu.RowCount * veritablosu.ColumnCount >= Boyutlar.alansayisi + 1 * Boyutlar.verisayisi)
            {
                for (int i = 0; i < Boyutlar.verisayisi; i++) // satırlar arası dolaşım
                {

                    for (int k = 0; k < (Boyutlar.alansayisi + 1); k++) // sütünlar arası dolaşım
                    {

                        if (k == Boyutlar.alansayisi)//sonuç değeri buradan okunuyor
                        {
                            //MessageBox.Show(veritablosu.Rows[i].Cells["sonuç"].FormattedValue.ToString());
                            Boyutlar.sonucdizisi[i + 1] = veritablosu.Rows[i].Cells["sonuç"].FormattedValue.ToString();

                        }
                        else//satırdaki sütünlar soldan sağa sırayla burada okunuyor.
                        {
                            //MessageBox.Show(veritablosu.Rows[i].Cells[Boyutlar.tablodizisi[0,k].ToString()].FormattedValue.ToString());
                            Boyutlar.tablodizisi[i + 1, k] = veritablosu.Rows[i].Cells[Boyutlar.tablodizisi[0, k].ToString()].FormattedValue.ToString();
                        }
                    }
                }
                //Dizilerdeki son değerlerin kontrolü
                //MessageBox.Show(Boyutlar.sonucdizisi[Boyutlar.verisayisi]);
                //MessageBox.Show(Boyutlar.tablodizisi[Boyutlar.verisayisi,Boyutlar.alansayisi-1]);
                MessageBox.Show("Sonraki forma yönlendiriliyorsunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form4 form4 = new Form4();
                form4.Show();
                this.Close();
            }
            else
            {

                MessageBox.Show("Doldurduğunuz veriler eksik olabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
                      
           
        }


    }
}
