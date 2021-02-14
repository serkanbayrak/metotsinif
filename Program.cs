using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim;
           MusteriManeger musteriManeger = new MusteriManeger();
            Musteri musteri = new Musteri();

            musteri.Id = 1;
            musteri.Name = "Serkan";
            musteri.LastName = "Bayrak";
            musteri.TCN = "57118811071";
            musteri.Date = "12/12/2012";
           

            
            Console.WriteLine("Ekle : 1 ");
            Console.WriteLine("Listele : 2 ");
            Console.WriteLine("Sil : 3 ");
            Console.Write("Merhaba Yönetici Serkan Bey Hangi işlemi Yapmak istersiniz ? : ");
            secim = Convert.ToInt32(Console.ReadLine());
            if (secim==1)
            {
                musteriManeger.Ekle();                
            }
            else if(secim == 2)
            {
                musteriManeger.Listele();

            }
            else if (secim == 3)
            {
                musteriManeger.Sil();
            }
            else
            {
                Console.WriteLine("Geçersiz Karakter Girişi");
            }
        }
    }
}
