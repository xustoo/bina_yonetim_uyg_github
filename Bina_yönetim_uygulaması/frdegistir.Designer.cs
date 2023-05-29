namespace Bina_yönetim_uygulaması
{
    partial class frdegistir
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
            lblYenisifre = new Label();
            txtYenisifre = new TextBox();
            btnDegistir = new Button();
            lblEskisifre = new Label();
            txtEskisifre = new TextBox();
            btnMenu = new Button();
            SuspendLayout();
            // 
            // lblYenisifre
            // 
            lblYenisifre.AutoSize = true;
            lblYenisifre.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblYenisifre.Location = new Point(213, 194);
            lblYenisifre.Name = "lblYenisifre";
            lblYenisifre.Size = new Size(102, 30);
            lblYenisifre.TabIndex = 0;
            lblYenisifre.Text = "Yeni Şifre";
            // 
            // txtYenisifre
            // 
            txtYenisifre.Location = new Point(372, 197);
            txtYenisifre.Name = "txtYenisifre";
            txtYenisifre.Size = new Size(125, 27);
            txtYenisifre.TabIndex = 1;
            // 
            // btnDegistir
            // 
            btnDegistir.BackColor = Color.Purple;
            btnDegistir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDegistir.Location = new Point(263, 280);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(155, 63);
            btnDegistir.TabIndex = 2;
            btnDegistir.Text = "Şifre Değiştir";
            btnDegistir.UseVisualStyleBackColor = false;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // lblEskisifre
            // 
            lblEskisifre.AutoSize = true;
            lblEskisifre.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblEskisifre.Location = new Point(213, 143);
            lblEskisifre.Name = "lblEskisifre";
            lblEskisifre.Size = new Size(99, 30);
            lblEskisifre.TabIndex = 3;
            lblEskisifre.Text = "Eski Şifre";
            // 
            // txtEskisifre
            // 
            txtEskisifre.Location = new Point(372, 143);
            txtEskisifre.Name = "txtEskisifre";
            txtEskisifre.Size = new Size(125, 27);
            txtEskisifre.TabIndex = 4;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Pink;
            btnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.Location = new Point(612, 280);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(155, 63);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "MENÜ";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // frdegistir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMenu);
            Controls.Add(txtEskisifre);
            Controls.Add(lblEskisifre);
            Controls.Add(btnDegistir);
            Controls.Add(txtYenisifre);
            Controls.Add(lblYenisifre);
            Name = "frdegistir";
            Text = "frdegistir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblYenisifre;
        private TextBox txtYenisifre;
        private Button btnDegistir;
        private Label lblEskisifre;
        private TextBox txtEskisifre;
        private Button btnMenu;
    }
}