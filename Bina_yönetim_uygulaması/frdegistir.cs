using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bina_yönetim_uygulaması
{
    public partial class frdegistir : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlCommand cmd1;
        public frdegistir()
        {
            InitializeComponent();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection("Server=localhost;Database=Binayonetim;Uid=root;Pwd=123123;");
            string pass = txtEskisifre.Text;
            string newpass = txtYenisifre.Text;
            string user = "Admin";
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;


            cmd.CommandText = "SELECT * FROM kullanicibilgileri where KullaniciAdi='" + user + "' AND Sifre='" + pass + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                con.Open();

                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE kullanicibilgileri set KullaniciAdi ='" + user + "', Sifre='" + newpass + "'  where KullaniciAdi='" + user + "'";


                cmd.ExecuteNonQuery();

                MessageBox.Show("Başarıyla değiştirildi");
            }
            else
            {
                MessageBox.Show("Eski sifrenizi yanlış girdiniz.");
            }
            con.Close();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frMenu fr = new frMenu();
            fr.Show();
            this.Hide();
        }
    }
}
