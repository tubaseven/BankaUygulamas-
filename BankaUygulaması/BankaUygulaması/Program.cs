using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Banka banka = new Banka();
            Tekrar(banka);
           
            
        }
        public static int SecimMenusu()
        {
            Console.WriteLine("1-Hesap Ekle..");
            Console.WriteLine("2-Hesap Listele..");
            Console.WriteLine("3-Para Yatır..");
            Console.WriteLine("4-Havale Yap..");
            int secim = Convert.ToInt32(Console.ReadLine());
       
            return secim;

        }
        public static decimal GetIntegerFromUser(string message)
        {

            Console.Write(message);
            return Convert.ToDecimal(Console.ReadLine());


        }
        public static string KullanıcıGiriş(string message)
        {
            Console.Write(message);
            return Console.ReadLine();

        }

        public static void Cıkıs(Banka banka)
        {
            Console.Clear();
            Console.WriteLine("Devam etmek istiyor musunuz?E- H");
            if ('e' == Console.ReadKey().KeyChar)
            {
                
                Tekrar(banka);

            }

                         
        }

        public static void Tekrar(Banka banka) // method tanımlarında tip var.çağırırken tip yok
        {
            int secim1 = SecimMenusu();
            switch (secim1)
            {
                case 1:
                    Hesap hesap = new Hesap();
                    hesap.Kullanıcı = new Kullanıcı();
                    hesap.Kullanıcı.Ad = KullanıcıGiriş("Adınız:");
                    hesap.Kullanıcı.Soyad = KullanıcıGiriş("Soyadınız:");
                    hesap.Kullanıcı.Tc_no = KullanıcıGiriş("Tc:");
                    hesap.HesapNo = KullanıcıGiriş("Hesap No:");
                    hesap.Bakiye = GetIntegerFromUser("Bakiyenizi giriniz:");
                    banka.YeniHesap(hesap);
                    
                    Cıkıs(banka);


                    break;
                case 2:
                    Console.WriteLine(banka.HesapListele());
                    Console.ReadKey();
                    Cıkıs(banka);
                    break;
                case 3:
                    decimal tutar = 0;
                    Console.WriteLine("Ne kadar para yatırılacak giriniz:");
                    tutar = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine(banka.HesapListele());
                    Console.WriteLine("Para gönderilecek hesabı giriniz:");
                    int alıcı1 = Convert.ToInt32(Console.ReadLine());
                    banka.ParaYatır(banka.hesaplar[alıcı1-1], tutar);
                    Console.WriteLine("Alıcı Yeni bakiye{0}:", banka.hesaplar[alıcı1 - 1].Bakiye);
                    Console.ReadKey();
                    Cıkıs(banka);
                    break;
                case 4:
                    decimal tutar2 = 0;
                    Console.WriteLine(banka.HesapListele());
                   
                    Console.WriteLine("Gönderen hesabı giriniz:");
                    int gönderen = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(banka.HesapListele());
                   
                    Console.WriteLine("Alıcı hesabı giriniz:");
                    int alıcı = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Havale edilecek miktarı giriniz:");
                    tutar2 = Convert.ToDecimal(Console.ReadLine());

                    banka.HavaleYap(gönderen, alıcı, tutar2);
                    Console.WriteLine("Havaleniz gerçekleşti..");

                    Console.WriteLine("Alıcı Yeni bakiye{0}:", banka.hesaplar[alıcı - 1].Bakiye);
                    Console.ReadKey();
                    Cıkıs(banka);
                    break;


                default:
                    break;

            }
        }





    }
}






