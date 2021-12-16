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
    public partial class redZanyatiya : Form
    {
        public redZanyatiya()
        {
            InitializeComponent();
            LoadCombobox();
        }
        private void LoadCombobox()
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("select * from sportman", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sportman.DataSource = dt;
            sportman.DisplayMember = "Sportman";
            sportman.ValueMember = "ID_sportman";
            sportman.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"insert into zanyatiya (ID_sportman, zanyatiya)
                values ('{sportman.SelectedValue}',
                '{textBox1.Text}')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
        int id;
        public redZanyatiya(int _id)
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
                ("select * from zanyatiya where ID_zanyatiya =" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sportman.SelectedValue = dt.Rows[0][1];
            textBox1.Text = dt.Rows[0][2].ToString();
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("delete from zanyatiya where ID_zanyatiya = " + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"update zanyatiya 
                set ID_sportman = '{sportman.SelectedValue}', 
                    zanyatiya = '{textBox1.Text}'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
    }
}
