namespace Bina_yönetim_uygulaması
{
    partial class frBilgiler
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
            btnMenu = new Button();
            listvBilgiler = new ListView();
            columnid = new ColumnHeader();
            columnad = new ColumnHeader();
            columnsoyad = new ColumnHeader();
            columndaire = new ColumnHeader();
            columntelefon = new ColumnHeader();
            columnborc = new ColumnHeader();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(192, 255, 255);
            btnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.Location = new Point(663, 343);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(132, 63);
            btnMenu.TabIndex = 12;
            btnMenu.Text = "MENÜ";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // listvBilgiler
            // 
            listvBilgiler.Columns.AddRange(new ColumnHeader[] { columnid, columnad, columnsoyad, columndaire, columntelefon, columnborc });
            listvBilgiler.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listvBilgiler.FullRowSelect = true;
            listvBilgiler.ImeMode = ImeMode.NoControl;
            listvBilgiler.Location = new Point(35, 12);
            listvBilgiler.MinimumSize = new Size(200, 0);
            listvBilgiler.Name = "listvBilgiler";
            listvBilgiler.Size = new Size(622, 394);
            listvBilgiler.TabIndex = 17;
            listvBilgiler.UseCompatibleStateImageBehavior = false;
            listvBilgiler.View = View.Details;
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
            // frBilgiler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listvBilgiler);
            Controls.Add(btnMenu);
            Name = "frBilgiler";
            Text = "frBilgiler";
            Load += frBilgiler_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenu;
        private ListView listvBilgiler;
        private ColumnHeader columnid;
        private ColumnHeader columnad;
        private ColumnHeader columnsoyad;
        private ColumnHeader columndaire;
        private ColumnHeader columntelefon;
        private ColumnHeader columnborc;
    }
}