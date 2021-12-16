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
    public partial class nagrazhdenie : Form
    {
        public nagrazhdenie()
        {
            InitializeComponent();
            query = _query;
            LoadTable();
            LoadCombobox();
        }
        string query;
        const string _query = "select nagrazhdenie.id_nagrajdinie, nagradi.Nagradi, sportman.Sportman, nagrazhdenie.Nagrazhdenie " +
            "from nagrazhdenie, nagradi, sportman " +
            "where nagrazhdenie.ID_nagradi = nagradi.ID_nagradi and nagrazhdenie.ID_sportman = sportman.ID_sportman ";
        private void LoadTable()
        {
            MySqlConnection con = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                (query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            redNagr red = new redNagr();
            red.ShowDialog();
            LoadTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                redNagr red = new redNagr(id);
                red.ShowDialog();
                LoadTable();
            }
            catch (InvalidCastException)
            {
                button1_Click(null, null);
            }
            catch (ArgumentOutOfRangeException)
            { }
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
            nagradi.SelectedIndexChanged += new EventHandler(ComboBoxSelectedIndexChanged);
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
            sportman.SelectedIndexChanged += new EventHandler(ComboBoxSelectedIndexChanged);
        }
        void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            query = _query;
            foreach (Control cb in panel1.Controls)
            {
                if (cb is ComboBox)
                    if ((cb as ComboBox).SelectedIndex != -1) query += $@" and nagrazhdenie.{cb.Tag}={(cb as ComboBox).SelectedValue}";
            }
            LoadTable();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = checkBox1.Checked;
        }
    }
}
