using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BusinessLogicLayer;

namespace pro
{
    public partial class Ogrenci : Form
    {
        public Ogrenci()
        {
            InitializeComponent();
        }
        private void ogrenciListele()//öğrencileri listelemek için fonksiyon tanımladım
        {
            List<EOGRENCI> ogrenciListesi = BLLOGRENCI.SelectList();
            dataGridView1.DataSource = ogrenciListesi;
            this.dataGridView1.Columns["ID"].Visible = false;//id sini görünüm açısından gizliyorum
        }
        private void Temizle()//texboxları temizlemek için fonksiyon oluşturdum
        {
            txtOgrenciAdı.Clear();
            txtOgrenciSoyadi.Clear();
            txtNumara.Clear();
        }

        private void Ogrenci_Load(object sender, EventArgs e)
        {
            ogrenciListele();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//seçilen satırdaki verileri texboxlara aktarıyorum
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtOgrenciAdı.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtOgrenciSoyadi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtNumara.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            EOGRENCI ogrenciListesi = new EOGRENCI();
            ogrenciListesi.ADI = txtOgrenciAdı.Text;
            ogrenciListesi.SOYADI = txtOgrenciSoyadi.Text;
            ogrenciListesi.NUMARA = Convert.ToInt32(txtNumara.Text);
            if (BLLOGRENCI.Insert(ogrenciListesi) > 0)//eklemede bir hata var mı diye kontrol ediyorum
            {
                ogrenciListele();
                Temizle();
                MessageBox.Show("Öğrenci Ekleme İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;//seçilen satırın id sini alıyorum
            EOGRENCI ogrenciListesi = new EOGRENCI();
            ogrenciListesi.ID = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);//id ye atıyorum

            if (BLLOGRENCI.Delete(ogrenciListesi.ID) == true)//sorun olup olmadığını kontrol ediyorum
            {
                ogrenciListele();
                Temizle();
                MessageBox.Show("Öğrenci Silme İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EOGRENCI ogrenciListesi = new EOGRENCI();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            ogrenciListesi.ID = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);
            ogrenciListesi.ADI = txtOgrenciAdı.Text;
            ogrenciListesi.SOYADI = txtOgrenciSoyadi.Text;
            ogrenciListesi.NUMARA = Convert.ToInt32(txtNumara.Text);
            if (BLLOGRENCI.Update(ogrenciListesi) == true)//güncelleme işlemini kontrol ediyorum
            {
                Temizle();
                ogrenciListele();
                MessageBox.Show("Öğrenci Güncelleme İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }
        }

        private void btnKitap_Click(object sender, EventArgs e)
        {
            Kitap form = new Kitap();//kitap formuna yönlendiriyorum
            form.Show();
            this.Hide();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            Main form = new Main();//main formuna yönlendiriyorum
            form.Show();
            this.Hide();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            OgrenciSorgula srg = new OgrenciSorgula();//farklı bir formda gösteriyorum
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            srg.ogrenciid = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);
            srg.ShowDialog();            
        }

        private void Ogrenci_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//arka planda bazen açık kalıyor kalmaması için ekledim
        }
    }
}
