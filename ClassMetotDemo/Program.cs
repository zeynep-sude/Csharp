using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.AdSoyad = "Zeynep Kırmacı";
            musteri1.TC = "12345";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.AdSoyad = "Cahit Kırmacı";
            musteri2.TC = "6789";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.AdSoyad);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.List(musteri1);
            musteriManager.Delete(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.List(musteri2);
            musteriManager.Delete(musteri2);
        }

        class Musteri
        {
            public int Id { get; set; }
            public string AdSoyad { get; set; }
            public string TC{ get; set; }
            
        }
       
        
        class MusteriManager
        {
            public void Add(Musteri musteri)
            {
                Console.WriteLine(musteri.AdSoyad+" Eklendi");
            }
            public void List(Musteri musteri)
            {
                Console.WriteLine(musteri.Id +". Müşteri Listeye Eklendi");
            }
            public void Delete(Musteri musteri)
            {
                Console.WriteLine("Müşteri Silindi");
            }
        }
    }
}
