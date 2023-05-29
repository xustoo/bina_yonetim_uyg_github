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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bina_yönetim_uygulaması
{
    public partial class frBilgiler : Form
    {
        public frBilgiler()
        {
            InitializeComponent();
            Verilerigoster();



        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frMenu fr = new frMenu();
            fr.Show();
            this.Hide();
        }
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=binayonetim;Uid=root;Pwd=123123;");
        private void Verilerigoster()
        {
            listvBilgiler.Items.Clear();
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

                listvBilgiler.Items.Add(item);

            }
            conn.Close();
        }

        private void frBilgiler_Load(object sender, EventArgs e)
        {
            Verilerigoster();
        }
    }
}
