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
    public partial class trener : Form
    {
        public trener()
        {
            InitializeComponent();
            query = _query;
            LoadTable();
            LoadCombobox();
        }
        string query;
        const string _query = "select trener.ID_Trener, vidy_sporta.vidy_sporta, trener.trener " +
            "from trener, vidy_sporta " +
            "where trener.ID_vidy_sporta = vidy_sporta.ID_Vidy_sporta ";
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
            vidy_sporta.SelectedIndexChanged += new EventHandler(ComboBoxSelectedIndexChanged);
        }
        void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            query = _query;
            foreach (Control cb in panel1.Controls)
            {
                if (cb is ComboBox)
                    if ((cb as ComboBox).SelectedIndex != -1) query += $@" and trener.{cb.Tag}={(cb as ComboBox).SelectedValue}";
            }
            LoadTable();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                redTrener red = new redTrener(id);
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

        private void button1_Click(object sender, EventArgs e)
        {
                redTrener red = new redTrener();
                red.ShowDialog();
                LoadTable();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = checkBox1.Checked;
        }
    }
}
