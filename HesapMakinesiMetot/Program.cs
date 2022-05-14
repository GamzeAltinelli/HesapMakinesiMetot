using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesiMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KullaniciyiKarsila();
            KullaniciyiBilgilendir();
            //byte islem = KullanicidanIslemTuruBilgisiAl();
            //IslemTurunuKontrolEt(islem);
            //double sayi1 = KullanicidanSayiAl();
            //double sayi2 = KullanicidanSayiAl();
            //double sonuc = Hesapla(islem, sayi1, sayi2);
            double sonuc=Topla(1.1, 2);
            Topla(1, 2, 3);
            Topla(1, 2,"toplam");
            //SonucYaz(sonuc);
            KullaniciyiUgurla();
        }

        private static void KullaniciyiKarsila()
        {
            Console.WriteLine("Hoşgeldiniz");
        }

        private static void KullaniciyiBilgilendir()
        {
            Console.WriteLine("Sizden istenen iki sayı ile 4 işlem yapabilmeniz mümkün olacaktır.");
        }

        private static byte KullanicidanIslemTuruBilgisiAl()
        {
            Console.WriteLine("İşlem türünü seçiniz: \n1-Toplama \n2-Çıkarma \n3-Çarpma \n4-Bölme");
            try
            {
                byte islem = Convert.ToByte(Console.ReadLine());
                return islem;

            }
            catch (Exception)
            {
                Console.WriteLine("İşlem türü yanlış seçilmiştir.");
                return KullanicidanIslemTuruBilgisiAl();
            }

        }

        private static void IslemTurunuKontrolEt(byte islem)
        {
            switch (islem)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("İşlem türü bilgisi alınmıştır işleminiz devam etmektedir.");
                    break;
                default:
                    Console.WriteLine("İşlem türü bilgisi yanlış girilmiştir.");
                    KullanicidanIslemTuruBilgisiAl();
                    break;
            }
        }

        private static double KullanicidanSayiAl()
        {
            Console.Write("Sayı giriniz: ");
            try
            {
                double sayi = Convert.ToDouble(Console.ReadLine());
                
                return sayi;

            }
            catch (Exception)
            {
                Console.WriteLine("Girilen veri istenilen formatta değildir.");
                return KullanicidanSayiAl();
            }
        }

      

        private static double Hesapla(byte islem, double sayi1, double sayi2)
        {
            double sonuc = 0;
            switch (islem)
            {
                case 1:
                    sonuc = Topla(sayi1, sayi2);
                    break;
                case 2:
                    sonuc = Cikar(sayi1, sayi2);
                    break;
                case 3:
                    sonuc = Carp(sayi1, sayi2);
                    break;
                case 4:
                    sonuc = Bol(sayi1, sayi2);
                    break;

            }
            return sonuc;
        }

        private static double Bol(double sayi1, double sayi2)
        {
            if (sayi2==0)
            {
                Console.WriteLine("İkinci sayıyı 0 girdiğiniz için tekrar giriş yapmanız gerekmektedir.");
                return KullanicidanSayiAl();
                if (sayi1==0)
                {
                    Console.WriteLine("0/0 belirsizliğinden dolayı ilk sayı için tekrar giriş yapınız.");
                    return KullanicidanSayiAl();
                }
            }
            return sayi1 / sayi2;

        }

        private static double Sayi2KontrolEt(double sayi2)
        {
            if (sayi2==0)
            {
                KullanicidanSayiAl();
            }
            return sayi2;
        }

        private static double Carp(double sayi1, double sayi2)
        {
            double sonuc= sayi1 * sayi2;
            return sonuc;
        }

        private static double Cikar(double sayi1, double sayi2)
        {
            return sayi1 - sayi2;
        }

        //İki sayı için yazılmış Topla metodu
        private static double Topla(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        } 
        //İki sayı için yazılmış Topla metodu
        private static int Topla(int sayi1, double sayi2)
        {
            return sayi1 + (int)sayi2;
        }
        //İki sayı için yazılmış Topla metodu
        private static void Topla(double sayi1, double sayi2,string islem)
        {
            Console.WriteLine("İslem: "+islem+ " "+sayi1 + sayi2);
        }

        //Üç sayı için yazılmış Topla metodu
        private static double Topla(double sayi1, double sayi2,double sayi3)
        {
            return sayi1 + sayi2+sayi3;
        }
        private static void SonucYaz(double sonuc)
        {
            Console.WriteLine("İşlem sonucunuz: " + sonuc);
        }

        private static void KullaniciyiUgurla()
        {
            Console.WriteLine("Bizi tercih ettiğiniz için teşekkürler.");
        }
    }
}
