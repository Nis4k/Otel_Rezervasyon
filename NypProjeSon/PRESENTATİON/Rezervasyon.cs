using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NypProjeSon.BUSINESS;

namespace NypProjeSon.PRESENTATİON
{
    public partial class frmRezervasyon : Form
    {
        public frmRezervasyon()
        {
            InitializeComponent();
        }

        private void lblKimlik_Click(object sender, EventArgs e)
        {

        }

        private void btnKroki101_Click(object sender, EventArgs e)
        {
            txtSecilenOda.Text = "101";
        }

        private void btnKroki102_Click(object sender, EventArgs e)
        {
            txtSecilenOda.Text = "102";
        }

        private void btnKroki103_Click(object sender, EventArgs e)
        {
            txtSecilenOda.Text = "103";
        }

        private void txtSonUcret_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime checkInDate = dateGiris.Value;
                DateTime checkOutDate = dateCikis.Value;

                // Tarih kontrolü
                if (checkInDate >= checkOutDate)
                {
                    MessageBox.Show("Giriş tarihi çıkış tarihinden önce olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSonUcret.Text = "0";
                    return;
                }

                // Ücret hesaplama
                UcretHesaplama ucretHesaplama = new UcretHesaplama();
                decimal totalPrice = ucretHesaplama.Hesapla(checkInDate, checkOutDate);

                // Ücretin Türk Lirası formatında yazdırılması
                txtSonUcret.Text = totalPrice.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("tr-TR"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            try
            {
                // Formdan değerleri alıyoruz
                string Isim = txtIsim.Text;
                string Soyisim = txtSoyisim.Text;
                string Kimlik = maskedTextBox1.Text;
                int Secilenoda = int.Parse(txtSecilenOda.Text);
                string Giris = dateGiris.Text;
                string Cikis = dateCikis.Text;
                string Ucret = txtSonUcret.Text;
                // Ücreti dönüştürmeden önce kontrol ediyoruz
                (new Rezervasyon()).KaydetRezervasyon(Isim, Soyisim, Kimlik, Secilenoda, Giris, Cikis, Ucret);

                // Başarılı mesajı
                MessageBox.Show("Rezervasyon başarıyla kaydedildi.");
            }
            catch (Exception ex)
            {
                // Hata mesajı
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        public void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void grpRezervasyon_Enter(object sender, EventArgs e)
        {

        }

        private void txtKimlik_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpKroki_Enter(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {

            frmislemSec frmislemSec = new frmislemSec();
            frmislemSec.Show();
        }
    }
}
