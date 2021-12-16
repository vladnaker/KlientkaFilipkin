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
    public partial class redSportman : Form
    {
        public redSportman()
        {
            InitializeComponent();
            LoadCombobox();
        }
        private void LoadCombobox()
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("select * from club", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            club.DataSource = dt;
            club.DisplayMember = "Club";
            club.ValueMember = "ID_Club";
            club.SelectedIndex = -1;
        }
        int id;
        public redSportman(int _id)
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
                ("select * from sportman where ID_sportman =" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            club.SelectedValue = dt.Rows[0][1];
            sportman.Text = dt.Rows[0][2].ToString();
        }
        private void buttondel_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("delete from sportman where ID_sportman = " + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"update sportman 
                set ID_Club = '{club.SelectedValue}',
                    sportman = '{sportman.Text}'
                where ID_sportman = {id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"insert into sportman (ID_Club, sportman)
                values ({club.SelectedValue}, 
                '{sportman.Text}')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
    }
}
