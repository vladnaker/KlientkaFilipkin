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
    public partial class redNagr : Form
    {
        public redNagr()
        {
            InitializeComponent(); 
            LoadCombobox();
        }
        private void LoadCombobox()
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("select * from nagradi", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            nagradi.DataSource = dt;
            nagradi.DisplayMember = "Nagradi";
            nagradi.ValueMember = "ID_nagradi";
            nagradi.SelectedIndex = -1;
            MySqlConnection con1 = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da1 = new MySqlDataAdapter
                ("select * from sportman", con1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            sportman.DataSource = dt1;
            sportman.DisplayMember = "Sportman";
            sportman.ValueMember = "ID_sportman";
            sportman.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"insert into nagrazhdenie (ID_nagradi, ID_sportman, Nagrazhdenie)
                values ('{nagradi.SelectedValue}',
                '{sportman.SelectedValue}',
                '{nagrazhdenie.Text}')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
        int id;
        public redNagr(int _id)
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
                ("select * from nagrazhdenie where ID_nagrajdinie =" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            nagradi.SelectedValue = dt.Rows[0][1];
            sportman.SelectedValue = dt.Rows[0][2];
            nagrazhdenie.Text = dt.Rows[0][3].ToString();
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("delete from nagrazhdenie where ID_nagrajdinie = " + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"update nagrazhdenie 
                set ID_nagradi = '{nagradi.SelectedValue}', 
                    ID_sportman = '{sportman.SelectedValue}',
                    Nagrazhdenie = '{nagrazhdenie.Text}'
                where ID_nagrajdinie={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
    }
}
