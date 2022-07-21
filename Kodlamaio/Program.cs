using System;
using System.Collections.Generic;

namespace Kodlamaio
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Kurs kurs1 = new Kurs();
            kurs1.Id = 1;
            kurs1.Süresi = 40;
            kurs1.KursAdi = "C#";
            kurs1.EgitmenAdi = "Engin";

            Kurs kurs2 = new Kurs();
            kurs2.Id = 2;
            kurs2.Süresi = 60;
            kurs2.KursAdi = "Python";
            kurs2.EgitmenAdi = "Murat";

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2};
             
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ ":"+kurs.EgitmenAdi);
            }

            Console.ReadLine();
        }
    }
    class Kodlamaio : Kurs
    {
        public void Add(string KursAdi)
        {
            Console.WriteLine("{0} Kurs Eklendi", KursAdi);
        }
        public void Delete(int Id)
        {
            Console.WriteLine("{0} Kurs Silindi",Id);
        }
        public void Update(string KursAdi,int Süresi)
        {
            Console.WriteLine("{0} Kurs Güncellendi");
        }
    }
    class Kurs
    {
        public int Id { get; set; }
        public string KursAdi { get; set; }
        public int Süresi { get; set; }
        public string EgitmenAdi { get; set; }
    }
}
