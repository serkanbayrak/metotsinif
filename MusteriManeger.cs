using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManeger
    {
        Musteri musteri = new Musteri();
        List<Musteri> musteris = new List<Musteri> ();
        public void Ekle()
        {
            Console.Write("Müşteri Id giriniz : ");
            musteri.Id = Convert.ToInt16(Console.ReadLine());            
            Console.Write("Müşteri Adını Giriniz : ");
            musteri.Name = Console.ReadLine();
            Console.Write("Müşteri Soyadını giriniz");
            musteri.LastName = Console.ReadLine();
            Console.Write("Lütfen TC Numarasını Giriniz");
            musteri.TCN = Console.ReadLine();
            Console.Write("Müşteri Hesap Tutarı : ");
            musteri.Date = Console.ReadLine();
            musteris.Add(musteri);
            foreach (var item in musteris)
            {
                Console.WriteLine("Id : " + item.Id);
                Console.WriteLine("Name : " + item.Name);
                Console.WriteLine("LastName" + item.LastName);
                Console.WriteLine("TC : " + item.TCN);
                Console.WriteLine("Date : " + item.Date);

            }
        }
        public void Listele()
        {

            foreach (var item in musteris)
            {
                Console.WriteLine(item);
            }
            
        }
        public void Sil()
        {
            int Id;
            Console.Write("Lütfen Silinecek kişinin Id Giriniz");
            Id = Convert.ToInt32(Console.ReadLine());
            musteris.RemoveAt(Id);
        }

    }
   
}
