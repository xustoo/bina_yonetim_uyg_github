using MySql.Data.MySqlClient;

namespace Bina_yönetim_uygulaması
{
    public partial class frAna : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public frAna()
        {
            InitializeComponent();
        }

        void kullanıcıgöster()
        {
            lblKullanıcıadı.Visible = false;
            lblSifre.Visible = false;
            txtKullanıcıadı.Visible = false;
            txtSifre.Visible = false;
            lblDaireno.Visible = true;
            cbDaireno.Visible = true;
            btnGiris.Visible = false;

        }


        void yöneticigöster()
        {
            lblKullanıcıadı.Visible = true;
            lblSifre.Visible = true;
            txtKullanıcıadı.Visible = true;
            txtSifre.Visible = true;
            lblDaireno.Visible = false;
            cbDaireno.Visible = false;
            btnGiris.Visible = true;



        }
        void loadkısmı()
        {
            lblDaireno.Visible = false;
            lblKullanıcıadı.Visible = false;
            lblSifre.Visible = false;
            cbDaireno.Visible = false;
            txtKullanıcıadı.Visible = false;
            txtSifre.Visible = false;
            btnGiris.Visible = false;






        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadkısmı();

            DaireVerileri();
        }

        private void btnYönetici_Click(object sender, EventArgs e)
        {
            yöneticigöster();
        }

        private void btnKullanıcı_Click(object sender, EventArgs e)
        {
            kullanıcıgöster();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string user = txtKullanıcıadı.Text;
            string pass = txtSifre.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullanicibilgileri where KullaniciAdi='" + user + "' AND Sifre='" + pass + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı. ");
                frMenu fr = new frMenu();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz.");
            }
            con.Close();
        }




        void DaireVerileri()
        {
            con = new MySqlConnection("Server=localhost;Database=Binayonetim;Uid=root;Pwd=123123;");

            cbDaireno.Items.Clear();
            con.Open();
            cmd = new MySqlCommand("SELECT DISTINCT Daire FROM kisibilgiler", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbDaireno.Items.Add(dr["Daire"].ToString());
            }
            con.Close();
        }


        private void cbDaireno_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenDaire = cbDaireno.SelectedItem.ToString();

            frDairecs fr = new frDairecs(secilenDaire);
            fr.Show();
            this.Hide();

        }

        
    }
}
