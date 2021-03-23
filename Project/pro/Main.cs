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
using ZedGraph;

namespace pro
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void kitapliste()//kitapları listelemek için fonksiyon oluşturdum
        {
            List<EKITAP> kitapListesi = BLLKITAP.SelectList();         
            cmbKitap.DataSource = kitapListesi;//databesden gelen verileri comboboxa aktardım
            cmbKitap.DisplayMember = "ADI";//aktardığım verilerinin adının görünüp idsini döndürmesini sağladım
            cmbKitap.ValueMember = "ID";
        }
        private void ogrenciListe()//öğrencileri listelemek için fonksiyon oluşturdum
        {
            List<EOGRENCI> ogrenciListesi = BLLOGRENCI.SelectList();          
            cmbOgrenci.DataSource = ogrenciListesi;//databesden gelen verileri comboboxa aktardım
            cmbOgrenci.DisplayMember = "NUMARA";//aktardığım verilerinin adının görünüp idsini döndürmesini sağladım
            cmbOgrenci.ValueMember = "ID";
           
        }
        private void tarihsorunu()//databasedeki öğrencinin getirdiği tarihi yazmak için oluşturduğum başlık null dönmüyor ve bi tarihi atıyor
        {//bunu kontrol etmek için bi fonksiyon oluşturdum
            TimeSpan ada;//2 gün kalan satırların sarı renkte olması için değişken tanımladım
            var firstdate = new DateTime(2001, 1, 1);//tarih bu 
            for (int counter = 0; counter < dataGridView1.Rows.Count; counter++)//bütün tabloyu dolanıyor
            {
                if (Convert.ToDateTime(dataGridView1.Rows[counter].Cells["GETGMT"].Value) == firstdate)//database'in atadığı tarihi kullanıcıya göstermemek için sorgu
                {
                    dataGridView1.Rows[counter].Cells["GETGMT"].Value = null;//null atıyorum 
                    ada = Convert.ToDateTime(dataGridView1.Rows[counter].Cells["SONGMT"].Value) - DateTime.Today;
                    if (ada.TotalDays == 2 || ada.TotalDays == 1 || ada.TotalDays == 0)//eğer 2 gün ,1 gün ya da 0 gün kaldıysa sarı renk oluyor
                    {                        
                        dataGridView1.Rows[counter].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else
                    {                        
                        dataGridView1.Rows[counter].DefaultCellStyle.BackColor = Color.Red;
                    }                    
                } 
                else
                {                                       
                     dataGridView1.Rows[counter].DefaultCellStyle.BackColor = Color.Green;//eğer if'e girmez ise demekki kitap geri getirilmiştir o yüzden                             
                }             
            }
        }
        private void islemlerListele()//İşlemleri listelemek için fonksiyon oluşturdum
        {                       
            List<EISLEMLER> islemListesi = BLLISLEMLER.SelectList();
            dataGridView1.DataSource = islemListesi;
            this.dataGridView1.Columns["ID"].Visible = false;//güzel görünüm açısından idlerin görünmesini engelledim 
            this.dataGridView1.Columns["KITAPID"].Visible = false;
            this.dataGridView1.Columns["OGRENCIID"].Visible = false;
            tarihsorunu();            
        }
        private void borc()
        {            
            int secilen = dataGridView1.SelectedCells[0].RowIndex;//seçilen satırın idsini alıyor
            TimeSpan ada;
            ada = DateTime.Today - Convert.ToDateTime(dataGridView1.Rows[secilen].Cells[4].Value);//borcu hesaplıyorum
            if (Convert.ToInt32(ada.TotalDays) > 0)
            {
                MessageBox.Show("Borcunuz " + ada.TotalDays + "'dır");
            }
            else//zamanında ya da zamanından önce getirdiyse borcu yoktur
            {
                MessageBox.Show("Kitap Geri Verme İşleminiz Tamamlanmıştır");
            }
        }
        private void btnOgrenci_Click_1(object sender, EventArgs e)
        {
            Ogrenci form = new Ogrenci();//öğrenci formuna gönderiyorum
            form.Show();
            this.Hide();
        }
        
        private void btnKitap_Click_1(object sender, EventArgs e)
        {
            Kitap form = new Kitap();//kitap formuna gönderiyorum
            form.Show();
            this.Hide();
        }

        private void zed()
        {
            GraphPane myPane;
            myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Çalıştıramadım";
            myPane.XAxis.Title.Text = "Öğrenci";
            myPane.YAxis.Title.Text = "Kitaplar";
        }
        private void Main_Load(object sender, EventArgs e)
        {
            islemlerListele();//fonksiyonları form yüklendiği zaman çağırıyorum
            kitapliste();
            ogrenciListe();
            zed();
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            var value = new DateTime(2001, 1, 1);
            EISLEMLER islemListesi = new EISLEMLER();          
            islemListesi.KITAPID = Convert.ToInt32(cmbKitap.SelectedValue);
            islemListesi.OGRENCIID = Convert.ToInt32(cmbOgrenci.SelectedValue);
            islemListesi.GMT = DateTime.Today;
            islemListesi.SONGMT = dateTimePicker1.Value.Date;
            islemListesi.GETGMT = Convert.ToDateTime(null);
            EISLEMLER denem = BLLISLEMLER.Select(Convert.ToInt32(cmbKitap.SelectedValue));//kitabın stokta olup olmadığını sorguluyorum
            if(denem != null)//null olup olmadığını kontrol ediyorum
            {
                if (DateTime.Equals(denem.GETGMT, value))//eşitse kitap stokta yok demektir
                {
                    MessageBox.Show("Kitap Stokta Yok");
                }

                else if (denem.GETGMT <= DateTime.Today)//ife girmez ise stokta var demektir
                {                    
                    if (BLLISLEMLER.Insert(islemListesi) > 0)
                    {
                        islemlerListele();
                        MessageBox.Show("Kitap Alma İşlemi Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Bir Sorun Oluştu");
                    }
                }               
                
            }
            else//nullsa stokta vardır demektir
            {
                if (BLLISLEMLER.Insert(islemListesi) > 0)
                {
                    islemlerListele();
                    MessageBox.Show("Kitap Alma İşlemi Başarılı");
                }
                else
                {
                    MessageBox.Show("Bir Sorun Oluştu");
                }
            }
        }
        private void btnVer_Click(object sender, EventArgs e)
        {
            EISLEMLER islemListesi = new EISLEMLER();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            islemListesi.ID = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);            
            islemListesi.GETGMT = DateTime.Today;//sadece getirdiği tarihi döndüp onu güncelliyorum   
            if (BLLISLEMLER.Update(islemListesi) == true)//sorun olup olmadığını sorguluyorum
            {
                borc();//borcu varsa ekrana yazdır
                islemlerListele();           
            }
            else
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {
            OgrenciSorgula srg = new OgrenciSorgula();
            srg.ogrenciid = Convert.ToInt32(cmbOgrenci.SelectedValue);//idyi yollayıp farklı bir formda aratıyorum
            srg.ShowDialog();
        }

        private void btnHepsi_Click(object sender, EventArgs e)
        {
            islemlerListele();
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKitapSirala_Click(object sender, EventArgs e)
        {
            KitapSorgula srg = new KitapSorgula();            
            srg.kitapid = Convert.ToInt32(cmbKitap.SelectedValue);//idyi yollayıp farklı bir formda aratıyorum
            srg.ShowDialog();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//arka planda bazen açık kalıyor kalmaması için ekledim
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
