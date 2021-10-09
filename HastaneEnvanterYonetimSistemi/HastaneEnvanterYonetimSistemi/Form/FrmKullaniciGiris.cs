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
        public static TBLKullanıcı USER;
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
            if (KullaniciKontrol(TxtKullaniciAdi.Text, TxtSifre.Text))
            {
                MessageBox.Show("Giriş Başarılı!");
                this.Hide();
                ((FrmEnvanter)this.ParentForm).TabControlEnvanter.Visible = true;
                ((FrmEnvanter)this.ParentForm).FrmEnvanter_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }
        }
        public bool KullaniciKontrol(string kAdi, string kParola)
        {
            var sorgu = from p in db.TBLKullanıcı
                        where p.TCNo == kAdi
                         && p.Parola == kParola
                        select p;
            if (sorgu.Any())
            {
                USER = new TBLKullanıcı();
                foreach (var p in sorgu)
                {
                    USER.Ad = p.Ad;
                    USER.ID = p.ID;
                    USER.YetkiDurumu = p.YetkiDurumu;
                    USER.TCNo = p.TCNo;
                    USER.Soyad = p.Soyad;
                    USER.Parola = p.Parola;
                    USER.Mail = p.Mail;
                    USER.DahiliNo = p.DahiliNo;
                    USER.CalistigiBirim = p.CalistigiBirim;
                    USER.Fotograf = p.Fotograf;
                }
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
