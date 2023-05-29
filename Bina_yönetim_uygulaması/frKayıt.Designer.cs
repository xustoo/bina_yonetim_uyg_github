namespace Bina_yönetim_uygulaması
{
    partial class frKayıt
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
            lblAd = new Label();
            lblSoyad = new Label();
            lblDaireno = new Label();
            lblTel = new Label();
            lblBorç = new Label();
            txtAd = new TextBox();
            txtTel = new TextBox();
            txtDaireno = new TextBox();
            txtSoyad = new TextBox();
            txtBorç = new TextBox();
            btnKaydet = new Button();
            btnMenu = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnTemizle = new Button();
            btnVerilerigöster = new Button();
            listView1 = new ListView();
            columnid = new ColumnHeader();
            columnad = new ColumnHeader();
            columnsoyad = new ColumnHeader();
            columndaire = new ColumnHeader();
            columntelefon = new ColumnHeader();
            columnborc = new ColumnHeader();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAd.Location = new Point(27, 33);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(46, 28);
            lblAd.TabIndex = 0;
            lblAd.Text = "Adı:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSoyad.Location = new Point(27, 66);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(76, 28);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyadı:";
            // 
            // lblDaireno
            // 
            lblDaireno.AutoSize = true;
            lblDaireno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDaireno.Location = new Point(365, 34);
            lblDaireno.Name = "lblDaireno";
            lblDaireno.Size = new Size(94, 28);
            lblDaireno.TabIndex = 2;
            lblDaireno.Text = "Daire No:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTel.Location = new Point(365, 67);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(78, 28);
            lblTel.TabIndex = 3;
            lblTel.Text = "Telefon:";
            // 
            // lblBorç
            // 
            lblBorç.AutoSize = true;
            lblBorç.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBorç.Location = new Point(27, 99);
            lblBorç.Name = "lblBorç";
            lblBorç.Size = new Size(55, 28);
            lblBorç.TabIndex = 4;
            lblBorç.Text = "Borç:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(151, 33);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(185, 27);
            txtAd.TabIndex = 5;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(489, 67);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(185, 27);
            txtTel.TabIndex = 6;
            // 
            // txtDaireno
            // 
            txtDaireno.Location = new Point(489, 34);
            txtDaireno.Name = "txtDaireno";
            txtDaireno.Size = new Size(185, 27);
            txtDaireno.TabIndex = 7;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(151, 66);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(185, 27);
            txtSoyad.TabIndex = 8;
            // 
            // txtBorç
            // 
            txtBorç.Location = new Point(151, 99);
            txtBorç.Name = "txtBorç";
            txtBorç.Size = new Size(185, 27);
            txtBorç.TabIndex = 9;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(128, 128, 255);
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydet.Location = new Point(798, 12);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(132, 63);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(192, 255, 255);
            btnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.Location = new Point(798, 378);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(132, 63);
            btnMenu.TabIndex = 11;
            btnMenu.Text = "MENÜ";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Red;
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSil.Location = new Point(798, 81);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(132, 63);
            btnSil.TabIndex = 12;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(255, 128, 255);
            btnGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(798, 150);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(132, 63);
            btnGuncelle.TabIndex = 13;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(128, 255, 128);
            btnTemizle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTemizle.Location = new Point(798, 219);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(132, 63);
            btnTemizle.TabIndex = 14;
            btnTemizle.Text = "TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnVerilerigöster
            // 
            btnVerilerigöster.BackColor = Color.RosyBrown;
            btnVerilerigöster.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerilerigöster.Location = new Point(798, 288);
            btnVerilerigöster.Name = "btnVerilerigöster";
            btnVerilerigöster.Size = new Size(132, 84);
            btnVerilerigöster.TabIndex = 15;
            btnVerilerigöster.Text = "VERİLERİ GÖSTER";
            btnVerilerigöster.UseVisualStyleBackColor = false;
            btnVerilerigöster.Click += btnVerilerigöster_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnid, columnad, columnsoyad, columndaire, columntelefon, columnborc });
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.ImeMode = ImeMode.NoControl;
            listView1.Location = new Point(64, 174);
            listView1.MinimumSize = new Size(200, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(655, 302);
            listView1.TabIndex = 16;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // columnid
            // 
            columnid.Text = "id";
            columnid.Width = 50;
            // 
            // columnad
            // 
            columnad.Text = "Ad";
            columnad.Width = 120;
            // 
            // columnsoyad
            // 
            columnsoyad.Text = "Soyad";
            columnsoyad.Width = 120;
            // 
            // columndaire
            // 
            columndaire.Text = "Daire";
            columndaire.Width = 120;
            // 
            // columntelefon
            // 
            columntelefon.Text = "Telefon";
            columntelefon.Width = 120;
            // 
            // columnborc
            // 
            columnborc.Text = "Borç";
            columnborc.Width = 120;
            // 
            // frKayıt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(974, 503);
            Controls.Add(listView1);
            Controls.Add(btnVerilerigöster);
            Controls.Add(btnTemizle);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnMenu);
            Controls.Add(btnKaydet);
            Controls.Add(txtBorç);
            Controls.Add(txtSoyad);
            Controls.Add(txtDaireno);
            Controls.Add(txtTel);
            Controls.Add(txtAd);
            Controls.Add(lblBorç);
            Controls.Add(lblTel);
            Controls.Add(lblDaireno);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "frKayıt";
            Text = "frKayıt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblDaireno;
        private Label lblTel;
        private Label lblBorç;
        private TextBox txtAd;
        private TextBox txtTel;
        private TextBox txtDaireno;
        private TextBox txtSoyad;
        private TextBox txtBorç;
        private Button btnKaydet;
        private Button btnMenu;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnTemizle;
        private Button btnVerilerigöster;
        private ListView listView1;
        private ColumnHeader columnid;
        private ColumnHeader columnad;
        private ColumnHeader columnsoyad;
        private ColumnHeader columndaire;
        private ColumnHeader columntelefon;
        private ColumnHeader columnborc;
    }
}