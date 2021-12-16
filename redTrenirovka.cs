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

namespace KlientkaFilipkin
{
    public partial class redTrenirovka : Form
    {
        public redTrenirovka()
        {
            InitializeComponent();
            LoadCombobox();
        }
        private void LoadCombobox()
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("select * from zanyatiya", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            zanyatiya.DataSource = dt;
            zanyatiya.DisplayMember = "zanyatiya";
            zanyatiya.ValueMember = "ID_zanyatiya";
            zanyatiya.SelectedIndex = -1;
            MySqlConnection con1 = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da1 = new MySqlDataAdapter
                ("select * from trener", con1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            trener.DataSource = dt1;
            trener.DisplayMember = "trener";
            trener.ValueMember = "ID_Trener";
            trener.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"insert into trenirovka (ID_zanyatiya, ID_trener, trenirovka)
                values ('{zanyatiya.SelectedValue}',
                '{trener.SelectedValue}',
                '{textBox1.Text}')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
        int id;
        public redTrenirovka(int _id)
        {
            InitializeComponent();
            LoadCombobox();
            id = _id;
            button1.Visible = false;
            buttonedit.Visible = true;
            buttondel.Visible = true;
            LoadString();
        }
        private void LoadString()
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("select * from trenirovka where id_trenirovka =" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            zanyatiya.SelectedValue = dt.Rows[0][1];
            trener.SelectedValue = dt.Rows[0][2];
            textBox1.Text = dt.Rows[0][3].ToString();
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("delete from trenirovka where id_trenirovka = " + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"update trenirovka 
                set ID_zanyatiya = '{zanyatiya.SelectedValue}', 
                    ID_trener = '{trener.SelectedValue}',
                    trenirovka = '{textBox1.Text}'
                where id_trenirovka={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
    }
}
