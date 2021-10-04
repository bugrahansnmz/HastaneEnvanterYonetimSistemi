using HastaneEnvanterYonetimSistemi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneEnvanterYonetimSistemi
{
    public partial class FrmKullaniciGiris : Form
    {
        DbHEYSEntities db = new DbHEYSEntities();
        public FrmKullaniciGiris()
        {
            InitializeComponent();
        }
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (YetkiliKullaniciKontrol(TxtKullaniciAdi.Text, TxtSifre.Text))
            {
                MessageBox.Show("Yetkili Girişi");
                this.Hide();
                ((FrmEnvanter)this.ParentForm).TabControlEnvanter.Visible = true;
            }
            else if (TeknikServisKullaniciKontrol(TxtKullaniciAdi.Text, TxtSifre.Text))
            {
                MessageBox.Show("Teknik servis Girişi");
                this.Hide();
            }
            else if (BilgiIslemKullaniciKontrol(TxtKullaniciAdi.Text, TxtSifre.Text))
            {
                MessageBox.Show("Bilgi işlem Girişi");
                this.Hide();
            }
            else if (SefKullaniciKontrol(TxtKullaniciAdi.Text, TxtSifre.Text))
            {
                MessageBox.Show("Sef Girişi");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }


        }
        public bool YetkiliKullaniciKontrol(string kAdi, string kParola)
        {
            var sorgu = from p in db.TBLKullanıcı
                        where p.TCNo == kAdi
                         && p.Parola == kParola && p.YetkiDurumu == 1
                        select p;
            if (sorgu.Any())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool TeknikServisKullaniciKontrol(string kAdi, string kParola)
        {
            var sorgu = from p in db.TBLKullanıcı
                        where p.TCNo == kAdi
                         && p.Parola == kParola && p.YetkiDurumu == 2
                        select p;
            if (sorgu.Any())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool BilgiIslemKullaniciKontrol(string kAdi, string kParola)
        {
            var sorgu = from p in db.TBLKullanıcı
                        where p.TCNo == kAdi
                         && p.Parola == kParola && p.YetkiDurumu == 3
                        select p;
            if (sorgu.Any())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool SefKullaniciKontrol(string kAdi, string kParola)
        {
            var sorgu = from p in db.TBLKullanıcı
                        where p.TCNo == kAdi
                         && p.Parola == kParola && p.YetkiDurumu == 4
                        select p;
            if (sorgu.Any())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
