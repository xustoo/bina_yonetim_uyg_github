namespace Bina_yönetim_uygulaması
{
    partial class frMenu
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
            btnKayıt = new Button();
            btnBilgiler = new Button();
            btnAnasayfa = new Button();
            btnHakkımızda = new Button();
            btnSifredegistir = new Button();
            SuspendLayout();
            // 
            // btnKayıt
            // 
            btnKayıt.BackColor = Color.FromArgb(255, 255, 192);
            btnKayıt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKayıt.Location = new Point(527, 59);
            btnKayıt.Name = "btnKayıt";
            btnKayıt.Size = new Size(216, 94);
            btnKayıt.TabIndex = 1;
            btnKayıt.Text = "KAYIT";
            btnKayıt.UseVisualStyleBackColor = false;
            btnKayıt.Click += btnKayıt_Click;
            // 
            // btnBilgiler
            // 
            btnBilgiler.BackColor = Color.FromArgb(255, 224, 192);
            btnBilgiler.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBilgiler.Location = new Point(67, 59);
            btnBilgiler.Name = "btnBilgiler";
            btnBilgiler.Size = new Size(216, 94);
            btnBilgiler.TabIndex = 2;
            btnBilgiler.Text = "BİLGİLER";
            btnBilgiler.UseVisualStyleBackColor = false;
            btnBilgiler.Click += btnBilgiler_Click;
            // 
            // btnAnasayfa
            // 
            btnAnasayfa.BackColor = Color.FromArgb(192, 255, 255);
            btnAnasayfa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnasayfa.Location = new Point(527, 268);
            btnAnasayfa.Name = "btnAnasayfa";
            btnAnasayfa.Size = new Size(216, 94);
            btnAnasayfa.TabIndex = 4;
            btnAnasayfa.Text = "ANA SAYFA";
            btnAnasayfa.UseVisualStyleBackColor = false;
            btnAnasayfa.Click += btnAnasayfa_Click;
            // 
            // btnHakkımızda
            // 
            btnHakkımızda.BackColor = Color.FromArgb(192, 255, 255);
            btnHakkımızda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHakkımızda.Location = new Point(54, 268);
            btnHakkımızda.Name = "btnHakkımızda";
            btnHakkımızda.Size = new Size(216, 94);
            btnHakkımızda.TabIndex = 5;
            btnHakkımızda.Text = "HAKKIMIZDA";
            btnHakkımızda.UseVisualStyleBackColor = false;
            btnHakkımızda.Click += btnHakkımızda_Click;
            // 
            // btnSifredegistir
            // 
            btnSifredegistir.BackColor = Color.Red;
            btnSifredegistir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSifredegistir.Location = new Point(298, 195);
            btnSifredegistir.Name = "btnSifredegistir";
            btnSifredegistir.Size = new Size(191, 50);
            btnSifredegistir.TabIndex = 6;
            btnSifredegistir.Text = "ŞİFRE DEĞİŞTİR";
            btnSifredegistir.UseVisualStyleBackColor = false;
            btnSifredegistir.Click += btnSifredegistir_Click;
            // 
            // frMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSifredegistir);
            Controls.Add(btnHakkımızda);
            Controls.Add(btnAnasayfa);
            Controls.Add(btnBilgiler);
            Controls.Add(btnKayıt);
            Name = "frMenu";
            Text = "frmenu";
            Load += frMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnKayıt;
        private Button btnBilgiler;
        private Button btnAnasayfa;
        private Button btnHakkımızda;
        private Button btnSifredegistir;
    }
}