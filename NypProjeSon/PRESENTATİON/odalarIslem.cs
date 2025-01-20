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
using NypProjeSon.BUSINESS;
using NypProjeSon.DAL;

namespace NypProjeSon.PRESENTATİON
{
    public partial class odalarIslem : Form
    {
        public odalarIslem()
        {
            InitializeComponent();
        }

        private void btnislem101_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti =
                    new MySqlConnection("Server=172.21.54.253;Database=25_132330039;User=25_132330039;Password=!nif.ogr39AK");
                baglanti.Open();

                // SQL Sorgusu ile veri çekme
                MySqlCommand komut = new MySqlCommand("SELECT isim, soyisim, kimlik, secilenoda, giris, cikis FROM adminRezervasyon", baglanti);
                komut.Connection = baglanti;

                // Verileri oku
                MySqlDataReader okunanlar = komut.ExecuteReader();

                // Listeyi temizle
                Bilgiler.Items.Clear();

                // Verileri ListBox'a ekle
                while (okunanlar.Read())
                {
                    string isim = okunanlar["isim"].ToString();
                    string soyisim = okunanlar["soyisim"].ToString();
                    string kimlik = okunanlar["kimlik"].ToString();
                    string secilenoda = okunanlar["secilenoda"].ToString();
                    string giris = okunanlar["giris"].ToString();
                    string cikis = okunanlar["cikis"].ToString();

                    // Bilgileri birleştirip listeye ekle
                    string bilgi = $"{isim} {soyisim} - Kimlik: {kimlik} - Oda: {secilenoda} - Giriş: {giris} - Çıkış: {cikis}";
                    Bilgiler.Items.Add(bilgi);
                }

                okunanlar.Close();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
            }
        }

        private void Bilgiler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

            Bilgiler.Text = "";
            try
            {
                MySqlConnection baglanti =
                    new MySqlConnection("Server=172.21.54.253;Database=25_132330039;User=25_132330039;Password=!nif.ogr39AK");
                baglanti.Open();

                // Silinecek kimlik değerini kullanıcıdan al
                string silinecekKimlik = maskedTextBox1.Text;  // Örnek kimlik, bunu kullanıcıdan alabilirsiniz (örneğin bir TextBox'tan).

                // Kimliği eşit olan satırı sil
                MySqlCommand silKomutu = new MySqlCommand("DELETE FROM adminRezervasyon WHERE kimlik = @kimlik", baglanti);
                silKomutu.Parameters.AddWithValue("@kimlik", silinecekKimlik);

                // Sorguyu çalıştır
                int silinenKayitSayisi = silKomutu.ExecuteNonQuery();

                if (silinenKayitSayisi > 0)
                {
                    MessageBox.Show("Kayıt başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show("Silinecek kayıt bulunamadı.");
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }




        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Bilgiler.Text = "";

            // Kullanıcıdan gelen kimlik değerini al
            string silinecekKimlik = maskedTextBox1.Text.Trim();

            // Kimlik girişinin boş olup olmadığını kontrol et
            if (string.IsNullOrEmpty(silinecekKimlik))
            {
                MessageBox.Show("Lütfen silmek için bir kimlik giriniz.");
                return;
            }

            try
            {
                // Veritabanı bağlantısını oluştur
                using (MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=25_132330039;User=25_132330039;Password=!nif.ogr39AK"))
                {
                    baglanti.Open();

                    // Kimliği eşit olan satırı sil
                    using (MySqlCommand silKomutu = new MySqlCommand("DELETE FROM adminRezervasyon WHERE kimlik = @kimlik", baglanti))
                    {
                        silKomutu.Parameters.AddWithValue("@kimlik", silinecekKimlik);

                        // Sorguyu çalıştır
                        int silinenKayitSayisi = silKomutu.ExecuteNonQuery();

                        // İşlem sonucunu kontrol et
                        if (silinenKayitSayisi > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla silindi.");
                        }
                        else
                        {
                            MessageBox.Show("Silinecek kayıt bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        
        
    }
    }
    
    

