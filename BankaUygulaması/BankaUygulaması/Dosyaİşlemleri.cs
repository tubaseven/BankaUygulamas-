using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulaması
{
    class Dosyaİşlemleri
    {
        public void DosyaEkle(Hesap hesap)
        {
            string[] metin = new string[1];

            metin[0]= string.Format("{0},{1},{2},{3},{4}", hesap.HesapNo, hesap.Kullanıcı.Ad, hesap.Kullanıcı.Soyad, hesap.Bakiye, hesap.Kullanıcı.Tc_no);

            File.AppendAllLines(@"F:\BankaUygulaması\hesaplistesi.txt", metin);
     

        }
    }

}