namespace Bina_yönetim_uygulaması
{
    partial class frAna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnYönetici = new Button();
            btnKullanıcı = new Button();
            lblKullanıcıadı = new Label();
            lblSifre = new Label();
            lblDaireno = new Label();
            txtKullanıcıadı = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            cbDaireno = new ComboBox();
            SuspendLayout();
            // 
            // btnYönetici
            // 
            btnYönetici.BackColor = SystemColors.Highlight;
            btnYönetici.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnYönetici.Location = new Point(132, 74);
            btnYönetici.Name = "btnYönetici";
            btnYönetici.Size = new Size(190, 70);
            btnYönetici.TabIndex = 0;
            btnYönetici.Text = "YÖNETİCİ";
            btnYönetici.UseVisualStyleBackColor = false;
            btnYönetici.Click += btnYönetici_Click;
            // 
            // btnKullanıcı
            // 
            btnKullanıcı.BackColor = Color.FromArgb(255, 128, 128);
            btnKullanıcı.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKullanıcı.Location = new Point(422, 74);
            btnKullanıcı.Name = "btnKullanıcı";
            btnKullanıcı.Size = new Size(190, 70);
            btnKullanıcı.TabIndex = 1;
            btnKullanıcı.Text = "KULLANICI";
            btnKullanıcı.UseVisualStyleBackColor = false;
            btnKullanıcı.Click += btnKullanıcı_Click;
            // 
            // lblKullanıcıadı
            // 
            lblKullanıcıadı.AutoSize = true;
            lblKullanıcıadı.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblKullanıcıadı.Location = new Point(83, 207);
            lblKullanıcıadı.Name = "lblKullanıcıadı";
            lblKullanıcıadı.Size = new Size(150, 32);
            lblKullanıcıadı.TabIndex = 2;
            lblKullanıcıadı.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblSifre.Location = new Point(83, 301);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(67, 32);
            lblSifre.TabIndex = 3;
            lblSifre.Text = "Şifre:";
            // 
            // lblDaireno
            // 
            lblDaireno.AutoSize = true;
            lblDaireno.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDaireno.Location = new Point(83, 255);
            lblDaireno.Name = "lblDaireno";
            lblDaireno.Size = new Size(114, 32);
            lblDaireno.TabIndex = 4;
            lblDaireno.Text = "Daire No:";
            // 
            // txtKullanıcıadı
            // 
            txtKullanıcıadı.Location = new Point(315, 212);
            txtKullanıcıadı.Name = "txtKullanıcıadı";
            txtKullanıcıadı.Size = new Size(175, 27);
            txtKullanıcıadı.TabIndex = 5;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(315, 301);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(175, 27);
            txtSifre.TabIndex = 6;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.LightGreen;
            btnGiris.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiris.Location = new Point(198, 357);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(190, 70);
            btnGiris.TabIndex = 8;
            btnGiris.Text = "GİRİŞ YAP";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // cbDaireno
            // 
            cbDaireno.FormattingEnabled = true;
            cbDaireno.Location = new Point(315, 255);
            cbDaireno.Name = "cbDaireno";
            cbDaireno.Size = new Size(175, 28);
            cbDaireno.TabIndex = 9;
            cbDaireno.SelectedIndexChanged += cbDaireno_SelectedIndexChanged;
            // 
            // frAna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(cbDaireno);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtKullanıcıadı);
            Controls.Add(lblDaireno);
            Controls.Add(lblSifre);
            Controls.Add(lblKullanıcıadı);
            Controls.Add(btnKullanıcı);
            Controls.Add(btnYönetici);
            Name = "frAna";
            Text = "Bina Yönetim Sistemi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYönetici;
        private Button btnKullanıcı;
        private Label lblKullanıcıadı;
        private Label lblSifre;
        private Label lblDaireno;
        private TextBox txtKullanıcıadı;
        private TextBox txtSifre;
        private Button btnGiris;
        private ComboBox cbDaireno;
    }
}