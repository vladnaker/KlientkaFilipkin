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
    public partial class zanyatiya : Form
    {
        public zanyatiya()
        {
            InitializeComponent();
            query = _query;
            LoadTable();
            LoadCombobox();
        }
        string query;
        const string _query = "select zanyatiya.ID_zanyatiya, sportman.Sportman, zanyatiya.zanyatiya from zanyatiya, sportman " +
            "where zanyatiya.ID_sportman = sportman.ID_sportman";
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
            redZanyatiya red = new redZanyatiya();
            red.ShowDialog();
            LoadTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                redZanyatiya red = new redZanyatiya(id);
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
                ("select * from sportman", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sportman.DataSource = dt;
            sportman.DisplayMember = "sportman";
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
                    if ((cb as ComboBox).SelectedIndex != -1) query += $@" and zanyatiya.{cb.Tag}={(cb as ComboBox).SelectedValue}";
            }
            LoadTable();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = checkBox1.Checked;
        }
    }
}
