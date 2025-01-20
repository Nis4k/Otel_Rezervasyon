using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NypProjeSon.BUSINESS
{
    class UcretHesaplama
    {
        private const decimal DailyRate = 100;


        public decimal Hesapla(DateTime checkInDate, DateTime checkOutDate)
        {
            if (checkOutDate <= checkInDate)
                throw new Exception("Çıkış tarihi, giriş tarihinden sonra olmalıdır.");

            int totalDays = (checkOutDate - checkInDate).Days;

            decimal totalPrice = totalDays * DailyRate;
            return totalPrice;
        }
        public void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            // DateTimePicker'dan değerleri alıyoruz
            DateTime checkInDate = ((DateTimePicker)sender).Value;  // Giriş tarihi
            DateTime checkOutDate = ((DateTimePicker)sender).Value;  // Çıkış tarihi

            try
            {
                // UcretHesaplama sınıfı üzerinden ücret hesaplaması
                decimal totalPrice = Hesapla(checkInDate, checkOutDate);  // Ücreti hesapla

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: {ex.Message}");  // Hata mesajını göster
            }
        }
    }
}
