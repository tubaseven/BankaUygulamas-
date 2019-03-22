using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulaması
{
    class Banka
           {

       public  Hesap[] hesaplar;//yerini ayırır objeyi yaratmaz.
        public Dosyaİşlemleri dosya=new Dosyaİşlemleri(); //yeşil olanlar class yani tipi ve ondan obje üretiyoruz.methodları da obje üzerinden çağırırız.
        
        public void YeniHesap(Hesap hesap)
        {
            if (hesaplar == null)
            {
                hesaplar = new Hesap[1];
                hesaplar[0] = hesap;

            }
            else
            {
                Hesap[] gecici = hesaplar;
                hesaplar = new Hesap[gecici.Length + 1];
                for(int i = 0; i < gecici.Length; i++)
                {
                    hesaplar[i] = gecici[i];
                }
                hesaplar[hesaplar.Length - 1] = hesap;
            }
            dosya.DosyaEkle(hesap);
                                   
        }
        
        public string HesapListele()
        {

            string liste ="" ;
            for(int i = 0; i < hesaplar.Length; i++)
            {
                liste = liste + string.Format("Hesap Numarası:{3} Ad: {0} Soyad: {1} \n Bakiye{2},Tc Kimlik {4}",hesaplar[i].Kullanıcı.Ad,hesaplar[i].Kullanıcı.Soyad,hesaplar[i].Bakiye,hesaplar[i].HesapNo,hesaplar[i].Kullanıcı.Tc_no);
            }

            return liste;
            
        }

        public void ParaYatır(Hesap hesap, decimal tutar)
        {
            hesap.Bakiye += tutar;
        }

        public void HavaleYap(int gönderen, int alıcı, decimal tutar)
        {
            

                hesaplar[gönderen - 1].Bakiye -= tutar;
                hesaplar[alıcı - 1].Bakiye += tutar;
            
          
        }

        public int Cıkıs()
        {
            return 0;
        }

    }
}

