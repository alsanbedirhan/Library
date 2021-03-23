using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pro
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(txtKullanici.Text=="admin" && txtSifre.Text=="1234")//küçük bi sorgu yapıyorum
            {
                Main form = new Main();//Main formuna gönderiyorum
                form.Show();
                this.Hide();
            }
            else if(txtKullanici.Text=="admin")
            {
                MessageBox.Show("Şifreniz Yanlış");
            }
            else if(txtSifre.Text=="1234")
            {
                MessageBox.Show("Kullanıcı Adı Yanlış");
            }
            else
            {
                MessageBox.Show("Yanlış bilgi girdiniz");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//arka planda bazen açık kalıyor kalmaması için ekledim
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
