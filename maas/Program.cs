using System;

namespace PersonelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel pers = new Personel();
            Console.WriteLine("isim  Giriniz:");
            pers.ad = Console.ReadLine();

            Console.WriteLine("Soyisim Giriniz");
            pers.soyad = Console.ReadLine();

            Console.WriteLine("İşe giriş yılı giriniz: ");
            int yil = int.Parse(Console.ReadLine());

            pers.SetMaas(yil);
            Console.WriteLine("Sayın  " + pers.ad +" "+ pers.soyad + " maaşınız  " + pers.GetMaas());
            Console.ReadKey();
        }

    }
    class Personel
    {
        public string ad;
        public string soyad;
        public int yil;
        double maas;
        public void SetAd(string ad)
        {
            this.ad = ad;
        }
        public void SetMaas(int yil)
        {
            this.yil = yil;
            int taban = 1000;
            double katsayi = 0.8;
            int tarih = 2021;

            double net = (taban * katsayi) * (tarih - yil);
            maas = net;

        }

        public double GetMaas()
        {
            return this.maas;
        }


    }
}