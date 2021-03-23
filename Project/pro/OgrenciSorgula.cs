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
    public partial class OgrenciSorgula : Form
    {
        public OgrenciSorgula()
        {
            InitializeComponent();
        }
        public int ogrenciid { get; set; }//diğer formlardan id almak için public değer tanımladım
        private void tarihsorunu()//databasedeki öğrencinin getirdiği tarihi yazmak için oluşturduğum başlık null dönmüyor ve bi tarihi atıyor
        {//bunu kontrol etmek için bi fonksiyon oluşturdum
            var firstdate = new DateTime(2001, 1, 1);//tarih bu 
            TimeSpan ada;//2 gün kalan satırların sarı renkte olması için değişken tanımladım
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
        private void listele()//listelemek için fonksiyon oluşturdum
        {
            List<EISLEMLER> denem = BLLISLEMLER.Select2(ogrenciid);
            dataGridView1.DataSource = denem;
            this.dataGridView1.Columns["ID"].Visible = false;//görüntü açısından id leri gizliyorum
            this.dataGridView1.Columns["KITAPID"].Visible = false;
            this.dataGridView1.Columns["OGRENCIID"].Visible = false;
            tarihsorunu();
        }
        private void OgrenciSorgula_Load(object sender, EventArgs e)
        {
            listele();            
        }       

        private void OgrenciSorgula_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();//normalde bunu arka planda açık kalıyor diye her forma eklemiştim ama bunlar dialog olduğu için bunlardan çıkardım
        }
    }
}
