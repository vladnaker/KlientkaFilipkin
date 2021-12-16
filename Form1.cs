using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlientkaFilipkin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zanyatiya zan = new zanyatiya();
            zan.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trenirovka tren = new trenirovka();
            tren.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            trener tr = new trener();
            tr.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sportman sp = new sportman();
            sp.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sorevnovaniya sor = new sorevnovaniya();
            sor.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nagrazhdenie nag = new nagrazhdenie();
            nag.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            charac css = new charac();
            css.ShowDialog();
        }
    }
}
