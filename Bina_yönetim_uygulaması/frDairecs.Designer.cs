namespace Bina_yönetim_uygulaması
{
    partial class frDairecs
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
            lblKullanıcıbilgileri = new Label();
            txtBorç = new TextBox();
            txtSoyad = new TextBox();
            txtDaireno = new TextBox();
            txtTel = new TextBox();
            txtAd = new TextBox();
            lblBorç = new Label();
            lblTel = new Label();
            lblDaireno = new Label();
            lblSoyad = new Label();
            lblAd = new Label();
            btnAnasayfa = new Button();
            SuspendLayout();
            // 
            // lblKullanıcıbilgileri
            // 
            lblKullanıcıbilgileri.AutoSize = true;
            lblKullanıcıbilgileri.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblKullanıcıbilgileri.ForeColor = Color.Navy;
            lblKullanıcıbilgileri.Location = new Point(246, 43);
            lblKullanıcıbilgileri.Name = "lblKullanıcıbilgileri";
            lblKullanıcıbilgileri.Size = new Size(272, 32);
            lblKullanıcıbilgileri.TabIndex = 40;
            lblKullanıcıbilgileri.Text = "Seçilen Kullanıcı Bilgileri";
            // 
            // txtBorç
            // 
            txtBorç.Location = new Point(131, 311);
            txtBorç.Name = "txtBorç";
            txtBorç.Size = new Size(185, 27);
            txtBorç.TabIndex = 39;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(131, 225);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(185, 27);
            txtSoyad.TabIndex = 38;
            // 
            // txtDaireno
            // 
            txtDaireno.Location = new Point(488, 145);
            txtDaireno.Name = "txtDaireno";
            txtDaireno.Size = new Size(185, 27);
            txtDaireno.TabIndex = 37;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(488, 229);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(185, 27);
            txtTel.TabIndex = 36;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(131, 144);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(185, 27);
            txtAd.TabIndex = 35;
            // 
            // lblBorç
            // 
            lblBorç.AutoSize = true;
            lblBorç.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBorç.Location = new Point(7, 311);
            lblBorç.Name = "lblBorç";
            lblBorç.Size = new Size(55, 28);
            lblBorç.TabIndex = 34;
            lblBorç.Text = "Borç:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTel.Location = new Point(364, 229);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(78, 28);
            lblTel.TabIndex = 33;
            lblTel.Text = "Telefon:";
            // 
            // lblDaireno
            // 
            lblDaireno.AutoSize = true;
            lblDaireno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDaireno.Location = new Point(364, 145);
            lblDaireno.Name = "lblDaireno";
            lblDaireno.Size = new Size(94, 28);
            lblDaireno.TabIndex = 32;
            lblDaireno.Text = "Daire No:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSoyad.Location = new Point(7, 225);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(76, 28);
            lblSoyad.TabIndex = 31;
            lblSoyad.Text = "Soyadı:";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAd.Location = new Point(7, 144);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(46, 28);
            lblAd.TabIndex = 30;
            lblAd.Text = "Adı:";
            // 
            // btnAnasayfa
            // 
            btnAnasayfa.BackColor = Color.FromArgb(0, 192, 0);
            btnAnasayfa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnasayfa.Location = new Point(665, 340);
            btnAnasayfa.Name = "btnAnasayfa";
            btnAnasayfa.Size = new Size(123, 59);
            btnAnasayfa.TabIndex = 41;
            btnAnasayfa.Text = "ANA SAYFA";
            btnAnasayfa.UseVisualStyleBackColor = false;
            btnAnasayfa.Click += btnAnasayfa_Click;
            // 
            // frDairecs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAnasayfa);
            Controls.Add(lblKullanıcıbilgileri);
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
            Name = "frDairecs";
            Text = "frDairecs";
            Load += frDairecs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblKullanıcıbilgileri;
        private TextBox txtBorç;
        private TextBox txtSoyad;
        private TextBox txtDaireno;
        private TextBox txtTel;
        private TextBox txtAd;
        private Label lblBorç;
        private Label lblTel;
        private Label lblDaireno;
        private Label lblSoyad;
        private Label lblAd;
        private ListView listvBilgiler;
        private ColumnHeader columnid;
        private ColumnHeader columnad;
        private ColumnHeader columnsoyad;
        private ColumnHeader columndaire;
        private ColumnHeader columntelefon;
        private ColumnHeader columnborc;
        private Button btnAnasayfa;
    }
}