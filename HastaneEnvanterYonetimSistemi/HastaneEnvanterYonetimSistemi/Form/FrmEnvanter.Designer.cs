
namespace HastaneEnvanterYonetimSistemi
{
    partial class FrmEnvanter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabControlEnvanter = new System.Windows.Forms.TabControl();
            this.tabEnvanter = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataGridEnvanter = new System.Windows.Forms.DataGridView();
            this.Sil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEnvanterMalzemeDurum = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpEnvanterTarih = new System.Windows.Forms.DateTimePicker();
            this.btnEnvanterTemizle = new System.Windows.Forms.Button();
            this.btnEnvanterEkle = new System.Windows.Forms.Button();
            this.tbEnvanterAdet = new System.Windows.Forms.TextBox();
            this.tbEnvanterSorumluPersonel = new System.Windows.Forms.TextBox();
            this.tbEnvanterSorumluBolum = new System.Windows.Forms.TextBox();
            this.tbEnvanterUrunIsim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpArizaTarih = new System.Windows.Forms.DateTimePicker();
            this.btnArizaGonder = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnArizaTemizle = new System.Windows.Forms.Button();
            this.cbArizaBirim = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbArizaGonderimSebebi = new System.Windows.Forms.TextBox();
            this.tbArizaUrunİsim = new System.Windows.Forms.TextBox();
            this.tbArizaAdet = new System.Windows.Forms.TextBox();
            this.tabTeknikServis = new System.Windows.Forms.TabPage();
            this.tabBilgiIslem = new System.Windows.Forms.TabPage();
            this.tabHastaneBolum = new System.Windows.Forms.TabPage();
            this.tabPersonelBilgi = new System.Windows.Forms.TabPage();
            this.tabAyarlar = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.TabControlEnvanter.SuspendLayout();
            this.tabEnvanter.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEnvanter)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabAyarlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlEnvanter
            // 
            this.TabControlEnvanter.Controls.Add(this.tabEnvanter);
            this.TabControlEnvanter.Controls.Add(this.tabTeknikServis);
            this.TabControlEnvanter.Controls.Add(this.tabBilgiIslem);
            this.TabControlEnvanter.Controls.Add(this.tabHastaneBolum);
            this.TabControlEnvanter.Controls.Add(this.tabPersonelBilgi);
            this.TabControlEnvanter.Controls.Add(this.tabAyarlar);
            this.TabControlEnvanter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlEnvanter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TabControlEnvanter.Location = new System.Drawing.Point(0, 0);
            this.TabControlEnvanter.Name = "TabControlEnvanter";
            this.TabControlEnvanter.SelectedIndex = 0;
            this.TabControlEnvanter.Size = new System.Drawing.Size(1437, 784);
            this.TabControlEnvanter.TabIndex = 1;
            this.TabControlEnvanter.Visible = false;
            // 
            // tabEnvanter
            // 
            this.tabEnvanter.BackColor = System.Drawing.Color.DimGray;
            this.tabEnvanter.Controls.Add(this.panel2);
            this.tabEnvanter.Controls.Add(this.panel3);
            this.tabEnvanter.Controls.Add(this.panel1);
            this.tabEnvanter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabEnvanter.Location = new System.Drawing.Point(4, 29);
            this.tabEnvanter.Name = "tabEnvanter";
            this.tabEnvanter.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnvanter.Size = new System.Drawing.Size(1429, 751);
            this.tabEnvanter.TabIndex = 0;
            this.tabEnvanter.Text = "Envanter Bilgi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DataGridEnvanter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(395, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 645);
            this.panel2.TabIndex = 3;
            // 
            // DataGridEnvanter
            // 
            this.DataGridEnvanter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridEnvanter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridEnvanter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEnvanter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sil});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridEnvanter.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridEnvanter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridEnvanter.Location = new System.Drawing.Point(0, 0);
            this.DataGridEnvanter.Name = "DataGridEnvanter";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridEnvanter.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridEnvanter.RowHeadersWidth = 51;
            this.DataGridEnvanter.RowTemplate.Height = 24;
            this.DataGridEnvanter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridEnvanter.Size = new System.Drawing.Size(1031, 645);
            this.DataGridEnvanter.TabIndex = 0;
            this.DataGridEnvanter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEnvanter_CellClick);
            // 
            // Sil
            // 
            this.Sil.HeaderText = "";
            this.Sil.MinimumWidth = 6;
            this.Sil.Name = "Sil";
            this.Sil.Text = "Sil";
            this.Sil.UseColumnTextForButtonValue = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(395, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1031, 100);
            this.panel3.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1031, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sıralama";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(491, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Sıralama Ölçütü";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(650, 44);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(148, 28);
            this.comboBox2.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(54, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Sıralama Ölçütü";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(233, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 745);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.cbEnvanterMalzemeDurum);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dtpEnvanterTarih);
            this.groupBox1.Controls.Add(this.btnEnvanterTemizle);
            this.groupBox1.Controls.Add(this.btnEnvanterEkle);
            this.groupBox1.Controls.Add(this.tbEnvanterAdet);
            this.groupBox1.Controls.Add(this.tbEnvanterSorumluPersonel);
            this.groupBox1.Controls.Add(this.tbEnvanterSorumluBolum);
            this.groupBox1.Controls.Add(this.tbEnvanterUrunIsim);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 537);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Envanter Giriş";
            // 
            // cbEnvanterMalzemeDurum
            // 
            this.cbEnvanterMalzemeDurum.FormattingEnabled = true;
            this.cbEnvanterMalzemeDurum.Items.AddRange(new object[] {
            "Sarf",
            "Demirbaş"});
            this.cbEnvanterMalzemeDurum.Location = new System.Drawing.Point(184, 246);
            this.cbEnvanterMalzemeDurum.Name = "cbEnvanterMalzemeDurum";
            this.cbEnvanterMalzemeDurum.Size = new System.Drawing.Size(192, 28);
            this.cbEnvanterMalzemeDurum.TabIndex = 1;
            this.cbEnvanterMalzemeDurum.Text = "Sarf";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 250);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Malzeme Durumu";
            // 
            // dtpEnvanterTarih
            // 
            this.dtpEnvanterTarih.Location = new System.Drawing.Point(184, 190);
            this.dtpEnvanterTarih.Name = "dtpEnvanterTarih";
            this.dtpEnvanterTarih.Size = new System.Drawing.Size(193, 27);
            this.dtpEnvanterTarih.TabIndex = 27;
            // 
            // btnEnvanterTemizle
            // 
            this.btnEnvanterTemizle.BackColor = System.Drawing.Color.Gray;
            this.btnEnvanterTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnvanterTemizle.Location = new System.Drawing.Point(11, 419);
            this.btnEnvanterTemizle.Name = "btnEnvanterTemizle";
            this.btnEnvanterTemizle.Size = new System.Drawing.Size(143, 44);
            this.btnEnvanterTemizle.TabIndex = 12;
            this.btnEnvanterTemizle.Text = "Temizle";
            this.btnEnvanterTemizle.UseVisualStyleBackColor = false;
            this.btnEnvanterTemizle.Click += new System.EventHandler(this.btnEnvanterTemizle_Click);
            // 
            // btnEnvanterEkle
            // 
            this.btnEnvanterEkle.BackColor = System.Drawing.Color.Gray;
            this.btnEnvanterEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnvanterEkle.Location = new System.Drawing.Point(184, 419);
            this.btnEnvanterEkle.Name = "btnEnvanterEkle";
            this.btnEnvanterEkle.Size = new System.Drawing.Size(192, 44);
            this.btnEnvanterEkle.TabIndex = 11;
            this.btnEnvanterEkle.Text = "Ekle";
            this.btnEnvanterEkle.UseVisualStyleBackColor = false;
            this.btnEnvanterEkle.Click += new System.EventHandler(this.btnEnvanterEkle_Click);
            // 
            // tbEnvanterAdet
            // 
            this.tbEnvanterAdet.BackColor = System.Drawing.Color.DimGray;
            this.tbEnvanterAdet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEnvanterAdet.Location = new System.Drawing.Point(184, 134);
            this.tbEnvanterAdet.Name = "tbEnvanterAdet";
            this.tbEnvanterAdet.Size = new System.Drawing.Size(192, 27);
            this.tbEnvanterAdet.TabIndex = 9;
            // 
            // tbEnvanterSorumluPersonel
            // 
            this.tbEnvanterSorumluPersonel.BackColor = System.Drawing.Color.DimGray;
            this.tbEnvanterSorumluPersonel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEnvanterSorumluPersonel.Location = new System.Drawing.Point(184, 302);
            this.tbEnvanterSorumluPersonel.Name = "tbEnvanterSorumluPersonel";
            this.tbEnvanterSorumluPersonel.Size = new System.Drawing.Size(192, 27);
            this.tbEnvanterSorumluPersonel.TabIndex = 8;
            // 
            // tbEnvanterSorumluBolum
            // 
            this.tbEnvanterSorumluBolum.BackColor = System.Drawing.Color.DimGray;
            this.tbEnvanterSorumluBolum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEnvanterSorumluBolum.Location = new System.Drawing.Point(184, 358);
            this.tbEnvanterSorumluBolum.Name = "tbEnvanterSorumluBolum";
            this.tbEnvanterSorumluBolum.Size = new System.Drawing.Size(192, 27);
            this.tbEnvanterSorumluBolum.TabIndex = 7;
            // 
            // tbEnvanterUrunIsim
            // 
            this.tbEnvanterUrunIsim.BackColor = System.Drawing.Color.DimGray;
            this.tbEnvanterUrunIsim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEnvanterUrunIsim.Location = new System.Drawing.Point(184, 78);
            this.tbEnvanterUrunIsim.Name = "tbEnvanterUrunIsim";
            this.tbEnvanterUrunIsim.Size = new System.Drawing.Size(192, 27);
            this.tbEnvanterUrunIsim.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sorumlu Bölüm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sorumlu Personel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün İsmi:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Controls.Add(this.dtpArizaTarih);
            this.groupBox2.Controls.Add(this.btnArizaGonder);
            this.groupBox2.Controls.Add(this.btnArizaTemizle);
            this.groupBox2.Controls.Add(this.cbArizaBirim);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbArizaUrunİsim);
            this.groupBox2.Controls.Add(this.tbArizaAdet);
            this.groupBox2.Controls.Add(this.tbArizaGonderimSebebi);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(0, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 483);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama ve Listeleme";
            // 
            // dtpArizaTarih
            // 
            this.dtpArizaTarih.Location = new System.Drawing.Point(184, 205);
            this.dtpArizaTarih.Name = "dtpArizaTarih";
            this.dtpArizaTarih.Size = new System.Drawing.Size(193, 27);
            this.dtpArizaTarih.TabIndex = 26;
            // 
            // btnArizaGonder
            // 
            this.btnArizaGonder.BackColor = System.Drawing.Color.Gray;
            this.btnArizaGonder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArizaGonder.Location = new System.Drawing.Point(184, 382);
            this.btnArizaGonder.Name = "btnArizaGonder";
            this.btnArizaGonder.Size = new System.Drawing.Size(192, 44);
            this.btnArizaGonder.TabIndex = 23;
            this.btnArizaGonder.Text = "Arıza Gönder";
            this.btnArizaGonder.UseVisualStyleBackColor = false;
            this.btnArizaGonder.Click += new System.EventHandler(this.btnArizaGonder_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Adet:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Ürün İsmi:";
            // 
            // btnArizaTemizle
            // 
            this.btnArizaTemizle.BackColor = System.Drawing.Color.Gray;
            this.btnArizaTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArizaTemizle.Location = new System.Drawing.Point(11, 382);
            this.btnArizaTemizle.Name = "btnArizaTemizle";
            this.btnArizaTemizle.Size = new System.Drawing.Size(143, 44);
            this.btnArizaTemizle.TabIndex = 24;
            this.btnArizaTemizle.Text = "Temizle";
            this.btnArizaTemizle.UseVisualStyleBackColor = false;
            this.btnArizaTemizle.Click += new System.EventHandler(this.btnArizaTemizle_Click);
            // 
            // cbArizaBirim
            // 
            this.cbArizaBirim.BackColor = System.Drawing.SystemColors.Window;
            this.cbArizaBirim.FormattingEnabled = true;
            this.cbArizaBirim.Items.AddRange(new object[] {
            "Teknik Servis",
            "Bilgi İşlem"});
            this.cbArizaBirim.Location = new System.Drawing.Point(184, 327);
            this.cbArizaBirim.Name = "cbArizaBirim";
            this.cbArizaBirim.Size = new System.Drawing.Size(192, 28);
            this.cbArizaBirim.TabIndex = 1;
            this.cbArizaBirim.Text = "Arıza Birimi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Gönderim Sebebi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tarih:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Gönderilecek Birim:";
            // 
            // tbArizaGonderimSebebi
            // 
            this.tbArizaGonderimSebebi.BackColor = System.Drawing.Color.DimGray;
            this.tbArizaGonderimSebebi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbArizaGonderimSebebi.Location = new System.Drawing.Point(184, 264);
            this.tbArizaGonderimSebebi.Name = "tbArizaGonderimSebebi";
            this.tbArizaGonderimSebebi.Size = new System.Drawing.Size(192, 27);
            this.tbArizaGonderimSebebi.TabIndex = 20;
            // 
            // tbArizaUrunİsim
            // 
            this.tbArizaUrunİsim.BackColor = System.Drawing.Color.DimGray;
            this.tbArizaUrunİsim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbArizaUrunİsim.Location = new System.Drawing.Point(184, 87);
            this.tbArizaUrunİsim.Name = "tbArizaUrunİsim";
            this.tbArizaUrunİsim.Size = new System.Drawing.Size(192, 27);
            this.tbArizaUrunİsim.TabIndex = 18;
            // 
            // tbArizaAdet
            // 
            this.tbArizaAdet.BackColor = System.Drawing.Color.DimGray;
            this.tbArizaAdet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbArizaAdet.Location = new System.Drawing.Point(184, 146);
            this.tbArizaAdet.Name = "tbArizaAdet";
            this.tbArizaAdet.Size = new System.Drawing.Size(192, 27);
            this.tbArizaAdet.TabIndex = 21;
            // 
            // tabTeknikServis
            // 
            this.tabTeknikServis.BackColor = System.Drawing.Color.Gray;
            this.tabTeknikServis.Location = new System.Drawing.Point(4, 29);
            this.tabTeknikServis.Name = "tabTeknikServis";
            this.tabTeknikServis.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeknikServis.Size = new System.Drawing.Size(1429, 751);
            this.tabTeknikServis.TabIndex = 1;
            this.tabTeknikServis.Text = "Teknik Servis";
            // 
            // tabBilgiIslem
            // 
            this.tabBilgiIslem.BackColor = System.Drawing.Color.Gray;
            this.tabBilgiIslem.Location = new System.Drawing.Point(4, 29);
            this.tabBilgiIslem.Name = "tabBilgiIslem";
            this.tabBilgiIslem.Padding = new System.Windows.Forms.Padding(3);
            this.tabBilgiIslem.Size = new System.Drawing.Size(1429, 751);
            this.tabBilgiIslem.TabIndex = 2;
            this.tabBilgiIslem.Text = "Bilgi İşlem";
            // 
            // tabHastaneBolum
            // 
            this.tabHastaneBolum.BackColor = System.Drawing.Color.Gray;
            this.tabHastaneBolum.Location = new System.Drawing.Point(4, 29);
            this.tabHastaneBolum.Name = "tabHastaneBolum";
            this.tabHastaneBolum.Padding = new System.Windows.Forms.Padding(3);
            this.tabHastaneBolum.Size = new System.Drawing.Size(1429, 751);
            this.tabHastaneBolum.TabIndex = 3;
            this.tabHastaneBolum.Text = "Hastane Bölüm";
            // 
            // tabPersonelBilgi
            // 
            this.tabPersonelBilgi.BackColor = System.Drawing.Color.Gray;
            this.tabPersonelBilgi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPersonelBilgi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPersonelBilgi.Location = new System.Drawing.Point(4, 29);
            this.tabPersonelBilgi.Name = "tabPersonelBilgi";
            this.tabPersonelBilgi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonelBilgi.Size = new System.Drawing.Size(1429, 751);
            this.tabPersonelBilgi.TabIndex = 4;
            this.tabPersonelBilgi.Text = "Personel Bilgi";
            // 
            // tabAyarlar
            // 
            this.tabAyarlar.BackColor = System.Drawing.Color.Gray;
            this.tabAyarlar.Controls.Add(this.button3);
            this.tabAyarlar.Location = new System.Drawing.Point(4, 29);
            this.tabAyarlar.Name = "tabAyarlar";
            this.tabAyarlar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAyarlar.Size = new System.Drawing.Size(1429, 751);
            this.tabAyarlar.TabIndex = 5;
            this.tabAyarlar.Text = "Ayarlar";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(879, 301);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmEnvanter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 784);
            this.Controls.Add(this.TabControlEnvanter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmEnvanter";
            this.Text = "EnvanterYönetimSistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEnvanter_Load);
            this.TabControlEnvanter.ResumeLayout(false);
            this.tabEnvanter.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEnvanter)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabAyarlar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabEnvanter;
        private System.Windows.Forms.TabPage tabTeknikServis;
        private System.Windows.Forms.TabPage tabBilgiIslem;
        private System.Windows.Forms.TabPage tabHastaneBolum;
        private System.Windows.Forms.TabPage tabPersonelBilgi;
        public System.Windows.Forms.TabControl TabControlEnvanter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbEnvanterAdet;
        private System.Windows.Forms.TextBox tbEnvanterSorumluPersonel;
        private System.Windows.Forms.TextBox tbEnvanterSorumluBolum;
        private System.Windows.Forms.TextBox tbEnvanterUrunIsim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabAyarlar;
        private System.Windows.Forms.Button btnEnvanterTemizle;
        private System.Windows.Forms.Button btnEnvanterEkle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnArizaTemizle;
        private System.Windows.Forms.Button btnArizaGonder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbArizaAdet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbArizaGonderimSebebi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbArizaUrunİsim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DataGridEnvanter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewButtonColumn Sil;
        private System.Windows.Forms.ComboBox cbArizaBirim;
        private System.Windows.Forms.DateTimePicker dtpEnvanterTarih;
        private System.Windows.Forms.DateTimePicker dtpArizaTarih;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbEnvanterMalzemeDurum;
        private System.Windows.Forms.Label label14;
    }
}

