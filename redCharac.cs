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
    public partial class redCharac : Form
    {
        public redCharac()
        {
            InitializeComponent();
            LoadCombobox();
        }
        private void LoadCombobox()
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("select * from sport_sooruj", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sport_sooruj.DataSource = dt;
            sport_sooruj.DisplayMember = "sport_sooruj";
            sport_sooruj.ValueMember = "ID_sport_sooruj";
            sport_sooruj.SelectedIndex = -1;
        }
        int id;
        public redCharac(int _id)
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
                ("select * from characteristic_sport_sooruj where ID_Characteristic_sport_sooruj =" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sport_sooruj.SelectedValue = dt.Rows[0][1];
            charac.Text = dt.Rows[0][2].ToString();
        }
        private void buttondel_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("delete from characteristic_sport_sooruj where ID_Characteristic_sport_sooruj = " + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"update characteristic_sport_sooruj 
                set ID_sport_sooruj = '{sport_sooruj.SelectedValue}',
                    characteristic_sport_sooruj = '{charac.Text}'
                where ID_Characteristic_sport_sooruj = {id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"insert into characteristic_sport_sooruj (ID_sport_sooruj, characteristic_sport_sooruj)
                values ({sport_sooruj.SelectedValue}, 
                '{charac.Text}')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
    }
}
