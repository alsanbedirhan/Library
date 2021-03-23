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
    public partial class Kitap : Form
    {
        public Kitap()
        {
            InitializeComponent();
        }
        private void kitapListele()
        {
            List<EKITAP> kitapListesi = BLLKITAP.SelectList();
            dataGridView1.DataSource = kitapListesi;
            this.dataGridView1.Columns["ID"].Visible = false;//görünüm açısından id yi gizliyorum
        }
        private void Temizle()//texboxları temizlemek için fonsksiyon oluşturdum
        {
            txtAdı.Clear();
            txtSayfa.Clear();
            txtYazar.Clear();
        }

        private void Kitap_Load(object sender, EventArgs e)
        {
            kitapListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//seçilen değerleri texboxlara atıyorum
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAdı.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSayfa.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EKITAP kitapItem = new EKITAP();
            kitapItem.ADI = txtAdı.Text;
            kitapItem.YAZAR = txtYazar.Text;
            kitapItem.SAYFASAYISI = Convert.ToInt32(txtSayfa.Text);
            if (BLLKITAP.Insert(kitapItem) > 0)//ekleme işlemini kontrol ediyorum
            {
                Temizle();
                kitapListele();
                MessageBox.Show("Kitap Ekleme İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;//seçilen sütünün id sini alıyorum
            EKITAP kitapItem = new EKITAP();
            kitapItem.ID = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);
            if (BLLKITAP.Delete(kitapItem.ID) == true)//işlemi kontrol ediyorum
            {
                MessageBox.Show("Kitap Silme İşlemi Başarılı");
                kitapListele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EKITAP kitapItem = new EKITAP();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            kitapItem.ID = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);
            kitapItem.ADI = txtAdı.Text;
            kitapItem.YAZAR = txtYazar.Text;
            kitapItem.SAYFASAYISI = Convert.ToInt32(txtSayfa.Text);
            if (BLLKITAP.Update(kitapItem) == true)//işlemi kontrol ediyorum
            {
                MessageBox.Show("Kitap Güncelleme İşlemi Başarılı");
                kitapListele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }
        }
        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            Ogrenci form = new Ogrenci();//öğrenci formuna yönlendiriyorum
            form.Show();
            this.Hide();
        }

        private void btnMain_Click_1(object sender, EventArgs e)
        {
            Main form = new Main();//main formuna yönlendiriyorum
            form.Show();
            this.Hide();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            KitapSorgula srg = new KitapSorgula();//dialog ekranında sorguları getiriyorum
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            srg.kitapid = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);
            srg.ShowDialog();
        }

        private void Kitap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//arka planda bazen açık kalıyor kalmaması için ekledim
        }

        
    }
}
