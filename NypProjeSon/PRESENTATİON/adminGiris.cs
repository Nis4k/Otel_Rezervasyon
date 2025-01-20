using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mysqlx.Datatypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NypProjeSon.PRESENTATİON
{
    public partial class frmadminGiris : Form
    {
        public frmadminGiris()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtKullanıcıAdi.Text == "Nisa" && txtSifre.Text == "5353")
            {
                frmislemSec frmislemSec = new frmislemSec();
                frmislemSec.Show();
            }
            else
            {
                MessageBox.Show("kullanıcı Adı veya Şifre Hatalı");
            }
        }

        private void frmadminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
