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

namespace NypProjeSon.PRESENTATİON
{
    public partial class frmislemSec : Form
    {
        public frmislemSec()
        {
            InitializeComponent();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            frmRezervasyon frmrezerve = new frmRezervasyon();
            frmrezerve.Show();
        }

        private void btnOdaIslemleri_Click(object sender, EventArgs e)
        {
            odalarIslem frmodalaris = new odalarIslem();
            frmodalaris.Show();
        }

        private void btnRezervasyon_Click_1(object sender, EventArgs e)
        {
            frmRezervasyon frmrez = new frmRezervasyon();
            frmrez.Show();
        }
    }
}
