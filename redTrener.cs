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
    public partial class redTrener : Form
    {
        public redTrener()
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
        }
        int id;
        public redTrener(int _id)
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
                ("select * from trener where ID_Trener =" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            vidy_sporta.SelectedValue = dt.Rows[0][1];
            trener.Text = dt.Rows[0][2].ToString();
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("delete from trener where ID_Trener = " + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"update trener 
                set ID_vidy_sporta = '{vidy_sporta.SelectedValue}',
                    trener = '{trener.Text}'
                where ID_Trener = {id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"insert into trener (ID_vidy_sporta, trener)
                values ({vidy_sporta.SelectedValue}, 
                '{trener.Text}')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
    }
}
