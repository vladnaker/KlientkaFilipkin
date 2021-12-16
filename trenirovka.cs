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
    public partial class trenirovka : Form
    {
        public trenirovka()
        {
            InitializeComponent();
            query = _query;
            LoadTable();
            LoadCombobox();
        }
        string query;
        const string _query = "select trenirovka.id_trenirovka, zanyatiya.zanyatiya, trener.trener, trenirovka.trenirovka " +
            "from trenirovka, zanyatiya, sportman, trener " +
            "where trenirovka.ID_zanyatiya = zanyatiya.ID_zanyatiya AND trenirovka.ID_trener = trener.ID_trener ";
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
            redTrenirovka red = new redTrenirovka();
            red.ShowDialog();
            LoadTable();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                redTrenirovka red = new redTrenirovka(id);
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
                ("select * from zanyatiya", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            zanyatiya.DataSource = dt;
            zanyatiya.DisplayMember = "zanyatiya";
            zanyatiya.ValueMember = "ID_zanyatiya";
            zanyatiya.SelectedIndex = -1;
            zanyatiya.SelectedIndexChanged += new EventHandler(ComboBoxSelectedIndexChanged);
            MySqlConnection con1 = new MySqlConnection
                ("Server=127.0.0.1;Database=filipkin;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da1 = new MySqlDataAdapter
                ("select * from trener", con1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            trener.DataSource = dt1;
            trener.DisplayMember = "trener";
            trener.ValueMember = "ID_Trener";
            trener.SelectedIndex = -1;
            trener.SelectedIndexChanged += new EventHandler(ComboBoxSelectedIndexChanged);
        }
        void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            query = _query;
            foreach (Control cb in panel1.Controls)
            {
                if (cb is ComboBox)
                    if ((cb as ComboBox).SelectedIndex != -1) query += $@" and trenirovka.{cb.Tag}={(cb as ComboBox).SelectedValue}";
            }
            LoadTable();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = checkBox1.Checked;
        }
    }
}
