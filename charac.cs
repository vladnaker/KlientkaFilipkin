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
    public partial class charac : Form
    {
        public charac()
        {
            InitializeComponent();
            query = _query;
            LoadTable();
            LoadCombobox();
        }
        string query;
        const string _query = "select characteristic_sport_sooruj.ID_Characteristic_sport_sooruj, sport_sooruj.sport_sooruj, characteristic_sport_sooruj.characteristic_sport_sooruj " +
            "from characteristic_sport_sooruj, sport_sooruj " +
            "where characteristic_sport_sooruj.ID_sport_sooruj = sport_sooruj.ID_sport_sooruj ";
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
                ("select * from sport_sooruj", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sport_sooruj.DataSource = dt;
            sport_sooruj.DisplayMember = "sport_sooruj";
            sport_sooruj.ValueMember = "ID_sport_sooruj";
            sport_sooruj.SelectedIndex = -1;
            sport_sooruj.SelectedIndexChanged += new EventHandler(ComboBoxSelectedIndexChanged);
        }
        void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            query = _query;
            foreach (Control cb in panel1.Controls)
            {
                if (cb is ComboBox)
                    if ((cb as ComboBox).SelectedIndex != -1) query += $@" and characteristic_sport_sooruj.{cb.Tag}={(cb as ComboBox).SelectedValue}";
            }
            LoadTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            redCharac red = new redCharac();
            red.ShowDialog();
            LoadTable();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = checkBox1.Checked;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                redCharac red = new redCharac(id);
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
    }
}
