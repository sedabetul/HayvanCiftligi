namespace HayvanCiftligiDeneme2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KeciYem = new System.Windows.Forms.Label();
            this.InekYem = new System.Windows.Forms.Label();
            this.OrdekYem = new System.Windows.Forms.Label();
            this.TavukYem = new System.Windows.Forms.Label();
            this.lblSutKeci = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.canKeci = new System.Windows.Forms.ProgressBar();
            this.lblKeciCan = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblSutInek = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.canInek = new System.Windows.Forms.ProgressBar();
            this.lblInekCan = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblOrdekYumurta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.canOrdek = new System.Windows.Forms.ProgressBar();
            this.lblOrdekCan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTavukYumurta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.canTavuk = new System.Windows.Forms.ProgressBar();
            this.lblTavukCan = new System.Windows.Forms.Label();
            this.lblTavuk = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnzaman = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblkasa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKeciBesle = new System.Windows.Forms.Button();
            this.btnInekBesle = new System.Windows.Forms.Button();
            this.btnOrdekBesle = new System.Windows.Forms.Button();
            this.btnTavukBesle = new System.Windows.Forms.Button();
            this.btnKeciSat = new System.Windows.Forms.Button();
            this.btnInekSat = new System.Windows.Forms.Button();
            this.btnOrdekSat = new System.Windows.Forms.Button();
            this.btnTavukSat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KeciYem);
            this.groupBox1.Controls.Add(this.InekYem);
            this.groupBox1.Controls.Add(this.OrdekYem);
            this.groupBox1.Controls.Add(this.TavukYem);
            this.groupBox1.Controls.Add(this.lblSutKeci);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.canKeci);
            this.groupBox1.Controls.Add(this.lblKeciCan);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.lblSutInek);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.canInek);
            this.groupBox1.Controls.Add(this.lblInekCan);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.lblOrdekYumurta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.canOrdek);
            this.groupBox1.Controls.Add(this.lblOrdekCan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.lblTavukYumurta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.canTavuk);
            this.groupBox1.Controls.Add(this.lblTavukCan);
            this.groupBox1.Controls.Add(this.lblTavuk);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1464, 389);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hayvanlar";
            // 
            // KeciYem
            // 
            this.KeciYem.AutoSize = true;
            this.KeciYem.Location = new System.Drawing.Point(1142, 341);
            this.KeciYem.Name = "KeciYem";
            this.KeciYem.Size = new System.Drawing.Size(42, 20);
            this.KeciYem.TabIndex = 27;
            this.KeciYem.Text = "Yem";
            // 
            // InekYem
            // 
            this.InekYem.AutoSize = true;
            this.InekYem.Location = new System.Drawing.Point(797, 341);
            this.InekYem.Name = "InekYem";
            this.InekYem.Size = new System.Drawing.Size(42, 20);
            this.InekYem.TabIndex = 26;
            this.InekYem.Text = "Yem";
            // 
            // OrdekYem
            // 
            this.OrdekYem.AutoSize = true;
            this.OrdekYem.Location = new System.Drawing.Point(469, 341);
            this.OrdekYem.Name = "OrdekYem";
            this.OrdekYem.Size = new System.Drawing.Size(42, 20);
            this.OrdekYem.TabIndex = 25;
            this.OrdekYem.Text = "Yem";
            // 
            // TavukYem
            // 
            this.TavukYem.AutoSize = true;
            this.TavukYem.Location = new System.Drawing.Point(122, 341);
            this.TavukYem.Name = "TavukYem";
            this.TavukYem.Size = new System.Drawing.Size(42, 20);
            this.TavukYem.TabIndex = 24;
            this.TavukYem.Text = "Yem";
            // 
            // lblSutKeci
            // 
            this.lblSutKeci.AutoSize = true;
            this.lblSutKeci.Location = new System.Drawing.Point(1232, 297);
            this.lblSutKeci.Name = "lblSutKeci";
            this.lblSutKeci.Size = new System.Drawing.Size(69, 20);
            this.lblSutKeci.TabIndex = 23;
            this.lblSutKeci.Text = "Süt Litre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1048, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Süt Litre:";
            // 
            // canKeci
            // 
            this.canKeci.BackColor = System.Drawing.Color.ForestGreen;
            this.canKeci.Location = new System.Drawing.Point(1102, 253);
            this.canKeci.Name = "canKeci";
            this.canKeci.Size = new System.Drawing.Size(199, 23);
            this.canKeci.TabIndex = 21;
            // 
            // lblKeciCan
            // 
            this.lblKeciCan.AutoSize = true;
            this.lblKeciCan.Location = new System.Drawing.Point(1048, 256);
            this.lblKeciCan.Name = "lblKeciCan";
            this.lblKeciCan.Size = new System.Drawing.Size(38, 20);
            this.lblKeciCan.TabIndex = 20;
            this.lblKeciCan.Text = "Can";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1142, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Keçi";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1039, 35);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(262, 168);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // lblSutInek
            // 
            this.lblSutInek.AutoSize = true;
            this.lblSutInek.Location = new System.Drawing.Point(887, 297);
            this.lblSutInek.Name = "lblSutInek";
            this.lblSutInek.Size = new System.Drawing.Size(69, 20);
            this.lblSutInek.TabIndex = 17;
            this.lblSutInek.Text = "Süt Litre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(703, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Süt Litre:";
            // 
            // canInek
            // 
            this.canInek.BackColor = System.Drawing.Color.ForestGreen;
            this.canInek.Location = new System.Drawing.Point(757, 253);
            this.canInek.Name = "canInek";
            this.canInek.Size = new System.Drawing.Size(199, 23);
            this.canInek.TabIndex = 15;
            // 
            // lblInekCan
            // 
            this.lblInekCan.AutoSize = true;
            this.lblInekCan.Location = new System.Drawing.Point(703, 256);
            this.lblInekCan.Name = "lblInekCan";
            this.lblInekCan.Size = new System.Drawing.Size(38, 20);
            this.lblInekCan.TabIndex = 14;
            this.lblInekCan.Text = "Can";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(797, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "İnek";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(694, 35);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(262, 168);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // lblOrdekYumurta
            // 
            this.lblOrdekYumurta.AutoSize = true;
            this.lblOrdekYumurta.Location = new System.Drawing.Point(513, 297);
            this.lblOrdekYumurta.Name = "lblOrdekYumurta";
            this.lblOrdekYumurta.Size = new System.Drawing.Size(115, 20);
            this.lblOrdekYumurta.TabIndex = 11;
            this.lblOrdekYumurta.Text = "Yumurta Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yumurta Sayısı:";
            // 
            // canOrdek
            // 
            this.canOrdek.BackColor = System.Drawing.Color.ForestGreen;
            this.canOrdek.Location = new System.Drawing.Point(429, 253);
            this.canOrdek.Name = "canOrdek";
            this.canOrdek.Size = new System.Drawing.Size(199, 23);
            this.canOrdek.TabIndex = 9;
            // 
            // lblOrdekCan
            // 
            this.lblOrdekCan.AutoSize = true;
            this.lblOrdekCan.Location = new System.Drawing.Point(375, 256);
            this.lblOrdekCan.Name = "lblOrdekCan";
            this.lblOrdekCan.Size = new System.Drawing.Size(38, 20);
            this.lblOrdekCan.TabIndex = 8;
            this.lblOrdekCan.Text = "Can";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ördek";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(366, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(262, 168);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // lblTavukYumurta
            // 
            this.lblTavukYumurta.AutoSize = true;
            this.lblTavukYumurta.Location = new System.Drawing.Point(166, 297);
            this.lblTavukYumurta.Name = "lblTavukYumurta";
            this.lblTavukYumurta.Size = new System.Drawing.Size(115, 20);
            this.lblTavukYumurta.TabIndex = 5;
            this.lblTavukYumurta.Text = "Yumurta Sayısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yumurta Sayısı:";
            // 
            // canTavuk
            // 
            this.canTavuk.BackColor = System.Drawing.Color.ForestGreen;
            this.canTavuk.Location = new System.Drawing.Point(82, 253);
            this.canTavuk.Name = "canTavuk";
            this.canTavuk.Size = new System.Drawing.Size(199, 23);
            this.canTavuk.TabIndex = 3;
            // 
            // lblTavukCan
            // 
            this.lblTavukCan.AutoSize = true;
            this.lblTavukCan.Location = new System.Drawing.Point(28, 256);
            this.lblTavukCan.Name = "lblTavukCan";
            this.lblTavukCan.Size = new System.Drawing.Size(38, 20);
            this.lblTavukCan.TabIndex = 2;
            this.lblTavukCan.Text = "Can";
            // 
            // lblTavuk
            // 
            this.lblTavuk.AutoSize = true;
            this.lblTavuk.Location = new System.Drawing.Point(122, 215);
            this.lblTavuk.Name = "lblTavuk";
            this.lblTavuk.Size = new System.Drawing.Size(51, 20);
            this.lblTavuk.TabIndex = 1;
            this.lblTavuk.Text = "Tavuk";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnzaman);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblkasa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnKeciBesle);
            this.groupBox2.Controls.Add(this.btnInekBesle);
            this.groupBox2.Controls.Add(this.btnOrdekBesle);
            this.groupBox2.Controls.Add(this.btnTavukBesle);
            this.groupBox2.Controls.Add(this.btnKeciSat);
            this.groupBox2.Controls.Add(this.btnInekSat);
            this.groupBox2.Controls.Add(this.btnOrdekSat);
            this.groupBox2.Controls.Add(this.btnTavukSat);
            this.groupBox2.Location = new System.Drawing.Point(13, 391);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1464, 289);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btnzaman
            // 
            this.btnzaman.Location = new System.Drawing.Point(1146, 147);
            this.btnzaman.Name = "btnzaman";
            this.btnzaman.Size = new System.Drawing.Size(75, 35);
            this.btnzaman.TabIndex = 12;
            this.btnzaman.Text = "süre";
            this.btnzaman.UseVisualStyleBackColor = true;
            this.btnzaman.Click += new System.EventHandler(this.btnzaman_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(993, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Süre:";
            // 
            // lblkasa
            // 
            this.lblkasa.AutoSize = true;
            this.lblkasa.Location = new System.Drawing.Point(1142, 108);
            this.lblkasa.Name = "lblkasa";
            this.lblkasa.Size = new System.Drawing.Size(106, 20);
            this.lblkasa.TabIndex = 10;
            this.lblkasa.Text = "Kasa Durumu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(898, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hesap Bakiyeniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(1032, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "KASA";
            // 
            // btnKeciBesle
            // 
            this.btnKeciBesle.Location = new System.Drawing.Point(429, 168);
            this.btnKeciBesle.Name = "btnKeciBesle";
            this.btnKeciBesle.Size = new System.Drawing.Size(155, 41);
            this.btnKeciBesle.TabIndex = 7;
            this.btnKeciBesle.Text = "Keçi Besle";
            this.btnKeciBesle.UseVisualStyleBackColor = true;
            this.btnKeciBesle.Click += new System.EventHandler(this.btnKeciBesle_Click);
            // 
            // btnInekBesle
            // 
            this.btnInekBesle.Location = new System.Drawing.Point(429, 229);
            this.btnInekBesle.Name = "btnInekBesle";
            this.btnInekBesle.Size = new System.Drawing.Size(155, 41);
            this.btnInekBesle.TabIndex = 6;
            this.btnInekBesle.Text = "İnek Besle";
            this.btnInekBesle.UseVisualStyleBackColor = true;
            this.btnInekBesle.Click += new System.EventHandler(this.btnInekBesle_Click);
            // 
            // btnOrdekBesle
            // 
            this.btnOrdekBesle.Location = new System.Drawing.Point(429, 108);
            this.btnOrdekBesle.Name = "btnOrdekBesle";
            this.btnOrdekBesle.Size = new System.Drawing.Size(155, 41);
            this.btnOrdekBesle.TabIndex = 5;
            this.btnOrdekBesle.Text = "Ördek Besle";
            this.btnOrdekBesle.UseVisualStyleBackColor = true;
            this.btnOrdekBesle.Click += new System.EventHandler(this.btnOrdekBesle_Click);
            // 
            // btnTavukBesle
            // 
            this.btnTavukBesle.Location = new System.Drawing.Point(429, 46);
            this.btnTavukBesle.Name = "btnTavukBesle";
            this.btnTavukBesle.Size = new System.Drawing.Size(155, 41);
            this.btnTavukBesle.TabIndex = 4;
            this.btnTavukBesle.Text = "Tavuk Besle";
            this.btnTavukBesle.UseVisualStyleBackColor = true;
            this.btnTavukBesle.Click += new System.EventHandler(this.btnTavukBesle_Click);
            // 
            // btnKeciSat
            // 
            this.btnKeciSat.Location = new System.Drawing.Point(19, 172);
            this.btnKeciSat.Name = "btnKeciSat";
            this.btnKeciSat.Size = new System.Drawing.Size(262, 31);
            this.btnKeciSat.TabIndex = 3;
            this.btnKeciSat.Text = "Keçi Sütü Sat";
            this.btnKeciSat.UseVisualStyleBackColor = true;
            this.btnKeciSat.Click += new System.EventHandler(this.btnKeciSat_Click);
            // 
            // btnInekSat
            // 
            this.btnInekSat.Location = new System.Drawing.Point(19, 234);
            this.btnInekSat.Name = "btnInekSat";
            this.btnInekSat.Size = new System.Drawing.Size(262, 31);
            this.btnInekSat.TabIndex = 2;
            this.btnInekSat.Text = "İnek Sütü Sat";
            this.btnInekSat.UseVisualStyleBackColor = true;
            this.btnInekSat.Click += new System.EventHandler(this.btnInekSat_Click);
            // 
            // btnOrdekSat
            // 
            this.btnOrdekSat.Location = new System.Drawing.Point(19, 113);
            this.btnOrdekSat.Name = "btnOrdekSat";
            this.btnOrdekSat.Size = new System.Drawing.Size(262, 31);
            this.btnOrdekSat.TabIndex = 1;
            this.btnOrdekSat.Text = "Ördek Yumurtası Sat";
            this.btnOrdekSat.UseVisualStyleBackColor = true;
            this.btnOrdekSat.Click += new System.EventHandler(this.btnOrdekSat_Click);
            // 
            // btnTavukSat
            // 
            this.btnTavukSat.Location = new System.Drawing.Point(19, 51);
            this.btnTavukSat.Name = "btnTavukSat";
            this.btnTavukSat.Size = new System.Drawing.Size(262, 31);
            this.btnTavukSat.TabIndex = 0;
            this.btnTavukSat.Text = "Tavuk Yumurtası Sat";
            this.btnTavukSat.UseVisualStyleBackColor = true;
            this.btnTavukSat.Click += new System.EventHandler(this.btnTavukSat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 692);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTavuk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTavukYumurta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar canTavuk;
        private System.Windows.Forms.Label lblTavukCan;
        private System.Windows.Forms.Label lblSutKeci;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar canKeci;
        private System.Windows.Forms.Label lblKeciCan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblSutInek;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar canInek;
        private System.Windows.Forms.Label lblInekCan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblOrdekYumurta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar canOrdek;
        private System.Windows.Forms.Label lblOrdekCan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKeciSat;
        private System.Windows.Forms.Button btnInekSat;
        private System.Windows.Forms.Button btnOrdekSat;
        private System.Windows.Forms.Button btnTavukSat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKeciBesle;
        private System.Windows.Forms.Button btnInekBesle;
        private System.Windows.Forms.Button btnOrdekBesle;
        private System.Windows.Forms.Button btnTavukBesle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblkasa;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnzaman;
        private System.Windows.Forms.Label KeciYem;
        private System.Windows.Forms.Label InekYem;
        private System.Windows.Forms.Label OrdekYem;
        private System.Windows.Forms.Label TavukYem;
    }
}

