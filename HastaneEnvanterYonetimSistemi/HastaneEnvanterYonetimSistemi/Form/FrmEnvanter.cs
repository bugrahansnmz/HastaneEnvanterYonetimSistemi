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
    public partial class FrmEnvanter : Form
    {
        DbHEYSEntities db = new DbHEYSEntities();
        public FrmEnvanter()
        {
            InitializeComponent();
        }

        public void FrmEnvanter_Load(object sender, EventArgs e)
        {
            EnvanterListele();
            TeknikServisListele();
            BilgiIslemListele();
            if (TabControlEnvanter.Visible == true)
            {
                if (FrmKullaniciGiris.USER.YetkiDurumu == 2)
                {
                    this.tabPersonelBilgi.Hide();
                    this.tabHastaneBolum.Hide();
                    this.tabBilgiIslem.Hide();
                    TabControlEnvanter.TabPages.Remove(tabPersonelBilgi);
                    TabControlEnvanter.TabPages.Remove(tabHastaneBolum);
                    TabControlEnvanter.TabPages.Remove(tabBilgiIslem);
                }
                else if (FrmKullaniciGiris.USER.YetkiDurumu == 3)
                {
                    this.tabPersonelBilgi.Hide();
                    this.tabHastaneBolum.Hide();
                    this.tabTeknikServis.Hide();
                    TabControlEnvanter.TabPages.Remove(tabPersonelBilgi);
                    TabControlEnvanter.TabPages.Remove(tabHastaneBolum);
                    TabControlEnvanter.TabPages.Remove(tabTeknikServis);
                }
                else if (FrmKullaniciGiris.USER.YetkiDurumu == 4)
                {
                    this.tabTeknikServis.Hide();
                    this.tabHastaneBolum.Hide();
                    this.tabBilgiIslem.Hide();
                    TabControlEnvanter.TabPages.Remove(tabTeknikServis);
                    TabControlEnvanter.TabPages.Remove(tabHastaneBolum);
                    TabControlEnvanter.TabPages.Remove(tabBilgiIslem);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void EnvanterListele()
        {
            DataGridEnvanter.DataSource = db.EnvanterListele();
        }
        public void TeknikServisListele()
        {
            DataGridTeknikServis.DataSource = db.TBLTeknikServis.ToList();
            DataGridTeknikServis.Columns[9].Visible = false;
        }
        public void BilgiIslemListele()
        {
            DataGridBilgiIslem.DataSource = db.TBLBilgiIslem.ToList();
        }
        private void btnEnvanterEkle_Click(object sender, EventArgs e)
        {
            TBLEnvanter envanter = new TBLEnvanter();
            envanter.UrunIsmi = tbEnvanterUrunIsim.Text;
            envanter.StokAdet = Convert.ToInt32(tbEnvanterAdet.Text);
            envanter.MalzemeDurum = cbEnvanterMalzemeDurum.SelectedItem.ToString();
            envanter.GirisTarihi = dtpEnvanterTarih.Value;
            envanter.BagliPersonel = tbEnvanterSorumluPersonel.Text;
            envanter.BagliBolum = tbEnvanterSorumluBolum.Text;
            db.TBLEnvanter.Add(envanter);
            db.SaveChanges();
            MessageBox.Show("Eklendi!");

            EnvanterListele();
        }

        private void btnEnvanterTemizle_Click(object sender, EventArgs e)
        {
            tbEnvanterUrunIsim.Text = "";
            tbEnvanterAdet.Text = "";
            tbEnvanterSorumluPersonel.Text = "";
            tbEnvanterSorumluBolum.Text = "";
        }

        private void btnArizaGonder_Click(object sender, EventArgs e)
        {
            if (cbArizaBirim.SelectedItem.ToString() == "Teknik Servis")
            {
                TBLTeknikServis teknikServis = new TBLTeknikServis();
                teknikServis.UrunIsmi = tbArizaUrunİsim.Text;
                teknikServis.Adet = Convert.ToInt32(tbArizaAdet.Text);
                teknikServis.GelisTarihi = dtpArizaTarih.Value;
                teknikServis.GelisSebebi = tbArizaGonderimSebebi.Text;
                db.TBLTeknikServis.Add(teknikServis);
                db.SaveChanges();
                TeknikServisListele();
            }
            else if (cbArizaBirim.SelectedItem.ToString() == "Bilgi İşlem")
            {
                TBLBilgiIslem bilgiIslem = new TBLBilgiIslem();
                bilgiIslem.UrunIsmi = tbArizaUrunİsim.Text;
                bilgiIslem.Adet = Convert.ToInt32(tbArizaAdet.Text);
                bilgiIslem.GirisTarihi = dtpArizaTarih.Value;
                bilgiIslem.GelisSebebi = tbArizaGonderimSebebi.Text;
                db.TBLBilgiIslem.Add(bilgiIslem);
                db.SaveChanges();
                BilgiIslemListele();
            }
        }

        private void DataGridEnvanter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbArizaUrunİsim.Text = DataGridEnvanter.CurrentRow.Cells[2].Value.ToString();
            tbArizaAdet.Text = DataGridEnvanter.CurrentRow.Cells[3].Value.ToString();
            if (e.ColumnIndex == 0)
            {
                int id = Convert.ToInt32(DataGridEnvanter.CurrentRow.Cells[1].Value.ToString());
                DeleteMusteri(id);
                EnvanterListele();
                tbArizaUrunİsim.Text = "";
                tbArizaAdet.Text = "";
            }
        }

        private void btnArizaTemizle_Click(object sender, EventArgs e)
        {
            tbArizaUrunİsim.Text = "";
            tbArizaAdet.Text = "";
        }
        public void DeleteMusteri(int id)
        {
            
            var sorgu = db.TBLEnvanter.Find(id);
            db.TBLEnvanter.Remove(sorgu);
            db.SaveChanges();
            MessageBox.Show(id+"nolu envanter silindi. ");
        }

       
    }
}
