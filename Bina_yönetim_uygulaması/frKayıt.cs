using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bina_yönetim_uygulaması
{
    public partial class frKayıt : Form
    {

        public frKayıt()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=binayonetim;Uid=root;Pwd=123123;");
        private void Verilerigoster()
        {
            listView1.Items.Clear();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * From kisibilgiler", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr["id"].ToString();
                item.SubItems.Add(dr["Ad"].ToString());
                item.SubItems.Add(dr["Soyad"].ToString());
                item.SubItems.Add(dr["Daire"].ToString());
                item.SubItems.Add(dr["Telefon"].ToString());
                item.SubItems.Add(dr["Borc"].ToString());

                listView1.Items.Add(item);

            }
            conn.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO kisibilgiler (Ad, Soyad, Daire, Telefon, Borc) VALUES (@ad, @soyad, @daire, @telefon, @borc)", conn);
            cmd.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
            cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text.Trim());
            cmd.Parameters.AddWithValue("@daire", txtDaireno.Text.Trim());
            cmd.Parameters.AddWithValue("@telefon", txtTel.Text.Trim());
            cmd.Parameters.AddWithValue("@borc", txtBorç.Text.Trim());
            cmd.ExecuteNonQuery();
            conn.Close();
            Verilerigoster();


            MessageBox.Show("Kullanıcı Kaydedildi Bilgiler Sekmesinden Görebilirsiniz.");
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frMenu fr = new frMenu();
            fr.Show();
            this.Hide();
        }

        private void btnVerilerigöster_Click(object sender, EventArgs e)
        {

            Verilerigoster();

        }
        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtDaireno.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtTel.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtBorç.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM kisibilgiler WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
            Verilerigoster();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtDaireno.Text = "";
            txtTel.Text = "";
            txtBorç.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE kisibilgiler SET Ad = @ad, Soyad = @soyad, Daire = @daire, Telefon = @telefon, Borc = @borc WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
            cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text.Trim());
            cmd.Parameters.AddWithValue("@daire", txtDaireno.Text.Trim());
            cmd.Parameters.AddWithValue("@telefon", txtTel.Text.Trim());
            cmd.Parameters.AddWithValue("@borc", txtBorç.Text.Trim());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
            Verilerigoster();
        }
    }
}
