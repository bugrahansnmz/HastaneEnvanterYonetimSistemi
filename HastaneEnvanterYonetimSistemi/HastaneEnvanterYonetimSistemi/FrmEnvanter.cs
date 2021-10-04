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

        private void FrmEnvanter_Load(object sender, EventArgs e)
        {
            EnvanterListele();
            FrmKullaniciGiris frm = new FrmKullaniciGiris();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void EnvanterListele()
        {
            DataGridEnvanter.DataSource = db.EnvanterListesi();
        }
    }
}
