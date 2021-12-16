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
    public partial class redSorev : Form
    {
        public redSorev()
        {
            InitializeComponent();
            LoadCombobox();
        }
        private void LoadCombobox()
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("select * from vidy_sporta", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            vidy_sporta.DataSource = dt;
            vidy_sporta.DisplayMember = "vidy_sporta";
            vidy_sporta.ValueMember = "ID_Vidy_sporta";
            vidy_sporta.SelectedIndex = -1;
            MySqlConnection con1 = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da1 = new MySqlDataAdapter
                ("select * from sport_sooruj", con1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            sport_sooruj.DataSource = dt1;
            sport_sooruj.DisplayMember = "sport_sooruj";
            sport_sooruj.ValueMember = "ID_sport_sooruj";
            sport_sooruj.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"insert into sorevnovaniya (ID_Vidy_sporta, ID_sport_sooruj, sorevnovanie)
                values ('{vidy_sporta.SelectedValue}',
                '{sport_sooruj.SelectedValue}',
                '{sorevnovanie.Text}')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
        int id;
        public redSorev(int _id)
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
                ("select * from sorevnovaniya where id_sorevnovanie =" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            vidy_sporta.SelectedValue = dt.Rows[0][1];
            sport_sooruj.SelectedValue = dt.Rows[0][2];
            sorevnovanie.Text = dt.Rows[0][3].ToString();
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("delete from sorevnovaniya where ID_sorevnovanie = " + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"update sorevnovaniya 
                set ID_vidy_sporta = '{vidy_sporta.SelectedValue}', 
                    ID_sport_sooruj = '{sport_sooruj.SelectedValue}',
                    sorevnovanie = '{sorevnovanie.Text}'
                where ID_sorevnovanie={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
    }
}
